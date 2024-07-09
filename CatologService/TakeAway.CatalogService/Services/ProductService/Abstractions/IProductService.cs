using TakeAway.CatalogService.Dtos.ProductDto;

namespace TakeAway.CatalogService.Services.ProductService.Abstractions;

public interface IProductService
{
    Task<List<ResultProductDto>> GetAllProductAsync();
    Task CreateProductAsync(CreateProductDto createProductDto);
    Task UpdateProductAsync(UpdateProductDto updateProduct);
    Task DeleteProductAsync(string id);
    Task<GetByIdProductDto> GetByIdProductAsync(string id);
}
