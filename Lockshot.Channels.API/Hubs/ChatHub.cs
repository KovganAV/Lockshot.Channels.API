using Microsoft.AspNetCore.SignalR;
using Lockshot.Channels.API.Services;
using System.Threading.Tasks;
using Lockshot.Channels.API.Models;

namespace Lockshot.Channels.API.Hubs
{
    public class ChatHub : Hub
    {
        private readonly MessageService _messageService;

        public ChatHub(MessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task SendMessage(int serverId, string userId, string text)
        {
            var message = new Massage
            {
                ServerId = serverId,
                UserId = userId,
                Text = text,
                DateOnle = DateTime.Now
            };

            await _messageService.SaveMessage(message);

            await Clients.Group(serverId.ToString()).SendAsync("ReceiveMessage", userId, text);
        }

        public async Task JoinServer(int serverId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, serverId.ToString());
        }

        public async Task LeaveServer(int serverId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, serverId.ToString());
        }
    }
}
