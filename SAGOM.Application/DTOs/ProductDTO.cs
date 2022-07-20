using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.DTOs 
{ 
    public class ProductDTO
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public int Quantity { get; private set; }
        public decimal? UnitPrice { get; private set; }        

    }

}
