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
        Task<IEnumerable<ProductServiceOrder>> GetProductServiceOrdersByProductAsync(Product product);
        Task<IEnumerable<ProductServiceOrder>> GetProductServiceOrdersByServiceOrderAsync(ServiceOrder serviceOrder);
        Task<ProductServiceOrder> GetProductServiceOrderById(int id);
        Task<ProductServiceOrder>  CreateAsync(ProductServiceOrder product);
        Task<ProductServiceOrder>  UpdateAsync(ProductServiceOrder product);
        Task<ProductServiceOrder>  RemoveAsync(ProductServiceOrder product);
    }
}