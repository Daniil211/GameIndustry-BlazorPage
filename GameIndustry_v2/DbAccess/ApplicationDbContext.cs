using Application.Persistence.DataSeeders;
using Application.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Persistence;

public interface IApplicationDbContext
{
    public DbSet<GameModel> GameModels { get; set; }

    public DbSet<GameDeveloper> GameDevelopers { get; set; }

    public DbSet<Genre> Genres { get; set; }

    public DbSet<User> Users { get; set; }
}

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<GameModel> GameModels { get; set; }

    public DbSet<GameDeveloper> GameDevelopers { get; set; }

    public DbSet<Genre> Genres { get; set; }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder = DataSeederUsers.SeedData(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();
    }
}