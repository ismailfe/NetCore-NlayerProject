using NlayerProject.Core.DTOs.ModuleCategory;

namespace NlayerProject.Core.DTOs.ModuleProduct
{
    public class ProductWithCategoryDto : ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}
