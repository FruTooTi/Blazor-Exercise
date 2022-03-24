using Microsoft.AspNetCore.SignalR;

namespace TangyApp_Server.Hubs
{
    public class ChatHub : Hub
    {
        public Dictionary<string, string> UsersDict = new Dictionary<string, string>();
        public override async Task OnConnectedAsync()
        {
            string User = Context.GetHttpContext().Request.Query["username"];
            UsersDict.Add(Context.ConnectionId, User);
            var Name = UsersDict.FirstOrDefault(n => n.Key == Context.ConnectionId).Value;
            await SendMessage("", $"{Name} has joined the chat!");
        }
        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            var Name = UsersDict.FirstOrDefault(n => n.Key == Context.ConnectionId).Value;
            await SendMessage("", $"{Name} has left the chat!");
        }
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("GetTheMessage", user, message);
        }
    }
}
