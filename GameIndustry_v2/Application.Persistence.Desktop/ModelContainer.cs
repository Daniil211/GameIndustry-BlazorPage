using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Application.Persistence.Desktop.Models
{
    public partial class ModelContainer : DbContext
    {
        public ModelContainer()
            : base("name=ModelContainer")
        {
        }

        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<GameDevelopers> GameDevelopers { get; set; }
        public virtual DbSet<GameModels> GameModels { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameDevelopers>()
                .HasMany(e => e.GameModels)
                .WithOptional(e => e.GameDevelopers)
                .HasForeignKey(e => e.DeveloperId);

            modelBuilder.Entity<GameModels>()
                .HasMany(e => e.Genres)
                .WithMany(e => e.GameModels)
                .Map(m => m.ToTable("GameModelGenre").MapLeftKey("GamesId").MapRightKey("GenresId"));
        }
    }
}
