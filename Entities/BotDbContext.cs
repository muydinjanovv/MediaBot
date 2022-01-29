using Microsoft.EntityFrameworkCore;

namespace MediaBot.Entities;

public class BotDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public BotDbContext(DbContextOptions<BotDbContext> options):base(options) {}

}