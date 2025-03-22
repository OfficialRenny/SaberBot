using System.Text.RegularExpressions;
using Betalgo.Ranul.OpenAI.Interfaces;
using Betalgo.Ranul.OpenAI.ObjectModels.RequestModels;
using Discord;
using Google.Apis.YouTube.v3;
using Saber.Common.Services.Interfaces;
using HtmlAgilityPack;
using OpenAIModels = Betalgo.Ranul.OpenAI.ObjectModels.Models;


namespace Saber.Common.Services;

public class AiSummariseService : ISummaryService
{
    private readonly IOpenAIService _service;
    private readonly ILogger _logger;
    private readonly YoutubeDlService _youtubeDl;
    private readonly HttpClient _httpClient;
    
    private readonly Regex _youtubeVideoRegex = new Regex(@"^(?:(?:https|http):\/\/)?(?:www\.)?(?:youtube\.com|youtu\.be).*(?<=\/|v\/|u\/|embed\/|shorts\/|watch\?v=)(?<!\/user\/)(?<id>[\w\-]{11})(?=\?|&|$)");
    
    public AiSummariseService(IOpenAIService service, ILogger logger, HttpClient httpClient, YoutubeDlService youtubeDl)
    {
        _service = service;
        _logger = logger;
        _httpClient = httpClient;
        _youtubeDl = youtubeDl;
    }
    
    async Task<string> FetchPageContent(string url)
    {
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
        catch (Exception e)
        {
            await _logger.LogAsync(LogSeverity.Error, nameof(FetchPageContent), e.Message, e);
            return string.Empty;
        }
    }
    
    string ExtractMainContent(HtmlDocument doc)
    {
        var mainNode = doc.DocumentNode.SelectSingleNode("//article") ??
                       doc.DocumentNode.SelectSingleNode("//main") ??
                       doc.DocumentNode.SelectSingleNode("//div[@id='content']");
        
        if (mainNode == null)
            mainNode = doc.DocumentNode.SelectSingleNode("//body");
        
        if (mainNode != null)
        {
            var nodeXpaths = mainNode.SelectNodes("//script|//style").Select(x => x.XPath);
            foreach (var node in nodeXpaths)
            {
                var mainContentNode = mainNode.SelectSingleNode(node);
                mainContentNode.Remove();
            }
            
            return mainNode.InnerText.Trim();
        }
        return "";
    }
    
    public async Task<string> AiSummarise(string content, int? length = null, bool isVideo = false)
    {
        var prompt = 
            $"Summarise the following ${(isVideo ? "transcript" : "text")}, you must only use a maximum of {length ?? 7} paragraphs/points. " +
            $"Respond with only the summarised text, Markdown formatting is permitted to separate or highlight key points if required, but keep it as compact as possible. " +
            $"Translate to English if the text is not already in English. " +
            $"Keep your response to fewer than 1500 characters:\n\n" +
            $"{content}";

        var chat = ChatMessage.FromSystem(prompt);
        
        var response = _service.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
        {
            Messages = new List<ChatMessage> { chat },
            User = "SaberBot",
            Model = OpenAIModels.Gpt_4o,
            MaxTokens = 1024,
        });

        await response;
        
        var message = response.Result.Choices.FirstOrDefault()?.Message.Content;
        
        if (!string.IsNullOrWhiteSpace(message))
            message = Regex.Replace(message, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline);

        return message ?? string.Empty;
    }

    public async Task<string> Summarize(string url, int? length = null)
    {
        try
        {
            if (GetYoutubeVideoId(url) is string videoId)
            {
                string videoUrl = $"https://www.youtube.com/watch?v={videoId}";
                string videoContent = await _youtubeDl.DownloadCaptions(videoUrl);
                if (string.IsNullOrWhiteSpace(videoContent))
                    return "Could not fetch the video's captions.";
                
                return await AiSummarise(videoContent, length, true);
            }
            
            string content = await FetchPageContent(url);
            if (string.IsNullOrWhiteSpace(content))
                return "Could not fetch the content of the link.";
        
            var doc = new HtmlDocument();
            doc.LoadHtml(content);
            string mainContent = ExtractMainContent(doc);
        
            if (string.IsNullOrWhiteSpace(mainContent))
                return "Could not extract the main content of the link.";
            
            return await AiSummarise(mainContent, length);
        } catch (Exception e)
        {
            await _logger.LogAsync(LogSeverity.Error, nameof(Summarize), e.Message, e);
            return "Could not summarize the link.";
        }
    }

    string? GetYoutubeVideoId(string url)
    {
        var match = _youtubeVideoRegex.Match(url);
        if (match.Success)
            return match.Groups["id"].Value;
        
        return null;
    }
}