using MongoDB.Bson;

namespace TakeAway.CatalogService.Dtos.CategoryDtos;

public class UpdateCategoryDto
{
    public ObjectId Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

