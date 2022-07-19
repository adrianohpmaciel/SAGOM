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
    public class ServiceOrderRepository : IServiceOrderRepository
    {
        SagomDbContext _db;

        public ServiceOrderRepository(SagomDbContext context)
        {
            _db = context;
        }

        public async Task<ServiceOrder> CreateAsync(ServiceOrder serviceOrder)
        {
            _db.Add(serviceOrder);
            await _db.SaveChangesAsync();
            return serviceOrder;
        }

        public async Task<ServiceOrder> GetServiceOrderByIdAsync(int idServiceOrder)
        {
            return await _db.ServiceOrders.FindAsync(idServiceOrder);
        }

        public async Task<IEnumerable<ServiceOrder>?> GetServiceOrdersByCostumerServiceAsync(CostumerService costumerService)
        {
            return await _db.ServiceOrders.Where(so => so.IdCostumerServiceNavigation.Equals(costumerService)).ToListAsync();
        }

        public async Task<ServiceOrder?> RemoveAsync(ServiceOrder serviceOrder)
        {
            _db.Remove(serviceOrder);
            await _db.SaveChangesAsync();
            return serviceOrder;
        }

        public async Task<ServiceOrder?> UpdateAsync(ServiceOrder serviceOrder)
        {
            _db.Update(serviceOrder);
            await _db.SaveChangesAsync();
            return serviceOrder;
        }
    }
}