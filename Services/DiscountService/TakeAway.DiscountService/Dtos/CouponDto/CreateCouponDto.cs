namespace TakeAway.DiscountService.Dtos.CouponDto;

public class CreateCouponDto
{
    public string Code { get; set; }
    public int Rate { get; set; }
    public bool IsActive { get; set; }
}
