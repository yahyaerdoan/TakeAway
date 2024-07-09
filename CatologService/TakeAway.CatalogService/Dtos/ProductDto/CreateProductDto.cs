namespace TakeAway.CatalogService.Dtos.ProductDto;

public class CreateProductDto
{
    public string Name { get; set; }
    public string MainDescription { get; set; }
    public string SubDescription { get; set; }
    public string Price { get; set; }
    public string ImageUrl { get; set; }
}

