using MongoDB.Driver;
using TakeAway.CatalogService.Entities;

namespace TakeAway.CatalogService.Settings.DbContexts;

public interface ICatologServiceMongoDbContext
{
    IMongoCollection<Product> Products { get; }
    IMongoCollection<Category> Categories { get; }
    IMongoCollection<Slider> Sliders { get; }
    IMongoCollection<DailyDiscount> DailyDiscounts { get; }
}
