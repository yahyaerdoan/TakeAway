using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TakeAway.DomainLayer.Entities;

namespace TakeAway.ApplicationLayer.Features.CQRS.Commands.OrderDetailCommands;

public class CreateOrderDetailCommand
{
    public string ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Amount { get; set; }
    public decimal TotalPrice { get; set; }
    public int OrderId { get; set; }  
}
