using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using TakeAway.SignalRService.Settings.DbContexts;

namespace TakeAway.SignalRService.Hubs;

public class SignalRHub(SignalRServiceDeliveryMsSqlDbContext dbContext) : Hub
{
    private readonly SignalRServiceDeliveryMsSqlDbContext _dbContext = dbContext;

    public async Task SendStatistics()
    {
        var value1 = _dbContext.Deliveries.Where(x => x.Status == "OnTheWay").Count();
        await Clients.All.SendAsync("ReceiveStatusOnTheWayCount", value1);

        var value2 = _dbContext.Deliveries.Sum(x => x.TotalPrice);
        await Clients.All.SendAsync("ReceiveStatusTotalPrice", value2);

        var value3 = _dbContext.Deliveries.Count();
        await Clients.All.SendAsync("ReceiveStatusTotalDelivery", value3);
    }
}
