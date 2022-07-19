using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public int Quantity { get; private set; }
        public decimal? UnitPrice { get; private set; }
        public  ICollection<ProductServiceOrder> ProductServiceOrders { get; private set; }

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
