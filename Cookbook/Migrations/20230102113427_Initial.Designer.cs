﻿// <auto-generated />
using System;
using Cookbook.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cookbook.Migrations
{
    [DbContext(typeof(CookBookDbContext))]
    [Migration("20230102113427_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cookbook.Entities.Dishes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KindOfDietId")
                        .HasColumnType("int");

                    b.Property<int>("KindOfDishesId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KindOfDietId");

                    b.HasIndex("KindOfDishesId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("Cookbook.Entities.Ingredients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DishesId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DishesId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Cookbook.Entities.KindOfDiet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("kindOfDiet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KindOfDiets");
                });

            modelBuilder.Entity("Cookbook.Entities.KindOfDishes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("KindOfDish")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KindOfDishes");
                });

            modelBuilder.Entity("Cookbook.Entities.Dishes", b =>
                {
                    b.HasOne("Cookbook.Entities.KindOfDiet", "KindOfDiet")
                        .WithMany()
                        .HasForeignKey("KindOfDietId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cookbook.Entities.KindOfDishes", "KindOfDishes")
                        .WithMany()
                        .HasForeignKey("KindOfDishesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KindOfDiet");

                    b.Navigation("KindOfDishes");
                });

            modelBuilder.Entity("Cookbook.Entities.Ingredients", b =>
                {
                    b.HasOne("Cookbook.Entities.Dishes", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("DishesId");
                });

            modelBuilder.Entity("Cookbook.Entities.Dishes", b =>
                {
                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}
