using AutoMapper;
using NlayerProject.Core.DTOs.Common;
using NlayerProject.Core.DTOs.ModuleProduct;
using NlayerProject.Core.Models.ModuleProduct;
using NlayerProject.Core.Repositories.Common;
using NlayerProject.Core.Repositories.ModuleProduct;
using NlayerProject.Core.Services.ModuleProduct;
using NlayerProject.Core.UnitOfWorks;
using NlayerProject.Service.Services.Common;

namespace NlayerProject.Service.Services.ModuleProduct
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IMapper mapper, IProductRepository productRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory()
        {
            var products = await _productRepository
                .GetProductsWitCategory();

            var productsDto = _mapper.Map<List<ProductWithCategoryDto>>(products);
            return CustomResponseDto<List<ProductWithCategoryDto>>.Success(200, productsDto);

        }
    }
}
