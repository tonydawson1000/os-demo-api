using Microsoft.AspNetCore.Mvc;

namespace OsDemoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OpenShiftPoCController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            // Get the 'pod' host name.
            return $"Hello OpenShiftPoC - Host: '{Environment.MachineName}' - {DateTime.UtcNow}";
        }
    }
}