using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.DTOs
{
    public class CostumerServiceDTO
    {
        public int Id { get; private set; }
        public int? IdCostumer { get; private set; }
        public int? IdEmployee { get; private set; }
        public int? IdVehicle { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime? UpdateDateLastStatus { get; private set; }
        public string ProblemDescription { get; private set; } = null!;
        public string Status { get; private set; } = null!;

    }
}
