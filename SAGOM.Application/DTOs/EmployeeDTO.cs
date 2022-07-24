using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; private set; }
        public string? Cpf { get; private set; }
        public int? IdRole { get; private set; }
        public decimal? Salary { get; private set; }
        public string? CnpjCompany { get; private set; }
        public CompanyDTO? CnpjCompanyNavigation { get; private set; }
        public PersonDTO? CpfNavigation { get; set; }
        public RoleDTO? IdRoleNavigation { get; set; }

        public EmployeeDTO(PersonDTO cpfNavigation)
        {
            CpfNavigation = cpfNavigation;
        }

        public EmployeeDTO(string? cpf, int? idRole, decimal? salary, string? cnpjCompany)
        {
            Cpf = cpf;
            IdRole = idRole;
            Salary = salary;
            CnpjCompany = cnpjCompany;
        }
    }
}
