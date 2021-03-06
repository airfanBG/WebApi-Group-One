﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20200208154419_RemovePassword")]
    partial class RemovePassword
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccountNumber = "1234",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "2"
                        },
                        new
                        {
                            Id = "2",
                            AccountNumber = "1234",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "3"
                        });
                });

            modelBuilder.Entity("Models.Department", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 674, DateTimeKind.Local).AddTicks(8221),
                            DepartmentName = "Sells"
                        },
                        new
                        {
                            Id = "2",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 674, DateTimeKind.Local).AddTicks(9115),
                            DepartmentName = "Finance"
                        },
                        new
                        {
                            Id = "3",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 674, DateTimeKind.Local).AddTicks(9145),
                            DepartmentName = "IT"
                        });
                });

            modelBuilder.Entity("Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BankAccount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId1");

                    b.HasIndex("UserId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            BankAccount = 100000,
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 675, DateTimeKind.Local).AddTicks(4585),
                            DepartmentId = 3,
                            EmployeeNumber = "EA0011",
                            Telephone = "1231231",
                            UserId = "1"
                        });
                });

            modelBuilder.Entity("Models.EmployeeCustomers", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeCustomers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(9232),
                            CustomerId = "1",
                            EmployeeId = "1"
                        });
                });

            modelBuilder.Entity("Models.Photo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhotoDir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId1");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 673, DateTimeKind.Local).AddTicks(5386),
                            CurrentQuantity = 100,
                            Description = "Daily",
                            ProductName = "T-shirt",
                            ProductPrice = 10m
                        },
                        new
                        {
                            Id = "2",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 674, DateTimeKind.Local).AddTicks(2934),
                            CurrentQuantity = 50,
                            Description = "Daily",
                            ProductName = "Jacket",
                            ProductPrice = 150m
                        },
                        new
                        {
                            Id = "3",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 674, DateTimeKind.Local).AddTicks(3068),
                            CurrentQuantity = 200,
                            Description = "Daily",
                            ProductName = "Shoes",
                            ProductPrice = 125m
                        },
                        new
                        {
                            Id = "4",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 674, DateTimeKind.Local).AddTicks(3078),
                            CurrentQuantity = 1000,
                            Description = "Daily",
                            ProductName = "Socks",
                            ProductPrice = 2m
                        });
                });

            modelBuilder.Entity("Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "d69523c4-2b4f-4a60-8c4e-911c65bd9e12",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 675, DateTimeKind.Local).AddTicks(7614),
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "2d9786b8-ab7a-4c8a-9851-62d891511683",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 675, DateTimeKind.Local).AddTicks(8794),
                            RoleName = "User"
                        });
                });

            modelBuilder.Entity("Models.SaleOrder", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateOfSale")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("SalesOrders");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            CreatedAt = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = "2",
                            DateOfSale = new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(5315),
                            Note = "",
                            ProductId = "1",
                            Quantity = 5
                        },
                        new
                        {
                            Id = "2",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7438),
                            CustomerId = "2",
                            DateOfSale = new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7393),
                            Note = "",
                            ProductId = "2",
                            Quantity = 15
                        },
                        new
                        {
                            Id = "3",
                            CreatedAt = new DateTime(2019, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = "1",
                            DateOfSale = new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7443),
                            Note = "",
                            ProductId = "3",
                            Quantity = 3
                        },
                        new
                        {
                            Id = "4",
                            CreatedAt = new DateTime(2019, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = "1",
                            DateOfSale = new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7448),
                            Note = "",
                            ProductId = "4",
                            Quantity = 8
                        },
                        new
                        {
                            Id = "5",
                            CreatedAt = new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = "1",
                            DateOfSale = new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7453),
                            Note = "",
                            ProductId = "1",
                            Quantity = 10
                        },
                        new
                        {
                            Id = "6",
                            CreatedAt = new DateTime(2019, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = "2",
                            DateOfSale = new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7458),
                            Note = "",
                            ProductId = "4",
                            Quantity = 7
                        },
                        new
                        {
                            Id = "7",
                            CreatedAt = new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = "1",
                            DateOfSale = new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7463),
                            Note = "",
                            ProductId = "2",
                            Quantity = 1
                        },
                        new
                        {
                            Id = "8",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7471),
                            CustomerId = "2",
                            DateOfSale = new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(7467),
                            Note = "",
                            ProductId = "2",
                            Quantity = 11
                        });
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c500c609-9be8-4d9d-8c2f-096b7f69c0eb",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 668, DateTimeKind.Local).AddTicks(776),
                            Email = "airfan@das.vf",
                            EmailConfirmed = false,
                            FirstName = "one",
                            LastName = "one",
                            LockoutEnabled = false,
                            PasswordHash = "1234",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ec1f627f-8fe1-4f30-8efe-d3b841c7dec8",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "08d7e0b6-f0e4-4867-9703-ab9469b4a769",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 671, DateTimeKind.Local).AddTicks(5169),
                            Email = "minka@das.vf",
                            EmailConfirmed = false,
                            FirstName = "Minka",
                            LastName = "Minkova",
                            LockoutEnabled = false,
                            PasswordHash = "1234",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a99fdfdb-8444-42c6-b7e4-9ee5e7c853cf",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3ddcc9a1-7995-4886-9bbe-0d83a6aa2520",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 671, DateTimeKind.Local).AddTicks(5278),
                            Email = "ginka@das.vf",
                            EmailConfirmed = false,
                            FirstName = "Ginka",
                            LastName = "Ginkova",
                            LockoutEnabled = false,
                            PasswordHash = "1234",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "58f209a0-8548-4e4d-b6a9-acb026820a4f",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("Models.UserOrder", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FinnishedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserOrders");
                });

            modelBuilder.Entity("Models.UserRoles", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 675, DateTimeKind.Local).AddTicks(9625),
                            RoleId = "1",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "2",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 44, 18, 676, DateTimeKind.Local).AddTicks(672),
                            RoleId = "2",
                            UserId = "2"
                        });
                });

            modelBuilder.Entity("Models.UserToken", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId1");

                    b.ToTable("UserTokens");
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
                    b.HasOne("Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Models.User", null)
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

                    b.HasOne("Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Customer", b =>
                {
                    b.HasOne("Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Models.Employee", b =>
                {
                    b.HasOne("Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId1");

                    b.HasOne("Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Models.EmployeeCustomers", b =>
                {
                    b.HasOne("Models.Customer", "Customer")
                        .WithMany("EmployeeCustomers")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Models.Employee", "Employee")
                        .WithMany("EmployeeCustomers")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("Models.Photo", b =>
                {
                    b.HasOne("Models.Product", "Product")
                        .WithMany("Photos")
                        .HasForeignKey("ProductId1");
                });

            modelBuilder.Entity("Models.SaleOrder", b =>
                {
                    b.HasOne("Models.Customer", "Customer")
                        .WithMany("SaleOrders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Models.Product", "Product")
                        .WithMany("SalesOrders")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Models.UserOrder", b =>
                {
                    b.HasOne("Models.User", "User")
                        .WithMany("UserOrders")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Models.UserRoles", b =>
                {
                    b.HasOne("Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId");

                    b.HasOne("Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Models.UserToken", b =>
                {
                    b.HasOne("Models.User", "User")
                        .WithMany("UserTokens")
                        .HasForeignKey("UserId1");
                });
#pragma warning restore 612, 618
        }
    }
}
