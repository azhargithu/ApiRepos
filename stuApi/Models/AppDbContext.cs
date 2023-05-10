using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace MartialArtApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 


        }
        public DbSet<Sports> Sports { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //product Table
            modelBuilder.Entity<Sports>().HasData(
                new Sports
                {
                    ProductId = 1,
                    ProductName = "Gloves",
                    Email = "Azhar@786.com",
                    State = "Punjab",
                    Address = "Daska",
                    Phone = "03311427734",

                });
            modelBuilder.Entity<Sports>().HasData(
               new Sports
               {
                   ProductId = 2,
                   ProductName = "Bat",
                   Email = "az@786.com",
                   State = "Punjab",
                   Address = "Daska",
                   Phone = "03311227734",

               });
            modelBuilder.Entity<Sports>().HasData(
               new Sports
               {
                   ProductId = 3,
                   ProductName = "SportsKit",
                   Email = "Ans@786.com",
                   State = "Punjab",
                   Address = "Daska",
                   Phone = "03313427734",

               });
            modelBuilder.Entity<Sports>().HasData(
               new Sports
               {
                   ProductId = 4,
                   ProductName = "showes",
                   Email = "anr@786.com",
                   State = "Punjab",
                   Address = "Daska",
                   Phone = "03321427734",

               });
        }
    }
}
