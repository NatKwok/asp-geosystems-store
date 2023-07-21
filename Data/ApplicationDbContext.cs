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
    public DbSet<asp_geosystems_store.Models.Employee> Employee { get; set; }
    public DbSet<asp_geosystems_store.Models.Product> Product { get; set; }
    public DbSet<asp_geosystems_store.Models.Order> Order { get; set; }

}
