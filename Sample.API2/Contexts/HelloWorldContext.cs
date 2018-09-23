//using ContactsApi.Models;
using Microsoft.EntityFrameworkCore;
using Sample.API2.Models;

namespace Sample.API2.Contexts
{
    public class HelloWorldContext : DbContext
    {
        public HelloWorldContext(DbContextOptions<HelloWorldContext> options) : base(options)
        {
        }

        public HelloWorldContext() { }

        public DbSet<HelloWorld> HelloWorld { get; set; }
    }
}
