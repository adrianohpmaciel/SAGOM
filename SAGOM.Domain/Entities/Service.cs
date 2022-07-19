using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Service
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }

        public  ICollection<ServiceServiceOrder> ServiceServiceOrders { get; set; }

        public Service()
        {
            ServiceServiceOrders = new HashSet<ServiceServiceOrder>();
        }

        public Service(int id, string name, string description, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
