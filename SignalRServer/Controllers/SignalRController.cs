using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRServer.Supports;

namespace SignalRServer.Controllers
{
    [ApiController]
    public class SignalRController : ControllerBase
    {
        private IHubContext<ChartHub> _hub;

        public SignalRController(IHubContext<ChartHub> hub)
        {
            _hub = hub;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return Ok("Server SignalR v1.0");
        }

        [HttpGet]
        [Route("[controller]/start")]
        public IActionResult Start()
        {
            TimerManager timerManager = new TimerManager(() => _hub.Clients.All.SendAsync("transferchartdata", DataManager.GetData()));
            return Ok(new { Message = "Start SignalR completed" });
        }
    }
}
