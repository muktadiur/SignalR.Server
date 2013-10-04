using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace IMS.SignalR.Models
{
    
    public class GroupHub : Hub
    {
        public void Send(string name, string msg) {
            Clients.Group(name).Show(name, msg);
        }
        
        public void Join(string name) {
            Groups.Add(Context.ConnectionId, name);
        }
        public void Remove(string name) {
            Groups.Remove(Context.ConnectionId, name);
        }
    }
}