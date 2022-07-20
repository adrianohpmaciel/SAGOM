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
        public int IdRole { get; private set; }
        public decimal? Salary { get; private set; }
        public string? CnpjCompany { get; private set; }


    }
}
