using Microsoft.EntityFrameworkCore;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site
{
    public class VideoGameContext : DbContext
    {
        public DbSet<VideoGame> VideoGame { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server = (localdb)\\mssqllocaldb; Database = VideoGameDB_2022; Trusted_Connection = True; ";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<VideoGame>().HasData(
            new VideoGame() { Id = 1, Name = "Fall Guys" },
            new VideoGame() { Id = 2, Name = "Bloodhunt" },
            new VideoGame() { Id = 3, Name = "Fortnite" },
            new VideoGame() { Id = 4, Name = "Apex Legends" },
            new VideoGame() { Id = 5, Name = "COD: Warzone" }
            );
        }
    }
}
