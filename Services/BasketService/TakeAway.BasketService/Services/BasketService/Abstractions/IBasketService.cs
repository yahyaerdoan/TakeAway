using TakeAway.BasketService.Dtos;

namespace TakeAway.BasketService.Services.BasketService.Abstractions;

public interface IBasketService
{
    Task<BasketTotalDto> GetBasket(string userId);
    Task SaveBasket(BasketTotalDto basket);
    Task DeleteBasket(string userId);
}
