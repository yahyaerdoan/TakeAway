namespace TakeAway.DomainLayer.Entities;

public class Order
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime OrderDate { get; set; }
    public List<OrderDetail> OrderDetails { get; set; }
}
