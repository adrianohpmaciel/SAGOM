using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Client
    {
        public int Id { get; set; }
        public string? Cpf { get; set; }
        public ICollection<CostumerService> CostumerServices { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }

        public Client()
        {
            CostumerServices = new HashSet<CostumerService>();
            Vehicles = new HashSet<Vehicle>();
        }

    }
}
