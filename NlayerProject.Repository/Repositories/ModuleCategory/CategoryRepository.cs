using Microsoft.EntityFrameworkCore;
using NlayerProject.Core.Models.ModuleCategory;
using NlayerProject.Core.Repositories.ModuleCategory;
using NlayerProject.Repository.Context;
using NlayerProject.Repository.Repositories.Common;

namespace NlayerProject.Repository.Repositories.ModuleCategory
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId)
        {
            return await _context.Categories.Include(x => x.Products)
                .Where(x => x.Id == categoryId)
                .SingleOrDefaultAsync();
        }
    }
}
