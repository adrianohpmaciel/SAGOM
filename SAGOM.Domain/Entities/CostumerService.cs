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
        public int? IdCostumer { get; private set; }
        public int? IdEmployee { get; private set; }
        public int? IdVehicle { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime? UpdateDateLastStatus { get; private set; }
        public string ProblemDescription { get; private set; } = null!;
        public string Status { get; private set; } = null!;
        public int? IdBill { get; private set; }

        public  Costumer? IdCostumerNavigation { get; private set; }
        public  Employee? IdEmployeeNavigation { get; private set; }
        public  Vehicle? IdVehicleNavigation { get; private set; }
        
        public  ICollection<ServiceOrder> ServiceOrders { get; private set; }

        public CostumerService()
        {
            ServiceOrders = new HashSet<ServiceOrder>();
        }


    }
}
