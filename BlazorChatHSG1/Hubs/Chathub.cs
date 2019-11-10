using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatHSG1.Hubs
{
    public class Chathub : Hub
    {
        public async Task SendMessage(string nachricht)
        {
            await Clients.All.SendAsync("Empfangen", nachricht);
        }
    }
}
