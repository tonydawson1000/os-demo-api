using Microsoft.AspNetCore.Mvc;

namespace OsDemoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TonyController : ControllerBase
    {
        private readonly ILogger<TonyController> _logger;

        public TonyController(ILogger<TonyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogDebug("Hello a DEBUG Messsage");

            _logger.LogInformation("Hello an INFO Message");


            _logger.LogError("Hello an ERROR Message");

            // Get the 'pod' host name.
            return $"Hello World - ITS FRIDAY - Host: '{Environment.MachineName}' - {DateTime.UtcNow}";
        }
    }
}