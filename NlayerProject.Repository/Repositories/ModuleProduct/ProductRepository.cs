using Microsoft.EntityFrameworkCore;
using NlayerProject.Core.Models.ModuleProduct;
using NlayerProject.Core.Repositories.ModuleProduct;
using NlayerProject.Repository.Context;
using NlayerProject.Repository.Repositories.Common;

namespace NlayerProject.Repository.Repositories.ModuleProduct
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<List<Product>> GetProductsWitCategory()
        {
            return await _context.Products.Include(x => x.Category)
                .ToListAsync();
        }
    }
}
