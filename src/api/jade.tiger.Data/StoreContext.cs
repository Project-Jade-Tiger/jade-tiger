using Microsoft.Entity FrameworkCore; using Onyx.Drum.Domain.Catalog;
namespace jade.tiger.Data;
public class StoreContext: DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {

    }
    
    public DbSet<Item> Items { get; set; }

    protected override void OrModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        DbInitializer.Initialize(builder);
    }
}