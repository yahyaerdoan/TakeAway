using Microsoft.AspNetCore.Mvc;

namespace TakeAway.UserInterface.ViewComponents.LayoutViewComponents;

public class FeatursSectionViewComponentPartial : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}