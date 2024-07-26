using System.Text.Json;
using TakeAway.BasketService.Dtos;
using TakeAway.BasketService.Services.BasketService.Abstractions;
using TakeAway.BasketService.Settings.RedisSettings;

namespace TakeAway.BasketService.Services.BasketService.Concretions;

public class BasketService(RedisService redisService) : IBasketService
{
    private readonly RedisService redisService = redisService;

    public async Task DeleteBasket(string userId)
    {
        await redisService.GetDatabase().KeyDeleteAsync(userId);
    }

    public async Task<BasketTotalDto> GetBasket(string userId)
    {
       var basket  = await redisService.GetDatabase().StringGetAsync(userId);
        return JsonSerializer.Deserialize<BasketTotalDto>(basket);
    }

    public async Task SaveBasket(BasketTotalDto basket)
    {
        await redisService.GetDatabase().StringSetAsync(basket.UserId, JsonSerializer.Serialize(basket));
    }
}
