using Categoryio.Api.Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Categoryio.Api.Database
{
    public class CategoryioDbContext : DbContext
    {
        public CategoryioDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(x =>
            {
                x.HasKey(x => x.Id);

                x.HasMany(x => x.Items)
                 .WithMany(x => x.Categories);
            });

            modelBuilder.Entity<Item>(x =>
            {
                x.HasKey(x => x.Id);
            });

            modelBuilder.Entity<Room>(x =>
            {
                x.HasKey(x => x.Id);
            });
        }
    }
}
