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
    [Migration("20190123213737_GenresSeedUpdate")]
    partial class GenresSeedUpdate
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

                    b.Property<string>("GenreDescription")
                        .HasMaxLength(256);

                    b.Property<string>("GenreName")
                        .HasMaxLength(50);

                    b.Property<DateTime>("GenreUpdatedDate");

                    b.HasKey("GenreID");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            GenreID = 1,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 620, DateTimeKind.Local).AddTicks(2413),
                            GenreDescription = "",
                            GenreName = "Acoustic",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 622, DateTimeKind.Local).AddTicks(9025)
                        },
                        new
                        {
                            GenreID = 2,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1390),
                            GenreDescription = "",
                            GenreName = "Alternative",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1403)
                        },
                        new
                        {
                            GenreID = 3,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1424),
                            GenreDescription = "",
                            GenreName = "Ambient",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1427)
                        },
                        new
                        {
                            GenreID = 4,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1433),
                            GenreDescription = "",
                            GenreName = "Americana",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1436)
                        },
                        new
                        {
                            GenreID = 5,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1439),
                            GenreDescription = "",
                            GenreName = "Bluegrass",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1442)
                        },
                        new
                        {
                            GenreID = 6,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1446),
                            GenreDescription = "",
                            GenreName = "Blues",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1449)
                        },
                        new
                        {
                            GenreID = 7,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1452),
                            GenreDescription = "",
                            GenreName = "Bollywood/Tollywood",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1455)
                        },
                        new
                        {
                            GenreID = 8,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1457),
                            GenreDescription = "",
                            GenreName = "Celtic",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1460)
                        },
                        new
                        {
                            GenreID = 9,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1463),
                            GenreDescription = "",
                            GenreName = "Childrens",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1465)
                        },
                        new
                        {
                            GenreID = 10,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1468),
                            GenreDescription = "",
                            GenreName = "Christian Rock",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1470)
                        },
                        new
                        {
                            GenreID = 11,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1542),
                            GenreDescription = "",
                            GenreName = "Christian/Gospel",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1546)
                        },
                        new
                        {
                            GenreID = 12,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1550),
                            GenreDescription = "",
                            GenreName = "Classical",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1552)
                        },
                        new
                        {
                            GenreID = 13,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1555),
                            GenreDescription = "",
                            GenreName = "Comedy",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1560)
                        },
                        new
                        {
                            GenreID = 14,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1563),
                            GenreDescription = "",
                            GenreName = "Country",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1566)
                        },
                        new
                        {
                            GenreID = 15,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1568),
                            GenreDescription = "",
                            GenreName = "DJ",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1571)
                        },
                        new
                        {
                            GenreID = 16,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1574),
                            GenreDescription = "",
                            GenreName = "Dance",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1576)
                        },
                        new
                        {
                            GenreID = 17,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1579),
                            GenreDescription = "",
                            GenreName = "Dubstep",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1582)
                        },
                        new
                        {
                            GenreID = 18,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1585),
                            GenreDescription = "",
                            GenreName = "EDM",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1588)
                        },
                        new
                        {
                            GenreID = 19,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1592),
                            GenreDescription = "",
                            GenreName = "Electronica",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1594)
                        },
                        new
                        {
                            GenreID = 20,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1598),
                            GenreDescription = "",
                            GenreName = "Experimental",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1600)
                        },
                        new
                        {
                            GenreID = 21,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1604),
                            GenreDescription = "",
                            GenreName = "Folk",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1607)
                        },
                        new
                        {
                            GenreID = 22,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1611),
                            GenreDescription = "",
                            GenreName = "Funk",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1614)
                        },
                        new
                        {
                            GenreID = 23,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1617),
                            GenreDescription = "",
                            GenreName = "Grime",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1621)
                        },
                        new
                        {
                            GenreID = 24,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1627),
                            GenreDescription = "",
                            GenreName = "Hip Hop",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1630)
                        },
                        new
                        {
                            GenreID = 25,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1634),
                            GenreDescription = "",
                            GenreName = "Holiday",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1638)
                        },
                        new
                        {
                            GenreID = 26,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1642),
                            GenreDescription = "",
                            GenreName = "House",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1645)
                        },
                        new
                        {
                            GenreID = 27,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1649),
                            GenreDescription = "",
                            GenreName = "Indie",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1653)
                        },
                        new
                        {
                            GenreID = 28,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1657),
                            GenreDescription = "",
                            GenreName = "Instrumental",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1660)
                        },
                        new
                        {
                            GenreID = 29,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1664),
                            GenreDescription = "",
                            GenreName = "Jam",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1667)
                        },
                        new
                        {
                            GenreID = 30,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1671),
                            GenreDescription = "",
                            GenreName = "Jazz",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1674)
                        },
                        new
                        {
                            GenreID = 31,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1678),
                            GenreDescription = "",
                            GenreName = "Latin",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1681)
                        },
                        new
                        {
                            GenreID = 32,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1683),
                            GenreDescription = "",
                            GenreName = "Metal",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1686)
                        },
                        new
                        {
                            GenreID = 33,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1689),
                            GenreDescription = "",
                            GenreName = "Other",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1692)
                        },
                        new
                        {
                            GenreID = 34,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1694),
                            GenreDescription = "",
                            GenreName = "Pop",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1697)
                        },
                        new
                        {
                            GenreID = 35,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1700),
                            GenreDescription = "",
                            GenreName = "Punk",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1703)
                        },
                        new
                        {
                            GenreID = 36,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1707),
                            GenreDescription = "",
                            GenreName = "R&B/Soul",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1710)
                        },
                        new
                        {
                            GenreID = 37,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1713),
                            GenreDescription = "",
                            GenreName = "Rap",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1716)
                        },
                        new
                        {
                            GenreID = 38,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1718),
                            GenreDescription = "",
                            GenreName = "Reggae",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1721)
                        },
                        new
                        {
                            GenreID = 39,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1724),
                            GenreDescription = "",
                            GenreName = "Rock",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1726)
                        },
                        new
                        {
                            GenreID = 40,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1729),
                            GenreDescription = "",
                            GenreName = "Rockabilly",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1732)
                        },
                        new
                        {
                            GenreID = 41,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1736),
                            GenreDescription = "",
                            GenreName = "Singer Songwriter",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1738)
                        },
                        new
                        {
                            GenreID = 42,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1741),
                            GenreDescription = "",
                            GenreName = "Ska",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1743)
                        },
                        new
                        {
                            GenreID = 43,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1746),
                            GenreDescription = "",
                            GenreName = "Spiritual",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1749)
                        },
                        new
                        {
                            GenreID = 44,
                            GenreDateAdded = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1752),
                            GenreDescription = "",
                            GenreName = "World",
                            GenreUpdatedDate = new DateTime(2019, 1, 23, 16, 37, 37, 623, DateTimeKind.Local).AddTicks(1754)
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
