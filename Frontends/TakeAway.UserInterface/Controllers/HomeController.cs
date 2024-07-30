using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TakeAway.UserInterface.Models;

namespace TakeAway.UserInterface.Controllers;

public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
}
