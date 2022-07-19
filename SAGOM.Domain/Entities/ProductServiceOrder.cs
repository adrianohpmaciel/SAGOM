using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class ProductServiceOrder
    {
        public int Id { get; set; }
        public int? IdProduct { get; set; }
        public int? IdServiceOrder { get; set; }
        public short? Quantity { get; set; }

        public  ServiceOrder? IdServiceOrderNavigation { get; set; }
        public  Product? IdProductNavigation { get; set; }
    }
}
