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
    public class TonyController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            // Get the local computer host name.
            var hostName = Dns.GetHostName();

            return "Computer name :" + hostName;
        }
    }

}