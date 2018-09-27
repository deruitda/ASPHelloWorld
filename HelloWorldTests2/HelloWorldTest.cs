using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory.Storage.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.API2.Contexts;
using Sample.API2.Controllers;
using Sample.API2.Repository;

namespace HelloWorldTests2
{
    public class HelloWorldTest
    {
        [TestMethod]
        public async Task Test()
        {
            DbContextOptions<HelloWorldContext> options = new DbContextOptions<HelloWorldContext>();
            HelloWorldContext context = new HelloWorldContext(options);
            HelloWorldRepository repo = new HelloWorldRepository(context);
            HelloWorldController controller = new HelloWorldController(repo);

            string str = await controller.GetStringAsync();

            Assert.AreEqual(str, "Hello World");
        }
    }
}
