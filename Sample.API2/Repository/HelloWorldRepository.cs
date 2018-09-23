using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sample.API2.Contexts;

namespace Sample.API2.Repository
{
    public class HelloWorldRepository : IHelloWorldRepository
    {
        private HelloWorldContext _context;

        public HelloWorldRepository(HelloWorldContext context)
        {
            _context = context;
        }

        public async Task<string> GetString()
        {
            //fake the async
            await _context.HelloWorld.ToListAsync();

            return "Hello World";
        }
    }
}
