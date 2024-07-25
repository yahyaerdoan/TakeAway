﻿namespace TakeAway.BasketService.Dtos;

public class BasketTotalDto
{
    public string UserId { get; set; }
    public List<BasketItemDto> BasketItemDtos { get; set; }
    public decimal TotalPrice => BasketItemDtos.Sum(x => x.Quantity * x.Price);
}