using Microsoft.EntityFrameworkCore;

namespace Database.Entities;

public class ProductStoreContext : DbContext
{
    public ProductStoreContext(DbContextOptions<ProductStoreContext> options)
        :base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Product> Products { get; set; }
}
