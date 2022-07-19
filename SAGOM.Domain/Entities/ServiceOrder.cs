using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class ServiceOrder
    {
        public int Id { get; set; }
        public int? IdCostumerService { get; set; }
        public DateTime Date { get; set; }
        public DateTime? UpdateDateLastStatus { get; set; }
        public string Reason { get; set; } = null!;
        public string Status { get; set; } = null!;

        public CostumerService? IdCostumerServiceNavigation { get; set; }
        public ICollection<ProductServiceOrder> ProductServiceOrders { get; set; }
        public ICollection<ServiceServiceOrder> ServiceServiceOrders { get; set; }

        public ServiceOrder()
        {
            ProductServiceOrders = new HashSet<ProductServiceOrder>();
            ServiceServiceOrders = new HashSet<ServiceServiceOrder>();
        }
    }
}
