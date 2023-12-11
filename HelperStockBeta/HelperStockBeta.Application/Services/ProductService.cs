using AutoMapper;
using HelperStockBeta.Application.DTOs;
using HelperStockBeta.Application.Interfaces;
using HelperStockBeta.Domain.Entities;
using HelperStockBeta.Domain.Interface;

namespace HelperStockBeta.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productsEntity = await _productRepository.GetProductsAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(productsEntity);
        }

        public async Task<IEnumerable<ProductDTO>> GetProductByCategory(int idCategory)
        {
            var productsEntity = await _productRepository.GetProductCategoryAsync(idCategory);
            return _mapper.Map<IEnumerable<ProductDTO>>(productsEntity);
        }

        public async Task<ProductDTO> GetProductById(int? id)
        {
            var productEntity = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductDTO>(productEntity);
        }

        public async Task Add(ProductDTO productDTO)
        {
            var productEntiy = _mapper.Map<Product>(productDTO);
            await _productRepository.CreateAsync(productEntiy);
        }

        public async Task Update(ProductDTO productDTO)
        {
            var productEntity = _mapper.Map<Product>(productDTO);
            await _productRepository.UpdateAsync(productEntity);
        }

        public async Task Remove(int? id)
        {
            var productEntity = _productRepository.GetByIdAsync(id).Result;
            await _productRepository.RemoveAsync(productEntity);
        }
    }
}
