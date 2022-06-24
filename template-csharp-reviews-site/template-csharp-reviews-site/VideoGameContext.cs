using Microsoft.EntityFrameworkCore;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site
{
    public class VideoGameContext : DbContext
    {
        public DbSet<VideoGame> VideoGames { get; set; }

        public DbSet<Review> Reviews { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server = (localdb)\\mssqllocaldb; Database = VideoGameDB_2022; Trusted_Connection = True; ";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<VideoGame>().HasData(
            new VideoGame() { Id = 1, Name = "Fall Guys", Studio = "Mediatonic" },
            new VideoGame() { Id = 2, Name = "Bloodhunt", Studio = "Sharkmob" },
            new VideoGame() { Id = 3, Name = "Fortnite", Studio = "Epic Games" },
            new VideoGame() { Id = 4, Name = "Apex Legends", Studio = "Respawn" },
            new VideoGame() { Id = 5, Name = "COD: Warzone", Studio = "Acti-Blizz" }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review() { Id = 1, User = "John Doe", Comment = "Fall guys is awesome", Rating = 8, VideoGameId = 1 },
                new Review() { Id = 2, User = "Jane Doe", Comment = "Bloodhunt is alright", Rating = 6, VideoGameId = 2 },
                new Review() { Id = 3, User = "Jonnathan Doe", Comment = "Fortnite sucks", Rating = 3, VideoGameId = 3 },
                new Review() { Id = 4, User = "John Deer", Comment = "Apex Legends is decent", Rating = 5, VideoGameId = 4 },
                new Review() { Id = 5, User = "Jack Doe", Comment = "Warzone is horrible", Rating = 1, VideoGameId = 5 }
                );
        }
    }
}
