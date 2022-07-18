﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Quantity { get; private set; }
        public double UnitValue { get; private set; }

        public Product(int id, string name, string description, int quantity, double unitValue)
        {
            Id = id;
            Name = name;
            Description = description;
            Quantity = quantity;
            UnitValue = unitValue;
        }

        public double GetTotal()
        {
            return UnitValue * Quantity;
        }

    }

}