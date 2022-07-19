using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        //Task<IEnumerable<Employee>?> GetEmployeesByCnpjAsync(string cnpj);
        Task<IEnumerable<Employee>?> GetEmployeesByNameAsync(string name);
        Task<Employee?> GetEmployeeByCpfAsync(string cpf);
        Task<Employee> CreateAsync(Employee employee);
        Task<Employee?> UpdateAsync(Employee employee);
        Task<Employee?> RemoveAsync(Employee employee);
    }
}
