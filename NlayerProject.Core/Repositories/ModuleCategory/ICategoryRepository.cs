using NlayerProject.Core.Models.ModuleCategory;
using NlayerProject.Core.Repositories.Common;

namespace NlayerProject.Core.Repositories.ModuleCategory
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {

        Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}
