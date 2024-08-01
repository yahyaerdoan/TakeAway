using Newtonsoft.Json;
using TakeAway.UserInterface.Dtos.CatalogServices.ProductDtos;
using TakeAway.UserInterface.Services.Abstractions.Productservices;

namespace TakeAway.UserInterface.Services.Concretions.ProductServices;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<ResultProductDto>> GetAllProductsAsync()
    {
        var response = await _httpClient.GetAsync("https://localhost:6001/api/products");
        var jsonData = await response.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
        return values;
    }
}
