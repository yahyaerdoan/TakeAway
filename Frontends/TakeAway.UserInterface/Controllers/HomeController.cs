using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TakeAway.UserInterface.Models;
using TakeAway.UserInterface.Services.Abstractions.Productservices;

namespace TakeAway.UserInterface.Controllers;

public class HomeController : Controller
{
    private readonly IProductService _productService;

    public HomeController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task< IActionResult> Index()
    {
        var values = await _productService.GetAllProductsAsync();
        return View(values);
    }
}
