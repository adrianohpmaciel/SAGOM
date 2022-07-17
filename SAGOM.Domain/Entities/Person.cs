using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Person
    {
        public string Cpf { get; private set; }
        public string FullName { get; private set; }
        public string Address { get; private set; }
        public string CellPhone { get; private set; }
    }
}
