namespace TakeAway.ApplicationLayer.Features.Mediator.Results.OrderResults;

public class GetOrderQueryResult
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime OrderDate { get; set; }
}
