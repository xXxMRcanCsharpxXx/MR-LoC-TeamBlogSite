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
            new VideoGame() { Id = 5, Name = "COD: Warzone", Studio = "Acti-Blizz" },
            new VideoGame() { Id = 6, Name = "PUBG Moblie", Studio = "PUBG Studios/Krafton" }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review() { Id = 1, User = "John Doe", Comment = "Fall guys is awesome",ReviewBody = "Just a fun game to mess with my friends. I loved just knocking them off the levels, every time I got the chance.. 'Bang' .", Rating = 8, VideoGameId = 1 },
                new Review() { Id = 2, User = "Jane Doe", Comment = "Bloodhunt is alright", ReviewBody = "Good idea with what they were going for. Love the gameplay and a new style to these types of game.", Rating = 6, VideoGameId = 2 },
                new Review() { Id = 3, User = "Jonnathan Doe", Comment = "Fortnite sucks", ReviewBody = "I would do lower but it was good to pump shotgun some noobs.", Rating = 3, VideoGameId = 3 },
                new Review() { Id = 4, User = "John Deer", Comment = "Apex Legends is decent", ReviewBody = "work the playtime, but too many lootboxes and pay-to-win mechanics.", Rating = 5, VideoGameId = 4 },
                new Review() { Id = 5, User = "Jack Doe", Comment = "Warzone is horrible", ReviewBody = "Warzone was a cashgrab that stole my money.", Rating = 1, VideoGameId = 5 },
                new Review() { Id = 6, User = "Jackline O'Connor", Comment = "PUBG Moblie is decent", ReviewBody = "PUBG Moblie is decent for this year's showcase", Rating = 9, VideoGameId = 6 }
                );
        }
    }
}
