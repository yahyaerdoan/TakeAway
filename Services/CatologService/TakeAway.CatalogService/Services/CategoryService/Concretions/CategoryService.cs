using AutoMapper;
using MongoDB.Bson;
using MongoDB.Driver;
using TakeAway.CatalogService.Dtos.CategoryDtos;
using TakeAway.CatalogService.Entities;
using TakeAway.CatalogService.Services.CategoryService.Abstractions;
using TakeAway.CatalogService.Settings.DbContexts;

namespace TakeAway.CatalogService.Services.CategoryService.Concretions;

public class CategoryService : ICategoryService
{
    private readonly ICatologServiceMongoDbContext _dbContext;
    private readonly IMapper _mapper;

    public CategoryService(ICatologServiceMongoDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
    {
        var values = _mapper.Map<Category>(createCategoryDto);
        await _dbContext.Categories.InsertOneAsync(values);
    }

    public async Task DeleteCategoryAsync(string id)
    {
        await _dbContext.Categories.DeleteOneAsync(x => x.Id == id);
    }

    public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
    {
        var values = await _dbContext.Categories.Find(x=> true).ToListAsync();
        return _mapper.Map<List<ResultCategoryDto>>(values);
    }

    public async Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id)
    {
        var values = await _dbContext.Categories.Find(x=> x.Id == id).FirstOrDefaultAsync();
        return _mapper.Map<GetByIdCategoryDto>(values);
    }

    public async Task UpdateCategoryAsync(UpdateCategoryDto updateCategory)
    {
        var values = _mapper.Map<Category>(updateCategory);
        await _dbContext.Categories.FindOneAndReplaceAsync(x => x.Id == updateCategory.Id, values);
    }
}
