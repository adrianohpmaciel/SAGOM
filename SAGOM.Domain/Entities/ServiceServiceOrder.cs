using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class ServiceServiceOrder
    {
        public int Id { get; private set; }
        public int? IdService { get; private set; }
        public int? IdServiceOrder { get; private set; }

        public ServiceOrder? IdServiceOrderNavigation { get; private set; }
        public Service? IdServiceNavigation { get; private set; }
    }
}
