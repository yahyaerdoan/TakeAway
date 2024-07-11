using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAway.CatalogService.Dtos.ProductDto;
using TakeAway.CatalogService.Services.ProductService.Abstractions;

namespace TakeAway.CatalogService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(IProductService productService) : ControllerBase
{
    private readonly IProductService productService = productService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var values = await productService.GetAllProductAsync();
        return Ok(values);
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateProductDto createproductDto)
    {
        await productService.CreateProductAsync(createproductDto);
        return Ok("Product created.");
    }
    [HttpDelete]
    public async Task<IActionResult> Delete(string id)
    {
        await productService.DeleteProductAsync(id);
        return Ok("Product deleted.");
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var values = await productService.GetByIdProductAsync(id);
        return Ok(values);
    }
    [HttpPut]
    public async Task<IActionResult> Update(UpdateProductDto updateproductDto)
    {
        await productService.UpdateProductAsync(updateproductDto);
        return Ok("Poduct updated.");
    }
}
