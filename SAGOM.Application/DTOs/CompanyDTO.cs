using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.DTOs
{
    public sealed class CompanyDTO
    {
        public string Cnpj { get; private set; } = null!;
        public string FantasyName { get; private set; } = null!;
        public string Address { get; private set; } = null!;
        public string Phone { get; private set; } = null!;

    }
}
