
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

           


            modelBuilder.Entity<Review>().HasData(
                new { ReviewId = 1, Stars = 2, Text = "Godt sted", ResturentId = 1 },
                new { ReviewId = 2, Stars = 3, Text = "Det er okay", ResturentId = 1 },
                new { ReviewId = 3, Stars = 2, Text = "Kan bestemt ikke anbefale dette", ResturentId = 1 },
                new { ReviewId = 4, Stars = 2, Text = "Okay, men ikke godt ", ResturentId = 2 },
                new { ReviewId = 5, Stars = 1, Text = "Kommer aldrig her igen", ResturentId = 2 },
                new { ReviewId = 6, Stars = 3, Text = "Fint til pengene.", ResturentId = 1 },
                new { ReviewId = 7, Stars = 4, Text = "Mit lokale stamsted!", ResturentId = 1 },
                new { ReviewId = 8, Stars = 3, Text = "Kommer her ofte!", ResturentId = 1 },
                new { ReviewId = 9, Stars = 1, Text = "Nej nej nej", ResturentId = 2 },
                new { ReviewId = 10, Stars = 5, Text = "Så lækkert!", ResturentId = 2 },
                new { ReviewId = 11, Stars = 3, Text = "God smurt rundstyk, rigtig dejligt!", ResturentId = 3 },
                new { ReviewId = 12, Stars = 5, Text = "Dårlig servering, kold kaffe 0 stjerner herfra", ResturentId = 3 },
                new { ReviewId = 13, Stars = 5, Text = "Super lækkert med frisk fisk!", ResturentId = 4 },
                new { ReviewId = 14, Stars = 1, Text = "Fik kolera, og vildt dårlig mave dagen efter et besøg. Anbefalder ikke dette sted til min væreste fjende..", ResturentId = 4 },
                new { ReviewId = 15, Stars = 5, Text = "Den bedste franske hotdog i byen, perfekt frokost!", ResturentId = 5 },
                new { ReviewId = 16, Stars = 5, Text = "Selvom niveauet er faldet efter flytningen, er det stadig super lækkert, og de har en god sandwich", ResturentId = 5 },
                new { ReviewId = 17, Stars = 5, Text = "Ikke få deres karry sauce i jeres sandwich, den smager af bæ..", ResturentId = 5 }
                );

            modelBuilder.Entity<Resturent>().HasData(
                new { ResturentId = 1, Type = "Buffet", Name = "Jerrys", Address = "Fiskergade 2, 8000" },
                new { ResturentId = 2, Type = "Aftensmad", Name = "South India", Address = "Nørreallé 87, 8000" },
                new { ResturentId = 3, Type = "Morgenmad", Name = "Cafe Alberts", Address = "Møllevangsallé 22, 8200"},
                new { ResturentId = 4, Type = "Buffet", Name = "Running Sushi", Address = "Damvej 1, 6100" },
                new { ResturentId = 5, Type = "Frokost", Name = "Føtex StorcenterNord", Address = "Findlandsgade 142, 8200" }
                );

            modelBuilder.Entity<ResturentDishes>().HasData(
                new { ResturentId = 1, DishId = 1 },
                new { ResturentId = 1, DishId = 2 },
                new { ResturentId = 1, DishId = 3 },
                new { ResturentId = 1, DishId = 4 },
                new { ResturentId = 2, DishId = 5 },
                new { ResturentId = 2, DishId = 6 },
                new { ResturentId = 2, DishId = 7 },
                new { ResturentId = 3, DishId = 8 },
                new { ResturentId = 3, DishId = 9 },
                new { ResturentId = 4, DishId = 10 },
                new { ResturentId = 4, DishId = 11 },
                new { ResturentId = 5, DishId = 12 },
                new { ResturentId = 5, DishId = 13 },
                new { ResturentId = 5, DishId = 14 }
                
            );

            modelBuilder.Entity<Dish>().HasData(
                new { DishId = 1, Price = 44.0, Type = "Spaghetti Carbonara", ReviewId = 1 },
                new { DishId = 2, Price = 75.0, Type = "Pizza med rejer", ReviewId = 2 },
                new { DishId = 3, Price = 65.0, Type = "Pizza Peperoni", ReviewId = 6 },
                new { DishId = 4, Price = 70.0, Type = "Pizza Meatlover", ReviewId = 7 },
                new { DishId = 5, Price = 60.0, Type = "Butter Chicken", ReviewId = 4 },
                new { DishId = 6, Price = 30.0, Type = "Naan Broed med smoer", ReviewId = 9 },
                new { DishId = 7, Price = 40.0, Type = "Tandoori Chicken - Spicy!", ReviewId = 10 },
                new { DishId = 8, Price = 20.0, Type = "Smurt håndværker med pålæg", ReviewId = 11 },
                new { DishId = 9, Price = 5.0, Type = "Sort kaffe uden mælk", ReviewId = 12 },
                new { DishId = 10, Price = 250.0, Type = "Fri sushi", ReviewId = 13 },
                new { DishId = 11, Price = 120.0, Type = "10 stk. valgfri sushi", ReviewId = 14 },
                new { DishId = 12, Price = 12.0, Type = "fransk Hotdog", ReviewId = 15 },
                new { DishId = 13, Price = 25.0, Type = "Flæskestegs Sandwich", ReviewId = 16 },
                new { DishId = 14, Price = 25.0, Type = "Rugbrøds Sandwich", ReviewId = 17 }
                
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
                new {TableId = 5, ReviewId = 5, PersonId = 9, Name = "Mark"},

                new { TableId = 6, ReviewId = 6, PersonId = 10, Name = "Line" },
                new { TableId = 7, ReviewId = 7, PersonId = 11, Name = "Henrik" },
                new { TableId = 8, ReviewId = 8, PersonId = 12, Name = "Søren" },
                new { TableId = 9, ReviewId = 9, PersonId = 13, Name = "Laura" },
                new { TableId = 10, ReviewId = 10, PersonId = 14, Name = "Julie" },
                new { TableId = 11, ReviewId = 11, PersonId = 15, Name = "Frands" },
                new { TableId = 12, ReviewId = 12, PersonId = 16, Name = "Simon" },
                new { TableId = 13, ReviewId = 13, PersonId = 17, Name = "Thorsten" },
                new { TableId = 14, ReviewId = 14, PersonId = 18, Name = "Jørgen" },
                new { TableId = 15, ReviewId = 15, PersonId = 19, Name = "Ida" },
                new { TableId = 16, ReviewId = 16, PersonId = 20, Name = "Preben" },
                new { TableId = 17, ReviewId = 17, PersonId = 21, Name = "Jens" }
               

                );

            /* Det her kan man åbenbart ikke
            modelBuilder.Entity<GuestDishes>().HasData(
                new {PersonId = 10, ReviewId = 10, TableId = 6, Name = "Andreas", DishId = 7}
                );*/

            modelBuilder.Entity<Table>().HasData(
                new {TableId = 1, Number = 1, ResturentId = 1},
                new {TableId = 2, Number = 2, ResturentId = 1},
                new {TableId = 3, Number = 1, ResturentId = 2},
                new {TableId = 4, Number = 3, ResturentId = 1},
                new {TableId = 5, Number = 2, ResturentId = 2},

                new { TableId = 6, Number = 5, ResturentId = 3 },
                new { TableId = 7, Number = 3, ResturentId = 3 },
                new { TableId = 8, Number = 1, ResturentId = 4 },
                new { TableId = 9, Number = 10, ResturentId = 4 },
                new { TableId = 10, Number = 8, ResturentId = 5 },
                new { TableId = 11, Number = 1, ResturentId = 5 },
                new { TableId = 12, Number = 2, ResturentId = 5 },
                new { TableId = 13, Number = 3, ResturentId = 5 },
                new { TableId = 14, Number = 5, ResturentId = 5 },
                new { TableId = 15, Number = 1, ResturentId = 5 },
                new { TableId = 16, Number = 3, ResturentId = 5 },
                new { TableId = 17, Number = 2, ResturentId = 5 }
                );



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
