using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Company
    {
        public string Cnpj { get; set; } = null!;
        public string FantasyName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string CellPhone { get; set; } = null!;

        public  ICollection<Employee> Employees { get; set; }
        public  ICollection<Bill> Bills { get; set; }

        public Company()
        {
            Employees = new HashSet<Employee>();
            Bills = new HashSet<Bill>();
        }
    }
}
