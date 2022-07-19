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
    public class CostumerServiceRepository : ICostumerServiceRepository
    {
        SagomDbContext _db;

        public CostumerServiceRepository(SagomDbContext db)
        {
            _db = db;
        }

        public async Task<CostumerService> CreateAsync(CostumerService costumerService)
        {
            _db.Add(costumerService);
            await _db.SaveChangesAsync();
            return costumerService;
        }

        public async Task<CostumerService?> GetCostumerServiceByIdAsync(int id)
        {
            return await _db.CostumerServices.FindAsync(id);
        }

        public async Task<IEnumerable<CostumerService>?> GetCostumerServicesByDataAsync(DateTime date)
        {
            return await _db.CostumerServices.Where(cs => cs.Date.Equals(date)).ToListAsync();
        }

        public async Task<IEnumerable<CostumerService>?> GetCostumerServicesByVehicleAsync(Vehicle vehicle)
        {
            return await _db.CostumerServices.Where(cs => cs.IdVehicleNavigation.Equals(vehicle))
                                                                               .ToListAsync();
        }

        public async Task<CostumerService?> RemoveAsync(CostumerService costumerService)
        {
            _db.Remove(costumerService);
            await _db.SaveChangesAsync();
            return costumerService;
        }

        public async Task<CostumerService?> UpdateAsync(CostumerService costumerService)
        {
            _db.Update(costumerService);
            await _db.SaveChangesAsync();
            return costumerService;
        }
    }
}
