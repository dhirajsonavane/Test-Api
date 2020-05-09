using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Test.Core.Services;

namespace Test.Api.Controllers
{
    public class MonitoringController : BaseController
    {
        private readonly IMonitoringService _service;
        private readonly ILogger<MonitoringController> _logger;
        private readonly IHostEnvironment _hostEnvironment;

        public MonitoringController(
            IMonitoringService venueTypeService,
            ILogger<MonitoringController> logger,
            IHostEnvironment hostEnvironment
            )
        {
            this._service = venueTypeService;
            this._logger = logger;
            this._hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _service.ListAsync();

            return Ok(result);
        }
    }
}
