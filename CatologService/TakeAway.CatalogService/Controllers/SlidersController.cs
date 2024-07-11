using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAway.CatalogService.Dtos.SliderDto;
using TakeAway.CatalogService.Services.SliderService.Abstractions;

namespace TakeAway.CatalogService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SlidersController(ISliderService sliderService) : ControllerBase
{
    private readonly ISliderService sliderService = sliderService;


    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var values = await sliderService.GetAllSliderAsync();
        return Ok(values);
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateSliderDto createSliderDto)
    {
        await sliderService.CreateSliderAsync(createSliderDto);
        return Ok("Slider created.");
    }
    [HttpDelete]
    public async Task<IActionResult> Delete(string id)
    {
        await sliderService.DeleteSliderAsync(id);
        return Ok("Slider deleted.");
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var values = await sliderService.GetByIdSliderAsync(id);
        return Ok(values);
    }
    [HttpPut]
    public async Task<IActionResult> Update(UpdateSliderDto updateSliderDto)
    {
        await sliderService.UpdateSliderAsync(updateSliderDto);
        return Ok("Slider updated.");
    }
}
