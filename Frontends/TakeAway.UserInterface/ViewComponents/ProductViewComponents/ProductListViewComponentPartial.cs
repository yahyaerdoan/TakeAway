using Microsoft.AspNetCore.Mvc;
using TakeAway.UserInterface.Services.Abstractions.Productservices;

namespace TakeAway.UserInterface.ViewComponents.ProductViewComponents
{
    public class ProductListViewComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public ProductListViewComponentPartial(IProductService productService)
        {
            _productService = productService;
        }
       
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.GetAllProductsAsync();
            return View(values);
        }
    }
}
