using NlayerProject.Core.DTOs.Common;

namespace NlayerProject.Core.DTOs.ModuleProduct
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
