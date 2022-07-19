using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class ServiceOrder
    {
        public int Id { get; private set; }
        public int? IdCostumerService { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime? UpdateDateLastStatus { get; private set; }
        public string Reason { get; private set; } = null!;
        public string Status { get; private set; } = null!;

        public CostumerService? IdCostumerServiceNavigation { get; private set; }
        public ICollection<ProductServiceOrder> ProductServiceOrders { get; private set; }
        public ICollection<ServiceServiceOrder> ServiceServiceOrders { get; private set; }

        public ServiceOrder()
        {
            ProductServiceOrders = new HashSet<ProductServiceOrder>();
            ServiceServiceOrders = new HashSet<ServiceServiceOrder>();
        }
    }
}
