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
    public class BillRepository : IBillRepository
    {
        SagomDbContext _db;

        public BillRepository(SagomDbContext context)
        {
            _db = context;
        }

        public async Task<Bill> CreateAsync(Bill bill)
        {
            _db.Add(bill);
            await _db.SaveChangesAsync();
            return bill;
        }

        public async Task<Bill?> GetBillByIdAsync(int id)
        {
            return await _db.Bills.FindAsync(id);
        }

        public async Task<IEnumerable<Bill>?> GetBillsByData(DateTime data)
        {
            return await _db.Bills.Where(b => b.Date == data).ToListAsync();
        }

        public async Task<Bill?> RemoveAsync(Bill bill)
        {
            _db.Remove(bill);
            await _db.SaveChangesAsync();
            return bill;
        }

        public async Task<Bill?> UpdateAsync(Bill bill)
        {
            _db.Update(bill);
            await _db.SaveChangesAsync();
            return bill;
        }
    }
}
