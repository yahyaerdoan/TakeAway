using Microsoft.AspNetCore.Mvc;

namespace TakeAway.UserInterface.ViewComponents.LayoutViewComponents;

public class BannerSectionViewComponentPartial : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}
