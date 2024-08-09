namespace TakeAway.SignalRService.Entities;

public class Delivery
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Status { get; set; }
    public DateTime? Created { get; set; } = DateTime.Now;
    public string? City { get; set; }
    public string? Address { get; set; }
    public decimal TotalPrice { get; set; }
}
