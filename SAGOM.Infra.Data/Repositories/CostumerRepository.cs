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
    public class CostumerRepository : ICostumerRepository
    {
        SagomDbContext _db;

        public CostumerRepository(SagomDbContext db)
        {
            _db = db;
        }

        public async Task<Costumer> CreateAsync(Costumer costumer)
        {
            _db.Add(costumer);
            await _db.SaveChangesAsync();
            return costumer;
        }

        public async Task<Costumer?> GetCostumerByCPFAsync(string cpf)
        {
            return await _db.Costumers.FindAsync(cpf);
        }

        public async Task<Costumer?> GetCostumerByIdAsync(int id)
        {
            return await _db.Costumers.FindAsync(id);
        }

        public async Task<IEnumerable<Costumer>?> GetCostumersByNameAsync(string name)
        {
            name = name.Trim().ToLower();
            return await _db.Costumers.Where(p => p.CpfNavigation.Name.ToLower()
                                                  .StartsWith(name))
                                                  .ToListAsync();
        }

        public async Task<Costumer?> RemoveAsync(Costumer costumer)
        {
            _db.Remove(costumer);
            await _db.SaveChangesAsync();
            return costumer;
        }

        public async Task<Costumer?> UpdateAsync(Costumer costumer)
        {
            _db.Update(costumer);
            await _db.SaveChangesAsync();
            return costumer;
        }
    }
}
