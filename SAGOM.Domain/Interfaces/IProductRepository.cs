using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<IEnumerable<Product>> GetProductsByNameAsync(string name);
        Task<IEnumerable<Product>> GetProductByIdAsync(string idProduct);
        Task<IEnumerable<Product>> CreateAsync(Product product);
        Task<IEnumerable<Product>> UpdateAsync(Product product);
        Task<IEnumerable<Product>> RemoveAsync(Product product);
    }
}