using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using asp_geosystems_store.Models;

namespace asp_geosystems_store.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<asp_geosystems_store.Models.Employee> Employees { get; set; }
    public DbSet<asp_geosystems_store.Models.Product> Products { get; set; }
    public DbSet<asp_geosystems_store.Models.Order> Orders { get; set; }
    public DbSet<asp_geosystems_store.Models.OrderItem> OrderItems { get; set; }

}
