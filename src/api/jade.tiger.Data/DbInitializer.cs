using Microsoft.Entity.FrameworkCore;
using Jade.Tiger.Domain.Catalog;

namespace Jade.Tiger;

public static class DbInitializer
{
    public static void Initialize(ModelBuilder builder)
    {
        builder.Entity<Item>().HasData(
            new Item("Item 1", "Description 1", "Brand 1", 100.00m) { Id = 1},
            new Item("Item 2", "Description 2", "Brand 2", 200.00m) { Id = 2},
            new Item("Item 3", "Description 3", "Brand 3", 300.00m) { Id = 3},
            new Item("Item 4", "Description 4", "Brand 4", 400.00m) { Id = 4}
        );
    }
}