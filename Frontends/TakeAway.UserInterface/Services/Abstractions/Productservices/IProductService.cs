using TakeAway.UserInterface.Dtos.CatalogServices.ProductDtos;

namespace TakeAway.UserInterface.Services.Abstractions.Productservices;

public interface IProductService
{
    Task<List<ResultProductDto>> GetAllProductsAsync();
}
