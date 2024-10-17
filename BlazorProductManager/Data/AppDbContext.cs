using BlazorProductManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorProductManager.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
    }
}
