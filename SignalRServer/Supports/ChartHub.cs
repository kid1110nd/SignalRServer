using Microsoft.AspNetCore.SignalR;
using SignalRServer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalRServer.Supports
{
    public class ChartHub : Hub
    {
        public async Task BroadcastChartData(List<ChartModel> data) => await Clients.All.SendAsync("broadcastchartdata", data);
    }
}
