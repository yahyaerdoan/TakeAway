using TakeAway.CatalogService.Dtos.DailyDiscountDtos;

namespace TakeAway.CatalogService.Services.DailyDiscountService.Abstractions;

public interface IDailyDiscountService
{
    Task<List<ResultDailyDiscountDto>> GetAllDailyDiscountAsync();
    Task CreateDailyDiscountAsync(CreateDailyDiscountDto createDailyDiscountDto);
    Task UpdateDailyDiscountAsync(UpdateDailyDiscountDto updateDailyDiscount);
    Task DeleteDailyDiscountAsync(string id);
    Task<GetByIdDailyDiscountDto> GetByIdDailyDiscountAsync(string id);
}
