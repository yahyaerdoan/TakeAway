using Microsoft.EntityFrameworkCore;
using TakeAway.DiscountService.Entities;

namespace TakeAway.DiscountService.Settings.DbContexts;

public class DiscountServiceMsSqlDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=YAHYAERDOGAN; Database=TakeAwayDiscountServiceDb; Trusted_Connection=true; TrustServerCertificate=True;");
    }
    public DbSet<Coupon> Coupons { get; set; }
}
