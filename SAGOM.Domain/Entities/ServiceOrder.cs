﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class ServiceOrder
    {
        public int Id { get; private set; }
        public string Reason { get; private set; }
        public ICollection<Service>? Services { get; private set; }
        public ICollection<Product>? Products { get; private set; }
        public double TotalValue { get; private set; }
        public string Status { get; private set; }

        public ServiceOrder(int id, string reason, ICollection<Service>? services, ICollection<Product>? products, double totalValue, string status)
        {
            Id = id;
            Reason = reason;
            Services = services;
            Products = products;
            TotalValue = totalValue;
            Status = status;
        }
    }
}