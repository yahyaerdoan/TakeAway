using Microsoft.AspNetCore.Mvc;

namespace TakeAway.UserInterface.Controllers.Layouts
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
