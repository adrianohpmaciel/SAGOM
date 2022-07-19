using Microsoft.EntityFrameworkCore;
using SAGOM.Domain.Entities;
using SAGOM.Domain.Interfaces;
using SAGOM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Infra.Data.Repositories
{
    public class ProductServiceOrderRepository : IProductServiceOrderRepository
    {
        SagomDbContext _db;

        public ProductServiceOrderRepository(SagomDbContext context)
        {
            _db = context;
        }

        public async Task<ProductServiceOrder> CreateAsync(ProductServiceOrder productServiceOrder)
        {
            _db.Add(productServiceOrder);
            await _db.SaveChangesAsync();
            return productServiceOrder;
        }

        public async Task<ProductServiceOrder> GetProductServiceOrderByIdAsync(int idProduct)
        {
            return await _db.ProductServiceOrders.FindAsync(idProduct);
        }

        public async Task<IEnumerable<ProductServiceOrder>?> GetProductServiceOrdersByServiceOrderAsync(ServiceOrder serviceOrder)
        {
            return await _db.ProductServiceOrders.Where(pso => pso.IdServiceOrderNavigation.Equals(serviceOrder)).ToListAsync();
        }

        public async Task<ProductServiceOrder> RemoveAsync(ProductServiceOrder productServiceOrder)
        {
            _db.Remove(productServiceOrder);
            await _db.SaveChangesAsync();
            return productServiceOrder;
        }

        public async Task<ProductServiceOrder> UpdateAsync(ProductServiceOrder productServiceOrder)
        {
            _db.Update(productServiceOrder);
            await _db.SaveChangesAsync();
            return productServiceOrder;
        }
    }
}
