using SAGOM.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  SAGOM.Application.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDTO>?> GetEmployeesByName(string name);
        Task<EmployeeDTO?> GetEmployeeByCpf(string cpf);
        Task Add(EmployeeDTO employee);
        Task Update(EmployeeDTO employee);
        Task Remove(EmployeeDTO employee);
    }
}
