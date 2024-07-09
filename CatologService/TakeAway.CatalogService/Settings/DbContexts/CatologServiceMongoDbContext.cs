using MongoDB.Driver;
using TakeAway.CatalogService.Entities;

namespace TakeAway.CatalogService.Settings.DbContexts;

public class CatologServiceMongoDbContext : ICatologServiceMongoDbContext
{
    private readonly IMongoDatabase _database;
    public CatologServiceMongoDbContext(CatologServiceMongoDbSettings settings)
    {
        var client = new MongoClient(settings.ConnectionString);
        _database = client.GetDatabase(settings.DatabaseName);
    }

    public IMongoCollection<Product> Products => _database.GetCollection<Product>("Products");

    public IMongoCollection<Category> Categories => _database.GetCollection<Category>("Categories");

    public IMongoCollection<Slider> Sliders => _database.GetCollection<Slider>("Sliders");

    public IMongoCollection<DailyDiscount> DailyDiscounts => _database.GetCollection<DailyDiscount>("DailyDiscounts");
}
