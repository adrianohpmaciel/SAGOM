﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Tool
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Value { get; private set; }
        public DateTime PurchaseDate { get; private set; }
        public DateTime DiscardDate { get; private set; }
        public string Status { get; private set; }
        public Employee Responsible { get; private set; }

        public Tool(int id, string name, string description, string value, DateTime purchaseDate, DateTime discardDate, string status, Employee responsible)
        {
            Id = id;
            Name = name;
            Description = description;
            Value = value;
            PurchaseDate = purchaseDate;
            DiscardDate = discardDate;
            Status = status;
            Responsible = responsible;
        }
    }
}