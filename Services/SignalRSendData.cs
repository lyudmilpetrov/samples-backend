using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using samples.SignalR.Hubs;

namespace samples.Services
{
    public class SignalRSendData
    {
        private readonly IHubContext<TasksHub> _tasksHubContext;
        public SignalRSendData(IHubContext<TasksHub> hubContext)
        {
            _tasksHubContext = hubContext;
        }
        public async void sendInfoToClient(string connectionid, string channel, string eventname, string statusstate, int percentcomplete, List<string> filenames = null)
        {
            var Status = new Status
            {
                State = statusstate,
                PercentComplete = percentcomplete,
                FileNames = filenames ?? new List<string>()
            };
            if (connectionid.Length > 0)
            {
                await _tasksHubContext.Clients.Group(channel).SendAsync("OnEvent", channel, new ChannelEvent
                {
                    ChannelName = channel,
                    Name = eventname,
                    Data = Status
                });
            }
        }
    }
}

