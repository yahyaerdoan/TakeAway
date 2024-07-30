using Microsoft.EntityFrameworkCore;
using TakeAway.CommentService.DataAccessLayer.Entities;

namespace TakeAway.CommentService.DataAccessLayer.Settings.Context
{
    public class CommentContext(DbContextOptions<CommentContext> dbContextOptions) : DbContext(dbContextOptions)
    {
        public DbSet<Comment> Comments { get; set; }
    }
}
