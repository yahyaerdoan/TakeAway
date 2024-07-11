using AutoMapper;
using TakeAway.DiscountService.Dtos.CouponDto;
using TakeAway.DiscountService.Entities;

namespace TakeAway.DiscountService.Mappings;

public class GeneralMapping :  Profile
{
    public GeneralMapping()
    {
        CreateMap<Coupon, CreateCouponDto>().ReverseMap();
        CreateMap<Coupon, UpdateCouponDto>().ReverseMap();
        CreateMap<Coupon, GetByIdCouponDto>().ReverseMap();
        CreateMap<Coupon, ResultCouponDto>().ReverseMap();
    }
}
