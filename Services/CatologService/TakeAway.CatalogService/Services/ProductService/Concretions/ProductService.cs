using AutoMapper;
using MongoDB.Driver;
using TakeAway.CatalogService.Dtos.ProductDto;
using TakeAway.CatalogService.Entities;
using TakeAway.CatalogService.Services.ProductService.Abstractions;
using TakeAway.CatalogService.Settings.DbContexts;

namespace TakeAway.CatalogService.Services.ProductService.Concretions;

public class ProductService(ICatologServiceMongoDbContext dbContext, IMapper mapper) : IProductService
{
    private readonly ICatologServiceMongoDbContext dbContext = dbContext;
    private readonly IMapper mapper = mapper;

    public async Task CreateProductAsync(CreateProductDto createProductDto)
    {
        var values = mapper.Map<Product>(createProductDto);
        await dbContext.Products.InsertOneAsync(values);
    }

    public async Task DeleteProductAsync(string id)
    {
        await dbContext.Products.DeleteOneAsync(x=> x.Id == id);
    }

    public async Task<List<ResultProductDto>> GetAllProductAsync()
    {
      var values = await dbContext.Products.Find(x=> true).ToListAsync();
       return mapper.Map<List<ResultProductDto>>(values);
    }

    public async Task<GetByIdProductDto> GetByIdProductAsync(string id)
    {
        var values = await dbContext.Products.Find(x=> x.Id == id).FirstOrDefaultAsync();
        return mapper.Map<GetByIdProductDto>(values);
    }

    public async Task UpdateProductAsync(UpdateProductDto updateProduct)
    {
       var values = mapper.Map<Product>(updateProduct);
        await dbContext.Products.FindOneAndReplaceAsync(x=> x.Id == updateProduct.Id, values);
    }
}
