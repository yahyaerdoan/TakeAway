using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TakeAway.CatalogService.Entities;

public class Slider
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
}
