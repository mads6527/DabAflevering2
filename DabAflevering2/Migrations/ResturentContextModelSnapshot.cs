﻿// <auto-generated />
using System;
using DabAflevering2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DabAflevering2.Migrations
{
    [DbContext(typeof(ResturentContext))]
    partial class ResturentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DabAflevering2.Models.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Price");

                    b.Property<int>("ReviewId");

                    b.Property<string>("Type");

                    b.HasKey("DishId");

                    b.HasIndex("ReviewId");

                    b.ToTable("Dish");

                    b.HasData(
                        new
                        {
                            DishId = 1,
                            Price = 44.0,
                            ReviewId = 1,
                            Type = "Spaghetti Carbonara"
                        },
                        new
                        {
                            DishId = 2,
                            Price = 75.0,
                            ReviewId = 2,
                            Type = "Pizza med rejer"
                        },
                        new
                        {
                            DishId = 3,
                            Price = 65.0,
                            ReviewId = 6,
                            Type = "Pizza Peperoni"
                        },
                        new
                        {
                            DishId = 4,
                            Price = 70.0,
                            ReviewId = 7,
                            Type = "Pizza Meatlover"
                        },
                        new
                        {
                            DishId = 5,
                            Price = 60.0,
                            ReviewId = 4,
                            Type = "Butter Chicken"
                        },
                        new
                        {
                            DishId = 6,
                            Price = 30.0,
                            ReviewId = 5,
                            Type = "Naan Brød med smør"
                        },
                        new
                        {
                            DishId = 7,
                            Price = 40.0,
                            ReviewId = 10,
                            Type = "Tandoori Chicken - Spicy!"
                        });
                });

            modelBuilder.Entity("DabAflevering2.Models.GuestDishes", b =>
                {
                    b.Property<int>("DishId");

                    b.Property<int>("PersonId");

                    b.HasKey("DishId", "PersonId");

                    b.HasIndex("PersonId");

                    b.ToTable("GuestDishes");
                });

            modelBuilder.Entity("DabAflevering2.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.HasKey("PersonId");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            Name = "Mads Jørgensen"
                        },
                        new
                        {
                            PersonId = 2,
                            Name = "Andreas Elgaard Sørensen"
                        },
                        new
                        {
                            PersonId = 3,
                            Name = "Mark Højer"
                        },
                        new
                        {
                            PersonId = 4,
                            Name = "Mathias Jørgensen"
                        });
                });

            modelBuilder.Entity("DabAflevering2.Models.Resturent", b =>
                {
                    b.Property<int>("ResturentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("ResturentId");

                    b.ToTable("Resturent");

                    b.HasData(
                        new
                        {
                            ResturentId = 1,
                            Address = "fiskergade",
                            Name = "Jerrys",
                            Type = "buffet"
                        },
                        new
                        {
                            ResturentId = 2,
                            Address = "Nørreallé 87, 8000",
                            Name = "South India",
                            Type = "Indisk"
                        });
                });

            modelBuilder.Entity("DabAflevering2.Models.ResturentDishes", b =>
                {
                    b.Property<int>("DishId");

                    b.Property<int>("ResturentId");

                    b.HasKey("DishId", "ResturentId");

                    b.HasIndex("ResturentId");

                    b.ToTable("ResturentDishes");

                    b.HasData(
                        new
                        {
                            DishId = 1,
                            ResturentId = 1
                        },
                        new
                        {
                            DishId = 2,
                            ResturentId = 1
                        },
                        new
                        {
                            DishId = 3,
                            ResturentId = 1
                        },
                        new
                        {
                            DishId = 4,
                            ResturentId = 1
                        },
                        new
                        {
                            DishId = 5,
                            ResturentId = 2
                        },
                        new
                        {
                            DishId = 6,
                            ResturentId = 2
                        },
                        new
                        {
                            DishId = 7,
                            ResturentId = 2
                        });
                });

            modelBuilder.Entity("DabAflevering2.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ResturentId");

                    b.Property<int>("Stars");

                    b.Property<string>("Text");

                    b.HasKey("ReviewId");

                    b.HasIndex("ResturentId");

                    b.ToTable("Review");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            ResturentId = 1,
                            Stars = 2,
                            Text = "Godt sted"
                        },
                        new
                        {
                            ReviewId = 2,
                            ResturentId = 1,
                            Stars = 3,
                            Text = "lorte lort"
                        },
                        new
                        {
                            ReviewId = 3,
                            ResturentId = 1,
                            Stars = 2,
                            Text = "Tyndskid nejtak"
                        },
                        new
                        {
                            ReviewId = 4,
                            ResturentId = 2,
                            Stars = 2,
                            Text = "Okay, men ikke godt "
                        },
                        new
                        {
                            ReviewId = 5,
                            ResturentId = 2,
                            Stars = 1,
                            Text = "Kommer aldrig her igen"
                        },
                        new
                        {
                            ReviewId = 6,
                            ResturentId = 1,
                            Stars = 3,
                            Text = "Fint til pengene."
                        },
                        new
                        {
                            ReviewId = 7,
                            ResturentId = 1,
                            Stars = 4,
                            Text = "Mit lokale stamsted!"
                        },
                        new
                        {
                            ReviewId = 8,
                            ResturentId = 1,
                            Stars = 3,
                            Text = "Kommer her ofte!"
                        },
                        new
                        {
                            ReviewId = 9,
                            ResturentId = 1,
                            Stars = 1,
                            Text = "Nej nej nej"
                        },
                        new
                        {
                            ReviewId = 10,
                            ResturentId = 2,
                            Stars = 5,
                            Text = "Så lækkert!"
                        });
                });

            modelBuilder.Entity("DabAflevering2.Models.Table", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Number");

                    b.Property<int>("ResturentId");

                    b.HasKey("TableId");

                    b.HasIndex("ResturentId");

                    b.ToTable("Table");

                    b.HasData(
                        new
                        {
                            TableId = 1,
                            Number = 1,
                            ResturentId = 1
                        });
                });

            modelBuilder.Entity("DabAflevering2.Models.TableWaiters", b =>
                {
                    b.Property<int>("TableId");

                    b.Property<int>("PersonId");

                    b.HasKey("TableId", "PersonId");

                    b.HasIndex("PersonId");

                    b.ToTable("TableWaiters");
                });

            modelBuilder.Entity("DabAflevering2.Models.Guest", b =>
                {
                    b.HasBaseType("DabAflevering2.Models.Person");

                    b.Property<int?>("ReviewId");

                    b.Property<int>("TableId");

                    b.HasIndex("ReviewId");

                    b.HasIndex("TableId");

                    b.HasDiscriminator().HasValue("Guest");

                    b.HasData(
                        new
                        {
                            PersonId = 5,
                            TableId = 1
                        });
                });

            modelBuilder.Entity("DabAflevering2.Models.Waiter", b =>
                {
                    b.HasBaseType("DabAflevering2.Models.Person");

                    b.Property<double>("Salery");

                    b.HasDiscriminator().HasValue("Waiter");
                });

            modelBuilder.Entity("DabAflevering2.Models.Dish", b =>
                {
                    b.HasOne("DabAflevering2.Models.Review", "Review")
                        .WithMany("Dishes")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DabAflevering2.Models.GuestDishes", b =>
                {
                    b.HasOne("DabAflevering2.Models.Dish", "Dish")
                        .WithMany("GuestDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DabAflevering2.Models.Guest", "Guest")
                        .WithMany("guestDishes")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DabAflevering2.Models.ResturentDishes", b =>
                {
                    b.HasOne("DabAflevering2.Models.Dish", "Dish")
                        .WithMany("ResturentDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DabAflevering2.Models.Resturent", "Resturent")
                        .WithMany("ResturentDishes")
                        .HasForeignKey("ResturentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("DabAflevering2.Models.Review", b =>
                {
                    b.HasOne("DabAflevering2.Models.Resturent", "Resturent")
                        .WithMany("Reviews")
                        .HasForeignKey("ResturentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DabAflevering2.Models.Table", b =>
                {
                    b.HasOne("DabAflevering2.Models.Resturent", "Resturent")
                        .WithMany("Tables")
                        .HasForeignKey("ResturentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DabAflevering2.Models.TableWaiters", b =>
                {
                    b.HasOne("DabAflevering2.Models.Waiter", "Waiter")
                        .WithMany("TableWaiters")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DabAflevering2.Models.Table", "Table")
                        .WithMany("TableWaiters")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DabAflevering2.Models.Guest", b =>
                {
                    b.HasOne("DabAflevering2.Models.Review", "Review")
                        .WithMany("Guests")
                        .HasForeignKey("ReviewId");

                    b.HasOne("DabAflevering2.Models.Table", "Table")
                        .WithMany("Guests")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
