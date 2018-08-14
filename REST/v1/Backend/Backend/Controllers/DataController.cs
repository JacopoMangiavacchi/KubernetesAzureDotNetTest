using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Backend.Controllers
{
    class Data
    {
        public string platform { get; set; }
        public string protocol { get; set; }
        public int version { get; set; }
    }

    [Route("[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        // GET data
        [HttpGet]
        public ActionResult<string> Get()
        {
            var data = new Data {platform = ".Net Core", protocol = "REST", version = 1};

            return  JsonConvert.SerializeObject(data);                
        }
    }
}