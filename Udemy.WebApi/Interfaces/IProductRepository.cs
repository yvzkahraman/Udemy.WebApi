using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.WebApi.Data;

namespace Udemy.WebApi.Interfaces
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAllAsync();

        public Task<Product> GetByIdAsync(int id);

        public Task<Product> CreateAsync(Product product);

        public Task UpdateAsync(Product product);

        public Task RemoveAsync(int id);
    }
}
