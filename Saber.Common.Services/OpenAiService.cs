using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using OpenAI;
using OpenAI.Interfaces;
using OpenAI.ObjectModels;
using OpenAI.ObjectModels.RequestModels;
using OpenAI.Tokenizer.GPT3;
using OpenAIModels = OpenAI.ObjectModels.Models;

namespace Saber.Common.Services
{
    public class OpenAiService
    {
        private readonly DiscordSocketClient _client;
        private readonly IOpenAIService _service;
        private readonly ConcurrentDictionary<ulong, List<ChatMessage>> ServerChats = new();

        private ChatMessage DefaultSystemMessage => ChatMessage.FromSystem($"You are a discord bot called {_client.CurrentUser.GlobalName}.");

        public OpenAiService(IOpenAIService service, DiscordSocketClient client)
        {
            _service = service;
            _client = client;
        }

        public List<ChatMessage> GetChatMessages(ulong serverId)
        {
            if (!ServerChats.TryGetValue(serverId, out var chat))
            {
                chat = new List<ChatMessage> { DefaultSystemMessage };
                ServerChats.TryAdd(serverId, chat);
            }
            chat = Reduce(chat);
            return chat;
        }

        public void AddChatMessage(ulong serverId, ChatMessage message)
        {
            if (!ServerChats.TryGetValue(serverId, out var chat))
            {
                chat = new List<ChatMessage> { DefaultSystemMessage };
                ServerChats.TryAdd(serverId, chat);
            }
            chat.Add(message);
        }

        public List<ChatMessage> Reduce(List<ChatMessage> messages, int maxTokens = 400)
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

            if (!reduced.Any(x => x.Role == StaticValues.ChatMessageRoles.System))
            {
                reduced.Insert(0, DefaultSystemMessage);
            }

            return reduced;
        }

        public async Task<string> Ask(string question, IUser user, IGuild? guild = null)
        {
            ulong serverId = guild?.Id ?? user.Id;

            var chat = GetChatMessages(serverId);
            chat.Add(ChatMessage.FromUser(question, user.GlobalName));

            var result = await _service.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
            {
                Messages = chat,
                User = user.Id.ToString(),
                Model = OpenAIModels.ChatGpt3_5Turbo,
                MaxTokens = 400,
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
            return ServerChats.TryRemove(serverId, out _);
        }

        public async Task<IEnumerable<string>?> ImageGen(string prompt, int count = 1, IUser? user = null)
        {
            var result = await _service.Image.CreateImage(new ImageCreateRequest
            {
                Prompt = prompt,
                N = count,
                User = user?.Id.ToString(),
                Size = "1024x1024",
            });

            if (result.Successful)
            {
                return result.Results.Select(x => x.Url);
            } else
            {
                return null;
            }
        }
    }
}
