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
    public class ServiceRepository : IServiceRepository
    {
        SagomDbContext _db;

        public ServiceRepository(SagomDbContext context)
        {
            _db = context;
        }

        public async Task<Service> CreateAsync(Service service)
        {
            _db.Add(service);
            await _db.SaveChangesAsync();
            return service;
        }

        public async Task<Service> GetServiceByIdAsync(int idService)
        {
            return await _db.Services.FindAsync(idService);
        }

        public async Task<IEnumerable<Service>?> GetServicesByNameAsync(string name)
        {
            name = name.Trim().ToLower();
            return await _db.Services.Where(p => p.Name.ToLower()
                                                      .StartsWith(name)
                                                      ).ToListAsync();
        }

        public async Task<Service> RemoveAsync(Service service)
        {
            _db.Remove(service);
            await _db.SaveChangesAsync();
            return service;
        }

        public async Task<Service> UpdateAsync(Service service)
        {
            _db.Update(service);
            await _db.SaveChangesAsync();
            return service;
        }
    }
}
