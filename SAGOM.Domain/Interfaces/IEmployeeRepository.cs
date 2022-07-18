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
        Task<IEnumerable<Employee>> GetEmployeesAsync();
        Task<Employee> GetEmployeesByCnpjAsync(string cnpj);
        Task<IEnumerable<Employee>> GetEmployeeAsync(Person person);
        Task<IEnumerable<Employee>> GetEmployeeAsync(int employeeId);
        Task<IEnumerable<Employee>> CreateAsync(Employee employee);
        Task<IEnumerable<Employee>> UpdateAsync(Employee employee);
        Task<IEnumerable<Employee>> RemoveAsync(Employee employee);
    }
}
