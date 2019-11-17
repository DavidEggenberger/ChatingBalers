using BlazorChat.DataTypes;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatHSG1.Hubs
{
    public class Chathub : Hub
    {
        public async Task SendMessage(string n)
        {
            await Clients.All.SendAsync("Empfangen", n);
        }
    }
}
