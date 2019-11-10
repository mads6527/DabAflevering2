
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DabAflevering2.Models;

namespace DabAflevering2.Models
{
    public partial class ResturentContext : DbContext
    {
        public ResturentContext(DbContextOptions<ResturentContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GuestDishes>().HasKey(gd => new { gd.DishId, gd.PersonId });
            modelBuilder.Entity<GuestDishes>()
                .HasOne(gd => gd.Dish)
                .WithMany(d => d.GuestDishes)
                .HasForeignKey(gd => gd.DishId);
            modelBuilder.Entity<GuestDishes>()
                .HasOne(gd => gd.Guest)
                .WithMany(g => g.guestDishes)
                .HasForeignKey(gd => gd.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ResturentDishes>().HasKey(rd => new { rd.DishId, rd.ResturentId });
            modelBuilder.Entity<ResturentDishes>()
                .HasOne(rd => rd.Dish)
                .WithMany(d => d.ResturentDishes)
                .HasForeignKey(rd => rd.DishId);
            modelBuilder.Entity<ResturentDishes>()
                .HasOne(rd => rd.Resturent)
                .WithMany(r => r.ResturentDishes)
                .HasForeignKey(rd => rd.ResturentId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<TableWaiters>().HasKey(tw => new { tw.TableId, tw.PersonId });
            modelBuilder.Entity<TableWaiters>()
                .HasOne(tw => tw.Waiter)
                .WithMany(w => w.TableWaiters)
                .HasForeignKey(tw => tw.PersonId)
                .OnDelete(DeleteBehavior.Restrict); 
            modelBuilder.Entity<TableWaiters>()
                .HasOne(tw => tw.Table)
                .WithMany(t => t.TableWaiters)
                .HasForeignKey(tw => tw.TableId);

            modelBuilder.Entity<Person>().HasData(
                new {PersonId = 1, Name = "Mads Jørgensen"},
                new {PersonId = 2, Name = "Andreas Elgaard Sørensen"},
                new {PersonId = 3, Name = "Mark Højer" },
                new {PersonId = 4, Name = "Mathias Jørgensen" });
            modelBuilder.Entity<Dish>().HasData(
                new {DishId = 1, Price = 44, Type = "Spaghetti Carbonara"},
                new {DishId = 2, Price = 39, Type = "Spaghetti Bolognese"},
                new {DishId = 3, Price = 55, Type = "Lasagna"},
                new {DishId = 4, Price = 60, Type = "Spaghetti ala Casa"}); 
        }

        public DbSet<Dish> Dish { get; set; }
        public DbSet<GuestDishes> GuestDishes { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Resturent> Resturent { get; set; }
        public DbSet<ResturentDishes> ResturentDishes { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Table> Table { get; set; }
        public DbSet<TableWaiters> TableWaiters { get; set; }
        public DbSet<Waiter> Waiter { get; set; }
        public DbSet<Guest> Guest { get; set; }
    }
}
