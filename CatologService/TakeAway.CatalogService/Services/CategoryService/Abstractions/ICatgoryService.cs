using TakeAway.CatalogService.Dtos.CategoryDtos;

namespace TakeAway.CatalogService.Services.CategoryService.Abstractions;

public interface ICatgoryService
{
    Task<List<ResultCategoryDto>> GetAllCategoryAsync();
    Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
    Task UpdateCategoryAsync(UpdateCategoryDto updateCategory);
    Task DeleteCategoryAsync(string id);
    Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id);
}
