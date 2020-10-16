using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;

namespace hello_world_api.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        private RegistryKey registryKey;

        // GET api/helllo
        [HttpGet]
        public string Get()
        {
            registryKey = Registry.CurrentUser.CreateSubKey("test");
            registryKey.CreateSubKey("test");
            return "Hello world!!!!!!";
        }

    }
}
