using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAway.CatalogService.Dtos.DailyDiscountDtos;
using TakeAway.CatalogService.Services.DailyDiscountService.Abstractions;

namespace TakeAway.CatalogService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DailyDiscountsController(IDailyDiscountService dailyDiscountService) : ControllerBase
{
    private readonly IDailyDiscountService dailyDiscountService = dailyDiscountService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var values = await dailyDiscountService.GetAllDailyDiscountAsync();
        return Ok(values);
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateDailyDiscountDto createDailyDiscountDto)
    {
        await dailyDiscountService.CreateDailyDiscountAsync(createDailyDiscountDto);
        return Ok("Daily discount created.");
    }
    [HttpDelete]
    public async Task<IActionResult> Delete(string id)
    {
        await dailyDiscountService.DeleteDailyDiscountAsync(id);
        return Ok("Daily discount deleted.");
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var values = await dailyDiscountService.GetByIdDailyDiscountAsync(id);
        return Ok(values);
    }
    [HttpPut]
    public async Task<IActionResult> Update(UpdateDailyDiscountDto updateDailyDiscountDto)
    {
        await dailyDiscountService.UpdateDailyDiscountAsync(updateDailyDiscountDto);
        return Ok("Daily discount updated.");
    }
}
