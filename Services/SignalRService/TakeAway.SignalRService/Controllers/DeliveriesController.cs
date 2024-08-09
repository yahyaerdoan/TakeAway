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
        [HttpGet("GetDeliveryByStatusIsOnTheWay")]
        public IActionResult GetDeliveryByStatusIsOnTheWay()
        {
            int value = dbContext.Deliveries.Where(x => x.Status == "OnTheWay").Count();
            return Ok(value);
        }
        [HttpGet("GetDeliveryByStatusIsOrderReceived")]
        public IActionResult GetDeliveryByStatusIsOrderReceived()
        {
            int value = dbContext.Deliveries.Where(x => x.Status == "OrderReceived").Count();
            return Ok(value);
        }
        [HttpGet("GetDeliveryByStatusIsPreparing")]
        public IActionResult GetDeliveryByStatusIsPreparing()
        {
            int value = dbContext.Deliveries.Where(x => x.Status == "Preparing").Count();
            return Ok(value);
        }
        [HttpGet("GetDeliveryByStatusIsDelivered")]
        public IActionResult GetDeliveryByStatusIsDelivered()
        {
            int value = dbContext.Deliveries.Where(x => x.Status == "Delivered").Count();
            return Ok(value);
        }
        [HttpGet("GetTotalPrice")]
        public IActionResult GetTotalPrice()
        {
            decimal value = dbContext.Deliveries.Sum(x => x.TotalPrice);
            return Ok(value);
        }
        [HttpGet("GetTotalDelivery")]
        public IActionResult GetTotalDelivery()
        {
            int value = dbContext.Deliveries.Count();
            return Ok(value);
        }
    }
}
