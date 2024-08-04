using Newtonsoft.Json;
using TakeAway.UserInterface.Models.CatalogServices.ProductViewModels;
using TakeAway.UserInterface.Services.Abstractions.Productservices;

namespace TakeAway.UserInterface.Services.Concretions.ProductServices;

public class ProductService(HttpClient httpClient) : IProductService
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<List<ResultProductViewModel>> GetAllProductsAsync()
    {
        var response = await _httpClient.GetAsync("https://localhost:6001/api/products");
        var jsonData = await response.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<ResultProductViewModel>>(jsonData);
        return values;
    }
}
