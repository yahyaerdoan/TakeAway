using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TakeAway.CatalogService.Entities;

public class Product
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Name { get; set; }
    public string MainDescription { get; set; }
    public string SubDescription { get; set; }
    public string Price { get; set; }
    public string ImageUrl { get; set; }
}
