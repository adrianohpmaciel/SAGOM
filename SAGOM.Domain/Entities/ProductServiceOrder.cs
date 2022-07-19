using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class ProductServiceOrder
    {
        public int Id { get; private set; }
        public int? IdProduct { get; private set; }
        public int? IdServiceOrder { get; private set; }
        public short? Quantity { get; private set; }

        public  ServiceOrder? IdServiceOrderNavigation { get; private set; }
        public  Product? IdProductNavigation { get; private set; }
    }
}
