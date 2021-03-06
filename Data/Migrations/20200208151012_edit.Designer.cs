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
    [Migration("20200208151012_edit")]
    partial class edit
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
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 534, DateTimeKind.Local).AddTicks(7136),
                            DepartmentName = "Sells"
                        },
                        new
                        {
                            Id = "2",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 534, DateTimeKind.Local).AddTicks(9381),
                            DepartmentName = "Finance"
                        },
                        new
                        {
                            Id = "3",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 534, DateTimeKind.Local).AddTicks(9422),
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
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 536, DateTimeKind.Local).AddTicks(963),
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
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(6990),
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
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 533, DateTimeKind.Local).AddTicks(5832),
                            CurrentQuantity = 100,
                            Description = "Daily",
                            ProductName = "T-shirt",
                            ProductPrice = 10m
                        },
                        new
                        {
                            Id = "2",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 534, DateTimeKind.Local).AddTicks(2444),
                            CurrentQuantity = 50,
                            Description = "Daily",
                            ProductName = "Jacket",
                            ProductPrice = 150m
                        },
                        new
                        {
                            Id = "3",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 534, DateTimeKind.Local).AddTicks(2629),
                            CurrentQuantity = 200,
                            Description = "Daily",
                            ProductName = "Shoes",
                            ProductPrice = 125m
                        },
                        new
                        {
                            Id = "4",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 534, DateTimeKind.Local).AddTicks(2653),
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
                            ConcurrencyStamp = "24dd233a-9b4d-4350-8aac-a4fa2e47ef5e",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 536, DateTimeKind.Local).AddTicks(5660),
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "009af38c-7cd1-4fbd-a756-e5abd36f1066",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 536, DateTimeKind.Local).AddTicks(7489),
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
                            DateOfSale = new DateTime(2020, 2, 8, 17, 10, 11, 537, DateTimeKind.Local).AddTicks(9782),
                            Note = "",
                            ProductId = "1",
                            Quantity = 5
                        },
                        new
                        {
                            Id = "2",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(4057),
                            CustomerId = "2",
                            DateOfSale = new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(3975),
                            Note = "",
                            ProductId = "2",
                            Quantity = 15
                        },
                        new
                        {
                            Id = "3",
                            CreatedAt = new DateTime(2019, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = "1",
                            DateOfSale = new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(4066),
                            Note = "",
                            ProductId = "3",
                            Quantity = 3
                        },
                        new
                        {
                            Id = "4",
                            CreatedAt = new DateTime(2019, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = "1",
                            DateOfSale = new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(4074),
                            Note = "",
                            ProductId = "4",
                            Quantity = 8
                        },
                        new
                        {
                            Id = "5",
                            CreatedAt = new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = "1",
                            DateOfSale = new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(4081),
                            Note = "",
                            ProductId = "1",
                            Quantity = 10
                        },
                        new
                        {
                            Id = "6",
                            CreatedAt = new DateTime(2019, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = "2",
                            DateOfSale = new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(4088),
                            Note = "",
                            ProductId = "4",
                            Quantity = 7
                        },
                        new
                        {
                            Id = "7",
                            CreatedAt = new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = "1",
                            DateOfSale = new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(4095),
                            Note = "",
                            ProductId = "2",
                            Quantity = 1
                        },
                        new
                        {
                            Id = "8",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(4108),
                            CustomerId = "2",
                            DateOfSale = new DateTime(2020, 2, 8, 17, 10, 11, 538, DateTimeKind.Local).AddTicks(4102),
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

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            ConcurrencyStamp = "057d27c1-6aef-4876-91b2-62df403900c1",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 519, DateTimeKind.Local).AddTicks(5715),
                            Email = "airfan@das.vf",
                            EmailConfirmed = false,
                            FirstName = "one",
                            LastName = "one",
                            LockoutEnabled = false,
                            Password = "1234",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3934a7f7-03b3-4595-a75a-92d87c23d456",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "76815a63-0cf9-4057-8119-13d69af5db98",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 526, DateTimeKind.Local).AddTicks(3762),
                            Email = "minka@das.vf",
                            EmailConfirmed = false,
                            FirstName = "Minka",
                            LastName = "Minkova",
                            LockoutEnabled = false,
                            Password = "1234",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1565486e-2c8c-4dad-8df3-7d983a32b1de",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e77f242b-514f-4ed4-8c80-467844e914c0",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 526, DateTimeKind.Local).AddTicks(3910),
                            Email = "ginka@das.vf",
                            EmailConfirmed = false,
                            FirstName = "Ginka",
                            LastName = "Ginkova",
                            LockoutEnabled = false,
                            Password = "1234",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f74bf841-2323-4b6f-9eda-4e0569328264",
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
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 536, DateTimeKind.Local).AddTicks(8893),
                            RoleId = "1",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "2",
                            CreatedAt = new DateTime(2020, 2, 8, 17, 10, 11, 537, DateTimeKind.Local).AddTicks(1063),
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
