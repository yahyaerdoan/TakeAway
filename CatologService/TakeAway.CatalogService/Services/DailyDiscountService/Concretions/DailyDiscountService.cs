using AutoMapper;
using MongoDB.Bson;
using MongoDB.Driver;
using TakeAway.CatalogService.Dtos.DailyDiscountDtos;
using TakeAway.CatalogService.Entities;
using TakeAway.CatalogService.Services.DailyDiscountService.Abstractions;
using TakeAway.CatalogService.Settings.DbContexts;

namespace TakeAway.CatalogService.Services.DailyDiscountService.Concretions;

public class DailyDiscountService : IDailyDiscountService
{
    private readonly ICatologServiceMongoDbContext _dbContext;
    private readonly IMapper _mapper;

    public DailyDiscountService(ICatologServiceMongoDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task CreateDailyDiscountAsync(CreateDailyDiscountDto createDailyDiscountDto)
    {
        var values = _mapper.Map<DailyDiscount>(createDailyDiscountDto);
        await _dbContext.DailyDiscounts.InsertOneAsync(values);
    }

    public async Task DeleteDailyDiscountAsync(string id)
    {
        await _dbContext.DailyDiscounts.DeleteOneAsync(x=> x.Id == id);
    }

    public async Task<List<ResultDailyDiscountDto>> GetAllDailyDiscountAsync()
    {
       var values = await _dbContext.DailyDiscounts.Find(x=> true).ToListAsync();
        return _mapper.Map<List<ResultDailyDiscountDto>>(values);
    }

    public async Task<GetByIdDailyDiscountDto> GetByIdDailyDiscountAsync(string id)
    {
        var values = await _dbContext.DailyDiscounts.Find(x=> x.Id == id).FirstOrDefaultAsync();
        return _mapper.Map<GetByIdDailyDiscountDto>(values);
    }

    public async Task UpdateDailyDiscountAsync(UpdateDailyDiscountDto updateDailyDiscount)
    {
        var values = _mapper.Map<DailyDiscount>(updateDailyDiscount);
        await _dbContext.DailyDiscounts.FindOneAndReplaceAsync(x => x.Id == updateDailyDiscount.Id, values);
    }
}
