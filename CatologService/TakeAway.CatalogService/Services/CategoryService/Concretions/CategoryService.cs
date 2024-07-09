using TakeAway.CatalogService.Dtos.CategoryDtos;
using TakeAway.CatalogService.Services.CategoryService.Abstractions;

namespace TakeAway.CatalogService.Services.CategoryService.Concretions;

public class CategoryService : ICategoryService
{
    public Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteCategoryAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ResultCategoryDto>> GetAllCategoryAsync()
    {
        throw new NotImplementedException();
    }

    public Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateCategoryAsync(UpdateCategoryDto updateCategory)
    {
        throw new NotImplementedException();
    }
}
