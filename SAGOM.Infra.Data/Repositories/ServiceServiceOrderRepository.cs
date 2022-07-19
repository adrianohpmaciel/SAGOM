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
    public class ServiceServiceOrderRepository : IServiceServiceOrderRepository
    {
        SagomDbContext _db;

        public ServiceServiceOrderRepository(SagomDbContext context)
        {
            _db = context;
        }

        public async Task<ServiceServiceOrder> CreateAsync(ServiceServiceOrder productServiceOrder)
        {
            _db.Add(productServiceOrder);
            await _db.SaveChangesAsync();
            return productServiceOrder;
        }

        public async Task<ServiceServiceOrder> GetServiceServiceOrderByIdAsync(int idProduct)
        {
            return await _db.ServiceServiceOrders.FindAsync(idProduct);
        }

        public async Task<IEnumerable<ServiceServiceOrder>?> GetServiceServiceOrdersByServiceOrderAsync(ServiceOrder serviceOrder)
        {
            return await _db.ServiceServiceOrders.Where(pso => pso.IdServiceOrderNavigation.Equals(serviceOrder)).ToListAsync();
        }

        public async Task<ServiceServiceOrder> RemoveAsync(ServiceServiceOrder productServiceOrder)
        {
            _db.Remove(productServiceOrder);
            await _db.SaveChangesAsync();
            return productServiceOrder;
        }

        public async Task<ServiceServiceOrder> UpdateAsync(ServiceServiceOrder productServiceOrder)
        {
            _db.Update(productServiceOrder);
            await _db.SaveChangesAsync();
            return productServiceOrder;
        }
    }
}
