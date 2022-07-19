using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public decimal? UnitValue { get; set; }
        public  ICollection<ProductServiceOrder> ProductServiceOrders { get; set; }

        public Product()
        {
            ProductServiceOrders = new HashSet<ProductServiceOrder>();
        }


        public Product(int id, string name, string description, int quantity, decimal unitValue)
        {
            Id = id;
            Name = name;
            Description = description;
            Quantity = quantity;
            UnitValue = unitValue;
        }

        public decimal? GetTotal()
        {
            return UnitValue * Quantity;
        }

    }

}
