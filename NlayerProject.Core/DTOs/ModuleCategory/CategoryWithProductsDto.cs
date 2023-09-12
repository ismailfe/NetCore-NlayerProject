using NlayerProject.Core.DTOs.ModuleProduct;

namespace NlayerProject.Core.DTOs.ModuleCategory
{
    public class CategoryWithProductsDto : CategoryDto
    {
        public List<ProductDto> Products { get; set; }
    }
}
