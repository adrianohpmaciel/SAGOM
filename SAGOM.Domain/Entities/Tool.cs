using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Tool
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? DiscardDate { get; set; }
        public string Status { get; set; } = null!;
        public int? IdEmployee { get; set; }

        public Employee? IdEmployeeNavigation { get; set; }
    }
}
