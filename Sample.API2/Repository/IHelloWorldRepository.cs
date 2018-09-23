using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.API2.Repository
{
    public interface IHelloWorldRepository
    {
        Task<string> GetString();
    }
}
