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
    public class CompanyRepository : ICompanyRepository
    {
        SagomDbContext _db;

        public CompanyRepository(SagomDbContext context)
        {
            _db = context;
        }

        public async Task<Company> CreateAsync(Company company)
        {
            _db.Add(company);
            await _db.SaveChangesAsync();
            return company;
        }

        public async Task<Company?> GetCompanyByCnpjAsync(string cnpj)
        {
            return await _db.Companies.FindAsync(cnpj);
        }

        public async Task<IEnumerable<Company>?> GetCompaniesByNameAsync(string fantasyName)
        {
            fantasyName = fantasyName.Trim().ToLower();
            return await _db.Companies.Where(p => p.FantasyName.ToLower()
                                                      .StartsWith(fantasyName)
                                                      ).ToListAsync();
        }

        public async Task<Company?> RemoveAsync(Company company)
        {
            _db.Remove(company);
            await _db.SaveChangesAsync();
            return company;
        }

        public async Task<Company?> UpdateAsync(Company company)
        {
            _db.Update(company);
            await _db.SaveChangesAsync();
            return company;
        }
    }
}
