using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

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
