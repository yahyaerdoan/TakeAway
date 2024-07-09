using MongoDB.Bson;

namespace TakeAway.CatalogService.Entities;

public class Category
{
    public ObjectId Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
