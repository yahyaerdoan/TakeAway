using Microsoft.AspNetCore.Mvc;
using TakeAway.UserInterface.Services.Abstractions.Productservices;

namespace TakeAway.UserInterface.ViewComponents.LayoutViewComponents;

public class FruitsShopViewComponentPartial(IProductService productService) : ViewComponent
{
    private readonly IProductService _productService = productService;

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var values = await _productService.GetAllProductsAsync();
        return View(values);
    }
}