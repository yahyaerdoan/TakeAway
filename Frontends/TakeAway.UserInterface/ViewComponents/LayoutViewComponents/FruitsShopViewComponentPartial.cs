using Microsoft.AspNetCore.Mvc;

namespace TakeAway.UserInterface.ViewComponents.LayoutViewComponents;

public class FruitsShopViewComponentPartial : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}