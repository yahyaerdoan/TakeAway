using Microsoft.AspNetCore.Mvc;
using TakeAway.UserInterface.Models.IdentityServices.IdentityViewModels;
using TakeAway.UserInterface.Services.Abstractions.IdentityServices;

namespace TakeAway.UserInterface.Controllers.Entrances;

public class LogInController(IIdentityService identityService) : Controller
{
    private readonly IIdentityService _identityService = identityService;

  
    public async Task<IActionResult> Index()
    {
        //var logInViewModel = new LogInViewModel
        //{
        //    UserName = "YahyaErdogan",
        //    Password = "123456Aa*",
        //};
        //var isSuccess = await _identityService.LogIn(logInViewModel);
        //if (isSuccess)        
        //    return RedirectToAction("Index", "Home");
        //else
        //    ModelState.AddModelError("", "Login failed. Please check your credentials and try again.");
        return View();
    }
}
