using SAGOM.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>?> GetProductsByName(string name);
        Task<ProductDTO> GetProductById(int idProduct);
        Task Add(ProductDTO product);
        Task Update(ProductDTO product);
        Task Remove(ProductDTO product);
    }
}