using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TakeAway.SignalRUserInterface.Models;

namespace TakeAway.SignalRUserInterface.Controllers
{
    public class HomeController(IHttpClientFactory httpClientFactory) : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory = httpClientFactory;

        public async Task<IActionResult> Index()
        {
            var client1 = _httpClientFactory.CreateClient();
            var responsemessage1 = await client1.GetAsync("https://localhost:7189/api/Deliveries/GetTotalPrice");
            var jsonData1 = await responsemessage1.Content.ReadAsStringAsync();
            ViewBag.Message1 = jsonData1;

            var client2 = _httpClientFactory.CreateClient();
            var responsemessage2 = await client2.GetAsync("https://localhost:7189/api/Deliveries/GetTotalDelivery");
            var jsonData2 = await responsemessage2.Content.ReadAsStringAsync();
            ViewBag.Message2 = jsonData2;
            return View();
        }
    }
}
