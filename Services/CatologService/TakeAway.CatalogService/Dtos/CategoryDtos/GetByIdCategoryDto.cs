using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TakeAway.CatalogService.Dtos.CategoryDtos;

public class GetByIdCategoryDto
{   
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

