using NlayerProject.Core.Models.ModuleProduct;
using NlayerProject.Core.Repositories.Common;

namespace NlayerProject.Core.Repositories.ModuleProduct
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetProductsWitCategory();

    }
}
