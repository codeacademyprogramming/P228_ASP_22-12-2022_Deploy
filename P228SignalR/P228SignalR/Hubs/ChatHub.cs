using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228SignalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task MesajGonder(string name, string message)
        {
            await Clients.All.SendAsync("MesajQebulEt", name, message);
        }
    }
}
