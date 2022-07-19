using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class CostumerService
    {
        public int Id { get; set; }
        public int? IdCostumer { get; set; }
        public int? IdEmployee { get; set; }
        public int? IdVehicle { get; set; }
        public DateTime Date { get; set; }
        public DateTime? UpdateDateLastStatus { get; set; }
        public string ProblemDescription { get; set; } = null!;
        public string Status { get; set; } = null!;
        public int? IdBill { get; set; }

        public  Costumer? IdCostumerNavigation { get; set; }
        public  Employee? IdEmployeeNavigation { get; set; }
        public  Vehicle? IdVehicleNavigation { get; set; }
        public  Bill Bill { get; set; } = null!;
        public  ICollection<ServiceOrder> ServiceOrders { get; set; }

        public CostumerService()
        {
            ServiceOrders = new HashSet<ServiceOrder>();
        }


    }
}
