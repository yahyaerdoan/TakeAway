using TakeAway.UserInterface.Models.IdentityServices.IdentityViewModels;

namespace TakeAway.UserInterface.Services.Abstractions.IdentityServices;

public interface IIdentityService
{
    Task<bool> LogIn(LogInViewModel logInViewModel);
}
