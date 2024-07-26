namespace TakeAway.BasketService.LoginServices.Abstractions;

public class LogInService(IHttpContextAccessor contextAccessor) : ILogInService
{
    private  readonly IHttpContextAccessor _httpContextAccessor = contextAccessor;

    public string GetUserId => _httpContextAccessor.HttpContext.User.FindFirst("sub").Value;
}
