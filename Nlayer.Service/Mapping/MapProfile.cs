using AutoMapper;
using Nlayer.Core.Dtos.CategoryDtos;
using Nlayer.Core.Dtos.ProductDtos;
using Nlayer.Core.Dtos.ProductFeatureDtos;
using Nlayer.Core.Models.Entities;

namespace Nlayer.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product,ProductDto>().ReverseMap();
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<ProductFeature,ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product, ProductsWithCategoryDto>();
        }
    }
}
