using TakeAway.UserInterface.Models.CatalogServices.ProductViewModels;

namespace TakeAway.UserInterface.Services.Abstractions.Productservices;

public interface IProductService
{
    Task<List<ResultProductViewModel>> GetAllProductsAsync();
}
