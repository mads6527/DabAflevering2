
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DabAflevering2.Models;
using DabAflevering2.ViewModels;

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

            /*modelBuilder.Entity<Guest>().HasKey(ff => new { ff.PersonId });
            modelBuilder.Entity<Guest>()
                .HasOne(tw => tw.Person)
                .HasForeignKey(p => p.PersonId);*/


            modelBuilder.Entity<Review>().HasData(
                new { ReviewId = 1, Stars = 2, Text = "Godt sted", ResturentId = 1 },
                new { ReviewId = 2, Stars = 3, Text = "Det er okay", ResturentId = 1 },
                new { ReviewId = 3, Stars = 2, Text = "Kan bstemt ikke anbefale dette", ResturentId = 1 },
                new { ReviewId = 4, Stars = 2, Text = "Okay, men ikke godt ", ResturentId = 2 },
                new { ReviewId = 5, Stars = 1, Text = "Kommer aldrig her igen", ResturentId = 2 },
                new { ReviewId = 6, Stars = 3, Text = "Fint til pengene.", ResturentId = 1 },
                new { ReviewId = 7, Stars = 4, Text = "Mit lokale stamsted!", ResturentId = 1 },
                new { ReviewId = 8, Stars = 3, Text = "Kommer her ofte!", ResturentId = 1 },
                new { ReviewId = 9, Stars = 1, Text = "Nej nej nej", ResturentId = 2 },
                new { ReviewId = 10, Stars = 5, Text = "Så lækkert!", ResturentId = 2 }
                );

            modelBuilder.Entity<Resturent>().HasData(
                new { ResturentId = 1, Type = "buffet", Name = "Jerrys", Address = "fiskergade" },
                new { ResturentId = 2, Type = "Indisk", Name = "South India", Address = "Nørreallé 87, 8000" });

            modelBuilder.Entity<ResturentDishes>().HasData(
                new { ResturentId = 1, DishId = 1 },
                new { ResturentId = 1, DishId = 2 },
                new { ResturentId = 1, DishId = 3 },
                new { ResturentId = 1, DishId = 4 },
                new { ResturentId = 2, DishId = 5 },
                new { ResturentId = 2, DishId = 6 },
                new { ResturentId = 2, DishId = 7 }
            );

            modelBuilder.Entity<Dish>().HasData(
                new { DishId = 1, Price = 44.0, Type = "Spaghetti Carbonara", ReviewId = 1 },
                new { DishId = 2, Price = 75.0, Type = "Pizza med rejer", ReviewId = 2 },
                new { DishId = 3, Price = 65.0, Type = "Pizza Peperoni", ReviewId = 6 },
                new { DishId = 4, Price = 70.0, Type = "Pizza Meatlover", ReviewId = 7 },
                new { DishId = 5, Price = 60.0, Type = "Butter Chicken", ReviewId = 4 },
                new { DishId = 6, Price = 30.0, Type = "Naan Broed med smoer", ReviewId = 9 },
                new { DishId = 7, Price = 40.0, Type = "Tandoori Chicken - Spicy!", ReviewId = 10 }
            );



            //modelBuilder.Entity<Person>().HasData(
            //    new { PersonId = 1, Name = "Mads Jørgensen" },
            //    new { PersonId = 2, Name = "Andreas Elgaard Sørensen" },
            //    new { PersonId = 3, Name = "Mark Højer" },
            //    new { PersonId = 4, Name = "Mathias Jørgensen" }
            //    //new { PersonId = 5, Name = "Sure skidsen" }
            //);

            modelBuilder.Entity<Guest>().HasData(
                new { TableId = 1, ReviewId = 1, PersonId = 5, Name = "Benjamin"},
                new {TableId = 2, ReviewId = 2, PersonId = 6,Name = "Martin"},
                new {TableId = 3, ReviewId = 4, PersonId = 7, Name ="Mathias"},
                new {TableId = 4, ReviewId = 3, PersonId = 8, Name = "Madsemand"},
                new {TableId = 5, ReviewId = 5, PersonId = 9, Name = "Mark Løjer"});

            /* Det her kan man åbenbart ikke
            modelBuilder.Entity<GuestDishes>().HasData(
                new {PersonId = 10, ReviewId = 10, TableId = 6, Name = "Andreas", DishId = 7}
                );*/

            modelBuilder.Entity<Table>().HasData(
                new { TableId = 1, Number = 1, ResturentId = 1 },
                new {TableId = 2, Number = 2, ResturentId = 1},
                new {TableId = 3, Number = 1, ResturentId = 2},
                new{TableId = 4, Number = 3, ResturentId = 1},
                new {TableId = 5, Number = 2, ResturentId = 2},
                new  {TableId = 6, Number = 3, ResturentId = 3});


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
