using Microsoft.AspNetCore.Mvc;

namespace TakeAway.UserInterface.ViewComponents.LayoutViewComponents;

public class HeadViewComponentPartial :  ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}
