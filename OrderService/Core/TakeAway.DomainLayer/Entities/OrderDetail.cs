﻿namespace TakeAway.DomainLayer.Entities;

public class OrderDetail
{
    public int Id { get; set; }
    public string ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Amount { get; set; }
    public decimal TotalPrice { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }
}
