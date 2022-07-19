﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Service
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public decimal Price { get; private set; }

        public  ICollection<ServiceServiceOrder> ServiceServiceOrders { get; private set; }

        public Service()
        {
            ServiceServiceOrders = new HashSet<ServiceServiceOrder>();
        }

        public Service(int id, string name, string description, decimal price)
        {
            ServiceServiceOrders = new HashSet<ServiceServiceOrder>();
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
