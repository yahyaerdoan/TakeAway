namespace TakeAway.DiscountService.Dtos.CouponDto;

public class GetByIdCouponDto
{
    public int Id { get; set; }
    public string Code { get; set; }
    public int Rate { get; set; }
    public bool IsActive { get; set; }
}
