using NlayerProject.Core.DTOs.Common;
using NlayerProject.Core.DTOs.ModuleProduct;
using NlayerProject.Core.Models.ModuleProduct;
using NlayerProject.Core.Services.Common;

namespace NlayerProject.Core.Services.ModuleProduct
{
    public interface IProductService : IService<Product>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory();
    }
}
