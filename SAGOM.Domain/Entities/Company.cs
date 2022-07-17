﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Company
    {
        public string Cnpj { get; private set; }
        public string FantasyName { get; private set; }
        public string Address { get; private set; }
        public string Telephone { get; private set; }

    }
}
