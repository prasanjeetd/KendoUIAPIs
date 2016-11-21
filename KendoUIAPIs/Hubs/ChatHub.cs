﻿using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace KendoUIAPIs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }

    }
}