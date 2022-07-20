using AutoMapper;
using SAGOM.Application.DTOs;
using SAGOM.Application.Interfaces;
using SAGOM.Domain.Entities;
using SAGOM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>?> GetProductsByName(string name)
        {
            var productsEntities = await _productRepository.GetProductsByNameAsync(name);
            return _mapper.Map<IEnumerable<ProductDTO>>(productsEntities);
        }

        public async Task<ProductDTO?> GetProductById(int id)
        {
            var productEntity = await _productRepository.GetProductByIdAsync(id);
            return _mapper.Map<ProductDTO>(productEntity);
        }

        public async Task Add(ProductDTO product)
        {
            var productEntity = _mapper.Map<Product>(product);
            await _productRepository.CreateAsync(productEntity);
        }

        public async Task Update(ProductDTO product)
        {
            var productEntity = _mapper.Map<Product>(product);
            await _productRepository.UpdateAsync(productEntity);
        }

        public async Task Remove(ProductDTO product)
        {
            var productEntity = _mapper.Map<Product>(product);
            await _productRepository.RemoveAsync(productEntity);
        }
    }
}
