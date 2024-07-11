using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using TakeAway.CatalogService.Dtos.CategoryDtos;
using TakeAway.CatalogService.Services.CategoryService.Abstractions;
using TakeAway.CatalogService.Services.ProductService.Abstractions;

namespace TakeAway.CatalogService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController(ICategoryService categoryService, IProductService productService) : ControllerBase
{
    private readonly ICategoryService _categoryService = categoryService;
    private readonly IProductService _productService = productService;

    [HttpGet]
    public async Task<IActionResult> CategoryList()
    {
        var values = await _categoryService.GetAllCategoryAsync();
        return Ok(values);
    }
    [HttpPost]
    public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryDto createCategoryDto)
    {
        await _categoryService.CreateCategoryAsync(createCategoryDto);
        return Ok("Category created");
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCategory(string id)
    {
        var values = await _categoryService.GetByIdCategoryAsync(id);
        return Ok(values);
    }
    [HttpPut]
    public async Task<IActionResult> UpdateCategory([FromBody] UpdateCategoryDto updateCategoryDto) 
    {
        await _categoryService.UpdateCategoryAsync(updateCategoryDto);
        return Ok("Category updated.");
    }
    [HttpDelete]
    public async Task<IActionResult> DeleteCategory([FromQuery] string id)
    {
        await _categoryService.DeleteCategoryAsync(id);
        return Ok("Category deleted.");
    }
}
