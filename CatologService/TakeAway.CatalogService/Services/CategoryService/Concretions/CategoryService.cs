using TakeAway.CatalogService.Dtos.CategoryDtos;
using TakeAway.CatalogService.Services.CategoryService.Abstractions;
using TakeAway.CatalogService.Settings.DbContexts;

namespace TakeAway.CatalogService.Services.CategoryService.Concretions;

public class CategoryService : ICategoryService
{
    private readonly ICatologServiceMongoDbContext _dbContext;

    public CategoryService(ICatologServiceMongoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

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
