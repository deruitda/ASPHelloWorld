using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sample.API2.Repository;

namespace Sample.API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : Controller
    {
        public IHelloWorldRepository HelloWorldRepo { get; set; }

        public HelloWorldController(IHelloWorldRepository repo)
        {
            HelloWorldRepo = repo;
        }

        [HttpGet]
        public async Task<string> GetStringAsync()
        {
            return await HelloWorldRepo.GetString();
        }
    }
}
