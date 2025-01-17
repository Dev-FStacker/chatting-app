using ChattingApp.Hubs.Clients;
using ChattingApp.Models;
using Microsoft.AspNetCore.SignalR;

namespace ChattingApp.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        public async Task SendMessage(ChatMessage message)
        {

        }
    }
}
