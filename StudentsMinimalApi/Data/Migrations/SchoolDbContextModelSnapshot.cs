﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentsMinimalApi.Data;

#nullable disable

namespace StudentsMinimalApi.Data.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("StudentsMinimalApi.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("School")
                        .HasColumnType("TEXT");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            FirstName = "Tom",
                            LastName = "Max",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 2,
                            FirstName = "Ann",
                            LastName = "Fay",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 3,
                            FirstName = "Joe",
                            LastName = "Sun",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 4,
                            FirstName = "Sue",
                            LastName = "Fox",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 5,
                            FirstName = "Ben",
                            LastName = "Ray",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 6,
                            FirstName = "Zoe",
                            LastName = "Cox",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 7,
                            FirstName = "Sam",
                            LastName = "Ray",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 8,
                            FirstName = "Dan",
                            LastName = "Ash",
                            School = "Medicine"
                        },
                        new
                        {
                            StudentId = 9,
                            FirstName = "Pat",
                            LastName = "Lee",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 10,
                            FirstName = "Kim",
                            LastName = "Day",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 11,
                            FirstName = "Tim",
                            LastName = "Rex",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 12,
                            FirstName = "Rob",
                            LastName = "Ram",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 13,
                            FirstName = "Jan",
                            LastName = "Fry",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 14,
                            FirstName = "Jim",
                            LastName = "Tex",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 15,
                            FirstName = "Ben",
                            LastName = "Kid",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 16,
                            FirstName = "Mia",
                            LastName = "Chu",
                            School = "Medicine"
                        },
                        new
                        {
                            StudentId = 17,
                            FirstName = "Ted",
                            LastName = "Tao",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 18,
                            FirstName = "Amy",
                            LastName = "Day",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 19,
                            FirstName = "Ian",
                            LastName = "Roy",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 20,
                            FirstName = "Liz",
                            LastName = "Kit",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 21,
                            FirstName = "Mat",
                            LastName = "Tan",
                            School = "Medicine"
                        },
                        new
                        {
                            StudentId = 22,
                            FirstName = "Deb",
                            LastName = "Roy",
                            School = "Medicine"
                        },
                        new
                        {
                            StudentId = 23,
                            FirstName = "Ana",
                            LastName = "Ray",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 24,
                            FirstName = "Lyn",
                            LastName = "Poe",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 25,
                            FirstName = "Amy",
                            LastName = "Raj",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 26,
                            FirstName = "Kim",
                            LastName = "Ash",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 27,
                            FirstName = "Bec",
                            LastName = "Kid",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 28,
                            FirstName = "Eva",
                            LastName = "Fry",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 29,
                            FirstName = "Eli",
                            LastName = "Lap",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 30,
                            FirstName = "Sam",
                            LastName = "Yim",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 31,
                            FirstName = "Joe",
                            LastName = "Hui",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 32,
                            FirstName = "Liz",
                            LastName = "Jin",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 33,
                            FirstName = "Ric",
                            LastName = "Kuo",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 34,
                            FirstName = "Pam",
                            LastName = "Mak",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 35,
                            FirstName = "Cat",
                            LastName = "Yao",
                            School = "Medicine"
                        },
                        new
                        {
                            StudentId = 36,
                            FirstName = "Lou",
                            LastName = "Zhu",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 37,
                            FirstName = "Tom",
                            LastName = "Dag",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 38,
                            FirstName = "Stu",
                            LastName = "Day",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 39,
                            FirstName = "Tom",
                            LastName = "Gad",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 40,
                            FirstName = "Bob",
                            LastName = "Bee",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 41,
                            FirstName = "Jim",
                            LastName = "Ots",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 42,
                            FirstName = "Tom",
                            LastName = "Mag",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 43,
                            FirstName = "Hal",
                            LastName = "Doe",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 44,
                            FirstName = "Roy",
                            LastName = "Kim",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 45,
                            FirstName = "Vis",
                            LastName = "Cox",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 46,
                            FirstName = "Kay",
                            LastName = "Aga",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 47,
                            FirstName = "Reo",
                            LastName = "Hui",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 48,
                            FirstName = "Bob",
                            LastName = "Roe",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 49,
                            FirstName = "Jay",
                            LastName = "Eff",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 50,
                            FirstName = "Eva",
                            LastName = "Chu",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 51,
                            FirstName = "Lex",
                            LastName = "Rae",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 52,
                            FirstName = "Lin",
                            LastName = "Dex",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 53,
                            FirstName = "Tom",
                            LastName = "Dag",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 54,
                            FirstName = "Ben",
                            LastName = "Shy",
                            School = "Computing"
                        },
                        new
                        {
                            StudentId = 55,
                            FirstName = "Rob",
                            LastName = "Bos",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 56,
                            FirstName = "Ali",
                            LastName = "Mac",
                            School = "Business"
                        },
                        new
                        {
                            StudentId = 57,
                            FirstName = "Ken",
                            LastName = "Sim",
                            School = "Medicine"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
