using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAway.DiscountService.Dtos.CouponDto;
using TakeAway.DiscountService.Services.Abstractions;

namespace TakeAway.DiscountService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CouponsController(ICouponService couponService) : ControllerBase
{
    private readonly ICouponService couponService = couponService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var values = await couponService.GetAllCouponAsync();
        return Ok(values);
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateCouponDto createCouponDto)
    {
        await couponService.CreateCouponAsync(createCouponDto);
        return Ok("Coupon created.");
    }
    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        await couponService.DeleteCouponAsync(id);
        return Ok("Coupon deleted.");
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var values = await couponService.GetByIdCouponAsync(id);
        return Ok(values);
    }
    [HttpPut]
    public async Task<IActionResult> Update(UpdateCouponDto updateCouponDto)
    {
        await couponService.UpdateCouponAsync(updateCouponDto);
        return Ok("Poduct updated.");
    }
}
