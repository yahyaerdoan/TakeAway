using AutoMapper;
using TakeAway.CatalogService.Dtos.CategoryDtos;
using TakeAway.CatalogService.Dtos.DailyDiscountDtos;
using TakeAway.CatalogService.Dtos.ProductDto;
using TakeAway.CatalogService.Dtos.SliderDto;
using TakeAway.CatalogService.Entities;

namespace TakeAway.CatalogService.Mappings;

public class GeneralMapping : Profile
{
    public GeneralMapping()
    {
        CreateMap<Product, CreateProductDto>().ReverseMap();
        CreateMap<Product, GetByIdProductDto>().ReverseMap();
        CreateMap<Product, UpdateProductDto>().ReverseMap();
        CreateMap<Product, ResultProductDto>().ReverseMap();

        CreateMap<Category, CreateProductDto>().ReverseMap();
        CreateMap<Category, GetByIdCategoryDto>().ReverseMap();
        CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        CreateMap<Category, ResultCategoryDto>().ReverseMap();


        CreateMap<Slider, CreateSliderDto>().ReverseMap();
        CreateMap<Slider, GetByIdSliderDto>().ReverseMap();
        CreateMap<Slider, UpdateSliderDto>().ReverseMap();
        CreateMap<Slider, ResultSliderDto>().ReverseMap();


        CreateMap<DailyDiscount, CreateDailyDiscountDto>().ReverseMap();
        CreateMap<DailyDiscount, GetByIdDailyDiscountDto>().ReverseMap();
        CreateMap<DailyDiscount, UpdateDailyDiscountDto>().ReverseMap();
        CreateMap<DailyDiscount, ResultDailyDiscountDto>().ReverseMap();     
    }
}
