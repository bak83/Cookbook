﻿// <auto-generated />
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
    [Migration("20230112193203_xx")]
    partial class xx
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

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

                    b.Property<int>("DishesId")
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

                    b.Property<int>("DishesId")
                        .HasColumnType("int");

                    b.Property<string>("kindOfDiet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DishesId")
                        .IsUnique();

                    b.ToTable("KindOfDiets");
                });

            modelBuilder.Entity("Cookbook.Entities.KindOfDishes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DishesId")
                        .HasColumnType("int");

                    b.Property<string>("KindOfDish")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DishesId")
                        .IsUnique();

                    b.ToTable("KindOfDishes");
                });

            modelBuilder.Entity("Cookbook.Entities.Ingredients", b =>
                {
                    b.HasOne("Cookbook.Entities.Dishes", "Dishes")
                        .WithMany("Ingredients")
                        .HasForeignKey("DishesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("Cookbook.Entities.KindOfDiet", b =>
                {
                    b.HasOne("Cookbook.Entities.Dishes", "Dishes")
                        .WithOne("KindOfDiet")
                        .HasForeignKey("Cookbook.Entities.KindOfDiet", "DishesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("Cookbook.Entities.KindOfDishes", b =>
                {
                    b.HasOne("Cookbook.Entities.Dishes", "Dishes")
                        .WithOne("KindOfDishes")
                        .HasForeignKey("Cookbook.Entities.KindOfDishes", "DishesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("Cookbook.Entities.Dishes", b =>
                {
                    b.Navigation("Ingredients");

                    b.Navigation("KindOfDiet")
                        .IsRequired();

                    b.Navigation("KindOfDishes")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}