using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TakeAway.SignalRService.Entities;
using TakeAway.SignalRService.Settings.DbContexts;

namespace TakeAway.SignalRService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveriesController(SignalRServiceDeliveryMsSqlDbContext dbContext) : ControllerBase
    {
        private readonly SignalRServiceDeliveryMsSqlDbContext dbContext = dbContext;

        [HttpPost]
        public async Task<IActionResult> Add(Delivery delivery)
        {
          dbContext.Deliveries.Add(delivery);
          await  dbContext.SaveChangesAsync();
           return Ok("created!");
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
          var values = await dbContext.Deliveries.ToListAsync();
           
            return Ok(values);
        }
    }
}
