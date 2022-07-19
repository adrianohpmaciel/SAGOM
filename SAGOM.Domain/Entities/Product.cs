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
        public decimal? UnitPrice { get; set; }
        public  ICollection<ProductServiceOrder> ProductServiceOrders { get; set; }

        public Product()
        {
            ProductServiceOrders = new HashSet<ProductServiceOrder>();
        }


        public Product(int id, string name, string description, int quantity, decimal unitPrice)
        {
            ProductServiceOrders = new HashSet<ProductServiceOrder>();
            Id = id;
            Name = name;
            Description = description;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public decimal? GetTotal()
        {
            return UnitPrice * Quantity;
        }

    }

}
