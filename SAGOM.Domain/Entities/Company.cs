using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Company
    {
        public string Cnpj { get; private set; } = null!;
        public string FantasyName { get; private set; } = null!;
        public string Address { get; private set; } = null!;
        public string Phone { get; private set; } = null!;

        public  ICollection<Employee> Employees { get; private set; }
        public  ICollection<Bill> Bills { get; private set; }

        public Company()
        {
            Employees = new HashSet<Employee>();
            Bills = new HashSet<Bill>();
        }
    }
}
