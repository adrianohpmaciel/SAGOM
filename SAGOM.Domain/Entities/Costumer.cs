using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Costumer
    {
        public int Id { get; set; }
        public string? Cpf { get; set; }
        public Person? CpfNavigation { get; set; }
        public ICollection<CostumerService> CostumerServices { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }

        public Costumer()
        {
            CostumerServices = new HashSet<CostumerService>();
            Vehicles = new HashSet<Vehicle>();
        }

    }
}
