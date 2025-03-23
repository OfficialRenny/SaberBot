using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Betalgo.Ranul.OpenAI;
using Betalgo.Ranul.OpenAI.Interfaces;
using Betalgo.Ranul.OpenAI.ObjectModels;
using Betalgo.Ranul.OpenAI.ObjectModels.RequestModels;
using Betalgo.Ranul.OpenAI.Tokenizer.GPT3;
using NetCord;
using NetCord.Gateway;
using Saber.Common.Services.Interfaces;
using OpenAIModels = Betalgo.Ranul.OpenAI.ObjectModels.Models;

namespace Saber.Common.Services
{
    public class OpenAiService(IOpenAIService service, GatewayClient client) : IChatBot, IImageGen
    {
        private readonly ConcurrentDictionary<ulong, List<ChatMessage>> _serverChats = new();

        private const int MaxTokens = 4096;
        
        private ChatMessage DefaultSystemMessage => 
            ChatMessage.FromSystem($"You are a discord bot called {client.Cache.User?.Username}. You are to assist with any requests to the best of your abilities.");

        private List<ChatMessage> GetChatMessages(ulong serverId)
        {
            if (!_serverChats.TryGetValue(serverId, out var chat))
            {
                chat = new List<ChatMessage> { DefaultSystemMessage };
                _serverChats.TryAdd(serverId, chat);
            }
            chat = Reduce(chat);
            return chat;
        }

        private void AddChatMessage(ulong serverId, ChatMessage message)
        {
            if (!_serverChats.TryGetValue(serverId, out var chat))
            {
                chat = new List<ChatMessage> { DefaultSystemMessage };
                _serverChats.TryAdd(serverId, chat);
            }
            chat.Add(message);
        }

        private List<ChatMessage> Reduce(List<ChatMessage> messages, int maxTokens = MaxTokens)
        {
            int curTokenCount = 0;
            var reduced = new List<ChatMessage>();

            foreach (var msg in messages.Reverse<ChatMessage>())
            {
                if (msg.Role == StaticValues.ChatMessageRoles.User)
                {
                    var msgTokenCount = TokenizerGpt3.TokenCount(msg.Content);
                    if (curTokenCount + msgTokenCount > maxTokens)
                    {
                        break;
                    }
                    curTokenCount += msgTokenCount;
                }

                reduced.Insert(0, msg);
            }

            if (reduced.All(x => x.Role != StaticValues.ChatMessageRoles.System))
            {
                reduced.Insert(0, DefaultSystemMessage);
            }

            return reduced;
        }

        public async Task<string> Ask(string question)
            => await Ask(question, null);
        
        public async Task<string> Ask(string question, User? user, Guild? guild = null)
        {
            ulong serverId = guild?.Id ?? user?.Id ?? 0;
            string userName = user?.GlobalName ?? "Anonymous";

            var chat = GetChatMessages(serverId);
            chat.Add(ChatMessage.FromUser(question, userName));

            var result = await service.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
            {
                Messages = chat,
                User = user?.Id.ToString() ?? userName,
                Model = OpenAIModels.Gpt_4o,
                MaxTokens = MaxTokens,
            });

            if (result.Successful)
            {
                var response = result.Choices.First().Message.Content;
                AddChatMessage(serverId, ChatMessage.FromAssistant(response));
                return response;
            } else
            {
                return "I'm sorry, I don't know how to answer that.";
            }
        }

        public bool ClearHistory(ulong serverId)
        {
            return _serverChats.TryRemove(serverId, out _);
        }

        /// <summary>
        /// Generates an image using the OpenAI Image API.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="count"></param>
        /// <param name="user"></param>
        /// <returns>
        /// A list of base64 encoded images, or null if the request failed.
        /// </returns>
        public async Task<IEnumerable<string>?> ImageGen(string prompt, int count = 1, User? user = null)
        {
            var result = await service.Image.CreateImage(new ImageCreateRequest
            {
                Prompt = prompt,
                N = count,
                User = user?.Id.ToString(),
                Size = "1024x1024",
                ResponseFormat = "b64_json"
            });

            return result.Successful ? result.Results.Select(x => x.B64) : null;
        }
    }
}
