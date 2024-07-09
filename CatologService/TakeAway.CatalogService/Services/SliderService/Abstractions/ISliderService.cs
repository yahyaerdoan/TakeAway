
using TakeAway.CatalogService.Dtos.SliderDto;

namespace TakeAway.CatalogService.Services.SliderService.Abstractions;

public interface ISliderService
{
    Task<List<ResultSliderDto>> GetAllSliderAsync();
    Task CreateSliderAsync(CreateSliderDto createSliderDto);
    Task UpdateSliderAsync(UpdateSliderDto updateSlider);
    Task DeleteSliderAsync(string id);
    Task<GetByIdSliderDto> GetByIdSliderAsync(string id);
}
