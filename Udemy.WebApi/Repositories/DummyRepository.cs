using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.WebApi.Interfaces;

namespace Udemy.WebApi.Repositories
{
    public class DummyRepository : IDummyRepository
    {
        public string GetName()
        {
            return "Yavuz";
        }
    }
}
