using Microsoft.EntityFrameworkCore;
using TakeAway.SignalRService.Entities;

namespace TakeAway.SignalRService.Settings.DbContexts;

public class SignalRServiceDeliveryMsSqlDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=YAHYAERDOGAN; Database=SignalRServiceDeliveryDb; Trusted_Connection=true; TrustServerCertificate=True;");
    }
    public DbSet<Delivery> Deliveries { get; set; }
}
