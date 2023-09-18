using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Teste
{
    public sealed class NotificationsHub : Hub
    {
        public async Task SendNotification(string content)
        {
            Console.WriteLine(content);
            await Clients.All.SendAsync("ReceiveNotification", content);
        }
    }

}