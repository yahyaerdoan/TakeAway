using Microsoft.AspNetCore.Mvc;

namespace TakeAway.UserInterface.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
