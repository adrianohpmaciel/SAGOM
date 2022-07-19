using Microsoft.EntityFrameworkCore;
using SAGOM.Domain.Entities;
using SAGOM.Domain.Interfaces;
using SAGOM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        SagomDbContext _db;

        public ProductRepository(SagomDbContext context)
        {
            _db = context;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            _db.Add(product);
            await _db.SaveChangesAsync();
            return product;
        }

        public async Task<Product> GetProductByIdAsync(int idProduct)
        {
            return await _db.Products.FindAsync(idProduct);
        }

        public async Task<IEnumerable<Product>?> GetProductsByNameAsync(string name)
        {
            name = name.Trim().ToLower();
            return await _db.Products.Where(p => p.Name.ToLower()
                                                      .StartsWith(name)
                                                      ).ToListAsync();
        }

        public async Task<Product> RemoveAsync(Product product)
        {
            _db.Remove(product);
            await _db.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            _db.Update(product);
            await _db.SaveChangesAsync();
            return product;
        }
    }
}
