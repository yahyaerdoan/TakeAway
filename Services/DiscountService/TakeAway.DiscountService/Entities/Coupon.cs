﻿namespace TakeAway.DiscountService.Entities;

public class Coupon
{
    public int Id { get; set; }
    public string Code { get; set; }
    public int Rate { get; set; }
    public bool IsActive { get; set; }
}