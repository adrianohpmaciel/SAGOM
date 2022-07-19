﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Employee
    {
        public int Id { get; private set; }
        public string? Cpf { get; private set; }
        public int IdRole { get; private set; }
        public decimal? Salary { get; private set; }
        public string? CnpjCompany { get; private set; }

        public Company? CnpjCompanyNavigation { get; private set; }
        public  Person? CpfNavigation { get; private set; }
        public  Role IdRoleNavigation { get; private set; } = null!;
        public ICollection<CostumerService> CostumerServices { get; private set; }
        public ICollection<Tool> Tools { get; private set; }

        public Employee()
        {
            CostumerServices = new HashSet<CostumerService>();
            Tools = new HashSet<Tool>();
        }


    }
}
