using MongoDB.Bson;

namespace TakeAway.CatalogService.Entities;

public class Product
{
    public ObjectId Id { get; set; }
    public string Name { get; set; }
    public string MainDescription { get; set; }
    public string SubDescription { get; set; }
    public string Price { get; set; }
    public string ImageUrl { get; set; }
}
