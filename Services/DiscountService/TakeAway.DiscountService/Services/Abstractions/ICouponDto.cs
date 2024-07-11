using TakeAway.DiscountService.Dtos.CouponDto;

namespace TakeAway.DiscountService.Services.Abstractions;

public interface ICouponService
{
    Task CreateCouponAsync(CreateCouponDto createCouponDto);
    Task UpdateCouponAsync(UpdateCouponDto updateCouponDto);
    Task<List<ResultCouponDto>> GetAllCouponAsync();   
    Task DeleteCouponAsync(int id);
    Task<GetByIdCouponDto> GetByIdCouponAsync(int id);
}
