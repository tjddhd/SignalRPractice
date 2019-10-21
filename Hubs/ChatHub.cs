using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace AzureStatsComm.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string msg)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, msg);
        }
    }
}
