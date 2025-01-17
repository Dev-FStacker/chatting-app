using ChattingApp.Models;

namespace ChattingApp.Hubs.Clients
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}
