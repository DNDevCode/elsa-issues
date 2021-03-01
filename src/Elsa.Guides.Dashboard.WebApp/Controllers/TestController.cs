using Elsa.Activities.Workflows.Extensions;
using Elsa.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elsa.Guides.Dashboard.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IWorkflowInvoker _invoker;

        public TestController(IWorkflowInvoker invoker)
        {
            _invoker = invoker;
        }

        [HttpPost("initialize")]
        public async Task<IActionResult> Intitiaize()
        {
            await _invoker.TriggerSignalAsync("INITIALIZE");
            return Ok();
        }

        [HttpPost("signal-b")]
        public async Task<IActionResult> SignalB()
        {
            await _invoker.TriggerSignalAsync("SIGNAL_B");
            return Ok();
        }

    }
}
