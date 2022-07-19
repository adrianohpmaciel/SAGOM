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
    public class EmployeeRepository : IEmployeeRepository
    {
        SagomDbContext _db;

        public EmployeeRepository(SagomDbContext context)
        {
            _db = context;
        }

        public async Task<Employee> CreateAsync(Employee employee)
        {
            _db.Add(employee);
            await _db.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee?> GetEmployeeByCpfAsync(string cpf)
        {
            return await _db.Employees.FindAsync(cpf);
        }

        public async Task<IEnumerable<Employee>?> GetEmployeesByNameAsync(string name)
        {
            return await _db.Employees.Where(p => p.CpfNavigation.Name.ToLower()
                                                      .StartsWith(name.ToLower())
                                                      ).ToListAsync();
        }

        public async Task<Employee?> RemoveAsync(Employee employee)
        {
            _db.Employees.Remove(employee);
            await _db.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee?> UpdateAsync(Employee employee)
        {
            _db.Employees.Update(employee);
            await _db.SaveChangesAsync();
            return employee;
        }
    }
}
