using MongoDB.Bson;

namespace TakeAway.CatalogService.Entities;

public class Slider
{
    public ObjectId Id { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
}
