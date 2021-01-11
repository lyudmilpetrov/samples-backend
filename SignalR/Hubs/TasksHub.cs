using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using samples.Services;
using samples.SignalR;

namespace samples.SignalR.Hubs
{
    public class TasksHub : Hub
    {
        public async Task SendMessage(string name, string message)
        {
            string msg = string.Format("Connection ID - {0}; Message -- {1}", Context.ConnectionId, message);
            Trace.WriteLine(msg);
            await Clients.Caller.SendAsync("SendThisMessage", Context.ConnectionId);
            // or
            // await Clients.Client(Context.ConnectionId).SendAsync("SendThisMessage", message);
        }
        public async Task GetConnectionID()
        {
            await Clients.Caller.SendAsync("ReceiveConnectionID", Context.ConnectionId);
        }
        public async Task JoinRoom(string room)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, room);
        }
        public async Task LeaveRoom(string room)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, room);
        }
        public async Task SendMessageForRoom(string room, string message)
        {
            string msg = string.Format("Connection ID - {0}; Room -- {1}; Message - {2}", Context.ConnectionId, room, message);
            Trace.WriteLine(msg);
            await Clients.Group(room).SendAsync("SendThisMessage", msg);
        }
        [HubMethodName("RegisterUser")]
        public async Task<string> RegisterUser(string machinename, string encrkey)
        {
            Connections conn = new Connections();
            string connection = conn.Get_Connection(encrkey, "_con_1");
            // code here to register onto server
            await Clients.Caller.SendAsync("Send", $"{machinename} was registered!");
            return "done";
        }
        [HubMethodName("Subscribe")]
        public async Task<ChannelEvent> Subscribe(string channel)
        {
            Trace.WriteLine(channel);
            await Groups.AddToGroupAsync(Context.ConnectionId, channel);
            var ev = new ChannelEvent
            {
                ChannelName = channel,
                Name = "user.subscribed",
                Data = new
                {
                    Context.ConnectionId,
                    ChannelName = channel
                }
            };
            await Clients.Caller.SendAsync("Subscribed", ev);
            return ev;
        }
        public async Task Unsubscribe(string channel)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, channel);
            await Clients.Caller.SendAsync("Send", $"{Context.ConnectionId} has left the group {channel}!");
        }
        public async Task Publish(ChannelEvent channelEvent)
        {
            await Clients.Group(channelEvent.ChannelName).SendAsync(channelEvent.ChannelName, channelEvent);
            if (channelEvent.ChannelName != Constants.AdminChannel)
            {
                await Clients.Group(Constants.AdminChannel).SendAsync(Constants.AdminChannel, channelEvent);
            }
            await Task.FromResult(0);
        }
        public async Task PublishToSingleClient(ChannelEvent channelEvent)
        {
            await Clients.Client(Context.ConnectionId).SendAsync(channelEvent.ChannelName, channelEvent);
        }
        public override async Task OnConnectedAsync()
        {
            var ev = new ChannelEvent
            {
                ChannelName = Constants.AdminChannel,
                Name = "user.connected",
                Data = new
                {
                    Context.ConnectionId,
                }
            };
            await Publish(ev);
            await Groups.AddToGroupAsync(Context.ConnectionId, Constants.AdminChannel);
            await base.OnConnectedAsync();
        }
        public async override Task OnDisconnectedAsync(Exception exception)
        {
            var ev = new ChannelEvent
            {
                ChannelName = Constants.AdminChannel,
                Name = "user.disconnected",
                Data = new
                {
                    Context.ConnectionId,
                }
            };
            await Publish(ev);
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, "SignalR Users");
            await base.OnDisconnectedAsync(exception);
        }
        public async void SendInfoToClient(string channel, string eventname, string statusstate, int percentcomplete, List<string> filenames = null)
        {
            var Status = new Status
            {
                State = statusstate,
                PercentComplete = percentcomplete,
                FileNames = filenames ?? new List<string>()
            };
            await Clients.Group(channel).SendAsync("OnEvent", channel, new ChannelEvent {
            ChannelName= channel,
            Name = eventname,
            Data = Status
            });
        }    
    }
    public class ChannelEvent
    {
        /// <summary>
        /// The name of the event
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The name of the channel the event is associated with
        /// </summary>
        public string ChannelName { get; set; }

        /// <summary>
        /// The date/time that the event was created
        /// </summary>
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// The data associated with the event
        /// </summary>
        public object Data
        {
            get { return _data; }
            set
            {
                _data = value;
                this.Json = JsonConvert.SerializeObject(_data);
            }
        }
        private object _data;

        /// <summary>
        /// A JSON representation of the event data. This is set automatically
        /// when the Data property is assigned.
        /// </summary>
        public string Json { get; private set; }

        public ChannelEvent()
        {
            Timestamp = DateTimeOffset.Now;
        }
    }
    public static class Constants
    {
        public const string AdminChannel = "admin_channel";
        public const string TasksChannel = "tasks";
    }
    public class Status
    {
        public string State { get; set; }
        public double PercentComplete { get; set; }

        public List<string> FileNames { get; set; }
    }


}
