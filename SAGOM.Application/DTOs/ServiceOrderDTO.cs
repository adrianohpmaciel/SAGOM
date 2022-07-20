using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.DTOs
{
    public class ServiceOrderDTO
    {
        public int Id { get; private set; }
        public int? IdCostumerService { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime? UpdateDateLastStatus { get; private set; }
        public string Reason { get; private set; } = null!;
        public string Status { get; private set; } = null!;

    }
}
