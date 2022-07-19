using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface IProductServiceOrderRepository
    {
        Task<IEnumerable<Product>> GetAllProductServiceOrdersAsync();
        Task<IEnumerable<Product>> GetProductServiceOrdersByProductAsync(Product product);
        Task<IEnumerable<Product>> GetProductServiceOrdersByServiceOrderAsync(ServiceOrder serviceOrder);
        Task<IEnumerable<Product>> GetProductServiceOrderById(int id);
        Task<IEnumerable<Product>> CreateAsync(Product product);
        Task<IEnumerable<Product>> UpdateAsync(Product product);
        Task<IEnumerable<Product>> RemoveAsync(Product product);
    }
}