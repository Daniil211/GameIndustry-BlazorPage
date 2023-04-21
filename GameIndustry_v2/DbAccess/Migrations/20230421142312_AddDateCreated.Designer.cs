﻿// <auto-generated />
using System;
using Application.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Application.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230421142312_AddDateCreated")]
    partial class AddDateCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Application.Persistence.Models.GameDeveloper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("StudioDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("GameDevelopers");
                });

            modelBuilder.Entity("Application.Persistence.Models.GameModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("DeveloperId")
                        .HasColumnType("int");

                    b.Property<string>("GamePlayVideo")
                        .HasColumnType("longtext");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("InSale")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ReleaseDate")
                        .IsRequired()
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperId");

                    b.ToTable("GameModels");
                });

            modelBuilder.Entity("Application.Persistence.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Application.Persistence.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsPremiumMember")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .HasColumnType("longtext");

                    b.Property<bool>("Sex")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 19,
                            IsPremiumMember = false,
                            Password = "User1",
                            Role = "User",
                            Sex = false,
                            Username = "User1"
                        },
                        new
                        {
                            Id = 2,
                            Age = 10,
                            IsPremiumMember = true,
                            Password = "User2",
                            Role = "User",
                            Sex = false,
                            Username = "User2"
                        },
                        new
                        {
                            Id = 3,
                            Age = 20,
                            IsPremiumMember = true,
                            Password = "User3",
                            Role = "Admin",
                            Sex = false,
                            Username = "User3"
                        },
                        new
                        {
                            Id = 4,
                            Age = 20,
                            IsPremiumMember = true,
                            Password = "Studio",
                            Role = "Studio",
                            Sex = false,
                            Username = "Studio"
                        });
                });

            modelBuilder.Entity("GameModelGenre", b =>
                {
                    b.Property<int>("GamesId")
                        .HasColumnType("int");

                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.HasKey("GamesId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("GameModelGenre");
                });

            modelBuilder.Entity("Application.Persistence.Models.GameModel", b =>
                {
                    b.HasOne("Application.Persistence.Models.GameDeveloper", "Developer")
                        .WithMany("Games")
                        .HasForeignKey("DeveloperId");

                    b.Navigation("Developer");
                });

            modelBuilder.Entity("GameModelGenre", b =>
                {
                    b.HasOne("Application.Persistence.Models.GameModel", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Application.Persistence.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Application.Persistence.Models.GameDeveloper", b =>
                {
                    b.Navigation("Games");
                });
#pragma warning restore 612, 618
        }
    }
}
