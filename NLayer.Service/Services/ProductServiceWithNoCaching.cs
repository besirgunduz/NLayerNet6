using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;

namespace NLayer.Service.Services
{
    public class ProductServiceWithNoCaching : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductServiceWithNoCaching(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<List<ProductsWithCategoryDto>>> GetProductsWithCategory()
        {
            var products = await _productRepository.GetProductsWithCategory();
            var productsWithCategory = _mapper.Map<List<ProductsWithCategoryDto>>(products);
            return CustomResponseDto<List<ProductsWithCategoryDto>>.Success(200, productsWithCategory);

        }
    }
}
