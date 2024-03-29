﻿// <auto-generated />
using System;
using DabAflevering2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DabAflevering2.Migrations
{
    [DbContext(typeof(ResturentContext))]
    [Migration("20191107132929_firt dat")]
    partial class firtdat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                });

            modelBuilder.Entity("DabAflevering2.Models.ResturentDishes", b =>
                {
                    b.Property<int>("DishId");

                    b.Property<int>("ResturentId");

                    b.HasKey("DishId", "ResturentId");

                    b.HasIndex("ResturentId");

                    b.ToTable("ResturentDishes");
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
                            ReviewId = 9,
                            ResturentId = 7,
                            Stars = 1,
                            Text = "Mads Jørgensen"
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

                    b.Property<DateTime>("Time");

                    b.HasIndex("ReviewId");

                    b.HasIndex("TableId");

                    b.HasDiscriminator().HasValue("Guest");
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
