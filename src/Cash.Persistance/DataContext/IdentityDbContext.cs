using Cash.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Cash.Persistance.DataContext;
public class IdentityDbContext(DbContextOptions<IdentityDbContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        var test = modelBuilder.Model.GetEntityTypes();

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IdentityDbContext).Assembly);
    }
}
