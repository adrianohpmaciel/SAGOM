using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Tool
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public decimal? Price { get; private set; }
        public DateTime? PurchaseDate { get; private set; }
        public DateTime? DiscardDate { get; private set; }
        public string Status { get; private set; } = null!;
        public int? IdEmployee { get; private set; }

        public Employee? IdEmployeeNavigation { get; private set; }
    }
}
