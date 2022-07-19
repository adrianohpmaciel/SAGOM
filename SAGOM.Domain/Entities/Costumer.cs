using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Costumer
    {
        public int Id { get; private set; }
        public string? Cpf { get; private set; }
        public Person? CpfNavigation { get; private set; }
        public ICollection<CostumerService> CostumerServices { get; private set; }
        public ICollection<Vehicle> Vehicles { get; private set; }

        public Costumer()
        {
            CostumerServices = new HashSet<CostumerService>();
            Vehicles = new HashSet<Vehicle>();
        }

    }
}
