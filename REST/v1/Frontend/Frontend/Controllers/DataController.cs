using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        // GET data
        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            var url = Environment.GetEnvironmentVariable("BackendUrlENV");
            if (url is null)
            {
                //url = "http://104.40.7.46:8030/data";
                return "NO ENV";
            }

            var client = new HttpClient();
            var response = await client.GetStringAsync(url);
            return response;
        }
    }
}