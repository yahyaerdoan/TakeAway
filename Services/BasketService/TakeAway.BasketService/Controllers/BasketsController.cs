using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAway.BasketService.Dtos;
using TakeAway.BasketService.LoginServices.Abstractions;
using TakeAway.BasketService.Services.BasketService.Abstractions;

namespace TakeAway.BasketService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController(IBasketService basketService, ILogInService logInService) : ControllerBase
    {
        private readonly IBasketService _basketService = basketService;
        private readonly ILogInService _logInService = logInService;

        [HttpGet]
        public async Task<IActionResult> GetMyBasketDetail()
        {
            var values = await _basketService.GetBasket(_logInService.GetUserId);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> SaveMyBasket(BasketTotalDto basketTotalDto)
        {
            basketTotalDto.UserId = _logInService.GetUserId;
            await _basketService.SaveBasket(basketTotalDto);
            return Ok("Saved.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMyBasket()
        {
            await _basketService.DeleteBasket(_logInService.GetUserId);
            return Ok("Deleted.");
        }
    }
}
