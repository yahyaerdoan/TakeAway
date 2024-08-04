using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TakeAway.CatalogService.Dtos.DailyDiscountDtos;

public class UpdateDailyDiscountDto
{
    public string Id { get; set; }
    public string MainTitle { get; set; }
    public string SubTitle { get; set; }
    public string LongDescription { get; set; }
    public string Price { get; set; }
    public string ImageUrl { get; set; }
    public bool Status { get; set; }
}
