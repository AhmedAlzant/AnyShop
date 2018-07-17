using Any_Shop.Models;
using Microsoft.EntityFrameworkCore;

namespace Any_Shop.Presistance
{
    public class ShopDbContext:DbContext
    {
       public ShopDbContext(DbContextOptions<ShopDbContext> options)
       :base(options){
        }
                public DbSet<Make> Makes { get; set; }
                public DbSet<Model>Model { get; set; }

    }
}