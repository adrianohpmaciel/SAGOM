using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class CostumerService
    {
        public int Id { get; private set; }
        public Client Client { get; private set; }
        public Employee Employee { get; private set; }
        public Vehicle Vehicle { get; private set; }
        public string Description { get; private set; }
        public string Status { get; private set; }
        public ICollection<ServiceOrder> ServiceOrders { get; private set; }
        public Bill Bill { get; private set; }

    }
}
