using NlayerProject.Core.DTOs.Common;
using NlayerProject.Core.DTOs.ModuleCategory;
using NlayerProject.Core.Models.ModuleCategory;
using NlayerProject.Core.Services.Common;

namespace NlayerProject.Core.Services.ModuleCategory
{
    public interface ICategoryService : IService<Category>
    {
        public Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId);

    }
}
