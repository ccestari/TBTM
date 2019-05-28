﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TakeBackTheMusic.Models;

namespace TakeBackTheMusic.Migrations
{
    [DbContext(typeof(TakeBackTheMusicContext))]
    [Migration("20190123212752_GenresSeeded")]
    partial class GenresSeeded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TakeBackTheMusic.Areas.Identity.Data.TakeBackTheMusicUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DOB");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("TakeBackTheMusic.Models.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("GenreDateAdded");

                    b.Property<string>("GenreDescription");

                    b.Property<string>("GenreName");

                    b.Property<DateTime>("GenreUpdatedDate");

                    b.HasKey("GenreID");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            GenreID = 1,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 654, DateTimeKind.Local).AddTicks(5759),
                            GenreDescription = "",
                            GenreName = "Acoustic",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 656, DateTimeKind.Local).AddTicks(9185)
                        },
                        new
                        {
                            GenreID = 2,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1387),
                            GenreDescription = "",
                            GenreName = "Alternative",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1400)
                        },
                        new
                        {
                            GenreID = 3,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1420),
                            GenreDescription = "",
                            GenreName = "Ambient",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1423)
                        },
                        new
                        {
                            GenreID = 4,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1427),
                            GenreDescription = "",
                            GenreName = "Americana",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1430)
                        },
                        new
                        {
                            GenreID = 5,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1435),
                            GenreDescription = "",
                            GenreName = "Bluegrass",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1438)
                        },
                        new
                        {
                            GenreID = 6,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1442),
                            GenreDescription = "",
                            GenreName = "Blues",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1445)
                        },
                        new
                        {
                            GenreID = 7,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1448),
                            GenreDescription = "",
                            GenreName = "Bollywood/Tollywood",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1451)
                        },
                        new
                        {
                            GenreID = 8,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1454),
                            GenreDescription = "",
                            GenreName = "Celtic",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1457)
                        },
                        new
                        {
                            GenreID = 9,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1461),
                            GenreDescription = "",
                            GenreName = "Childrens",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1464)
                        },
                        new
                        {
                            GenreID = 10,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1467),
                            GenreDescription = "",
                            GenreName = "Christian Rock",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1470)
                        },
                        new
                        {
                            GenreID = 11,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1473),
                            GenreDescription = "",
                            GenreName = "Christian/Gospel",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1476)
                        },
                        new
                        {
                            GenreID = 12,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1479),
                            GenreDescription = "",
                            GenreName = "Classical",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1482)
                        },
                        new
                        {
                            GenreID = 13,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1486),
                            GenreDescription = "",
                            GenreName = "Comedy",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1490)
                        },
                        new
                        {
                            GenreID = 14,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1494),
                            GenreDescription = "",
                            GenreName = "Country",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1496)
                        },
                        new
                        {
                            GenreID = 15,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1500),
                            GenreDescription = "",
                            GenreName = "DJ",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1503)
                        },
                        new
                        {
                            GenreID = 16,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1506),
                            GenreDescription = "",
                            GenreName = "Dance",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1509)
                        },
                        new
                        {
                            GenreID = 17,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1512),
                            GenreDescription = "",
                            GenreName = "Dubstep",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1515)
                        },
                        new
                        {
                            GenreID = 18,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1518),
                            GenreDescription = "",
                            GenreName = "EDM",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1521)
                        },
                        new
                        {
                            GenreID = 19,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1525),
                            GenreDescription = "",
                            GenreName = "Electronica",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1528)
                        },
                        new
                        {
                            GenreID = 20,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1531),
                            GenreDescription = "",
                            GenreName = "Experimental",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1534)
                        },
                        new
                        {
                            GenreID = 21,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1538),
                            GenreDescription = "",
                            GenreName = "Folk",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1541)
                        },
                        new
                        {
                            GenreID = 22,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1544),
                            GenreDescription = "",
                            GenreName = "Funk",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1547)
                        },
                        new
                        {
                            GenreID = 23,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1550),
                            GenreDescription = "",
                            GenreName = "Grime",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1553)
                        },
                        new
                        {
                            GenreID = 24,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1558),
                            GenreDescription = "",
                            GenreName = "Hip Hop",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1560)
                        },
                        new
                        {
                            GenreID = 25,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1564),
                            GenreDescription = "",
                            GenreName = "Holiday",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1567)
                        },
                        new
                        {
                            GenreID = 26,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1570),
                            GenreDescription = "",
                            GenreName = "House",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1573)
                        },
                        new
                        {
                            GenreID = 27,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1576),
                            GenreDescription = "",
                            GenreName = "Indie",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1579)
                        },
                        new
                        {
                            GenreID = 28,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1583),
                            GenreDescription = "",
                            GenreName = "Instrumental",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1586)
                        },
                        new
                        {
                            GenreID = 29,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1590),
                            GenreDescription = "",
                            GenreName = "Jam",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1593)
                        },
                        new
                        {
                            GenreID = 30,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1596),
                            GenreDescription = "",
                            GenreName = "Jazz",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1599)
                        },
                        new
                        {
                            GenreID = 31,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1603),
                            GenreDescription = "",
                            GenreName = "Latin",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1606)
                        },
                        new
                        {
                            GenreID = 32,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1611),
                            GenreDescription = "",
                            GenreName = "Metal",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1614)
                        },
                        new
                        {
                            GenreID = 33,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1618),
                            GenreDescription = "",
                            GenreName = "Other",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1621)
                        },
                        new
                        {
                            GenreID = 34,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1624),
                            GenreDescription = "",
                            GenreName = "Pop",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1628)
                        },
                        new
                        {
                            GenreID = 35,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1631),
                            GenreDescription = "",
                            GenreName = "Punk",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1634)
                        },
                        new
                        {
                            GenreID = 36,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1640),
                            GenreDescription = "",
                            GenreName = "R&B/Soul",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1642)
                        },
                        new
                        {
                            GenreID = 37,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1646),
                            GenreDescription = "",
                            GenreName = "Rap",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1649)
                        },
                        new
                        {
                            GenreID = 38,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1653),
                            GenreDescription = "",
                            GenreName = "Reggae",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1655)
                        },
                        new
                        {
                            GenreID = 39,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1659),
                            GenreDescription = "",
                            GenreName = "Rock",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1662)
                        },
                        new
                        {
                            GenreID = 40,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1666),
                            GenreDescription = "",
                            GenreName = "Rockabilly",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1669)
                        },
                        new
                        {
                            GenreID = 41,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1672),
                            GenreDescription = "",
                            GenreName = "Singer Songwriter",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1675)
                        },
                        new
                        {
                            GenreID = 42,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1679),
                            GenreDescription = "",
                            GenreName = "Ska",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1682)
                        },
                        new
                        {
                            GenreID = 43,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1685),
                            GenreDescription = "",
                            GenreName = "Spiritual",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1689)
                        },
                        new
                        {
                            GenreID = 44,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1692),
                            GenreDescription = "",
                            GenreName = "World",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 27, 51, 657, DateTimeKind.Local).AddTicks(1695)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TakeBackTheMusic.Areas.Identity.Data.TakeBackTheMusicUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TakeBackTheMusic.Areas.Identity.Data.TakeBackTheMusicUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TakeBackTheMusic.Areas.Identity.Data.TakeBackTheMusicUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TakeBackTheMusic.Areas.Identity.Data.TakeBackTheMusicUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
