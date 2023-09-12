using AutoMapper;
using NlayerProject.Core.DTOs.ModuleCategory;
using NlayerProject.Core.DTOs.ModuleProduct;
using NlayerProject.Core.Models.ModuleCategory;
using NlayerProject.Core.Models.ModuleProduct;

namespace NlayerProject.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product,          ProductDto>().ReverseMap();
            CreateMap<Category,         CategoryDto>().ReverseMap();
            CreateMap<ProductFeature,   ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product,          ProductWithCategoryDto>();
            CreateMap<Category,         CategoryWithProductsDto>();
        }
    }
}
