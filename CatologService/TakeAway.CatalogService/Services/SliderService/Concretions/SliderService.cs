using AutoMapper;
using MongoDB.Driver;
using TakeAway.CatalogService.Dtos.SliderDto;
using TakeAway.CatalogService.Entities;
using TakeAway.CatalogService.Services.SliderService.Abstractions;
using TakeAway.CatalogService.Settings.DbContexts;

namespace TakeAway.CatalogService.Services.SliderService.Concretions;

public class SliderService(ICatologServiceMongoDbContext dbContext, IMapper mapper) : ISliderService
{
    private readonly ICatologServiceMongoDbContext dbContext = dbContext;
    private readonly IMapper mapper = mapper;

    public async Task CreateSliderAsync(CreateSliderDto createSliderDto)
    {
        //first map
        var values = mapper.Map<Slider>(createSliderDto);
        await dbContext.Sliders.InsertOneAsync(values);       
    }

    public Task DeleteSliderAsync(string id)
    {
        return dbContext.Sliders.DeleteOneAsync(x=> x.Id == id);
    }

    public async Task<List<ResultSliderDto>> GetAllSliderAsync()
    {
        var values = await dbContext.Sliders.Find(x=> true).ToListAsync();
        //second map
        return  mapper.Map<List<ResultSliderDto>>(values);
    }

    public async Task<GetByIdSliderDto> GetByIdSliderAsync(string id)
    {
        var values = await dbContext.Sliders.Find(x=> x.Id == id).FirstOrDefaultAsync();
        return mapper.Map<GetByIdSliderDto>(values);
    }

    public async Task UpdateSliderAsync(UpdateSliderDto updateSlider)
    {
        var values = mapper.Map<Slider>(updateSlider);
        await dbContext.Sliders.FindOneAndReplaceAsync(x=> x.Id == updateSlider.Id, values);
    }
}
