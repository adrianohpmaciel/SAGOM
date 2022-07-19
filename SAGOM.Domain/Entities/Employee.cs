using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Employee
    {
        public int Id { get; set; }
        public string? Cpf { get; set; }
        public int IdRole { get; set; }
        public decimal? Salary { get; set; }
        public string? CnpjCompany { get; set; }

        public Company? CnpjCompanyNavigation { get; set; }
        public ICollection<CostumerService> CostumerServices { get; set; }
        public ICollection<Tool> Tools { get; set; }

        public Employee()
        {
            CostumerServices = new HashSet<CostumerService>();
            Tools = new HashSet<Tool>();
        }


    }
}
