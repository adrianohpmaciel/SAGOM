using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class ServiceServiceOrder
    {
        public int Id { get; set; }
        public int? IdService { get; set; }
        public int? IdServiceOrder { get; set; }

        public ServiceOrder? IdServiceOrderNavigation { get; set; }
        public Service? IdProductNavigation { get; set; }
    }
}
