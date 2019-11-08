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
    [Migration("20191106102342_Seed")]
    partial class Seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique()
                        .HasFilter("[PersonId] IS NOT NULL");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountNumber = "1234",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonId = 3
                        },
                        new
                        {
                            Id = 2,
                            AccountNumber = "1234",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonId = 4
                        });
                });

            modelBuilder.Entity("Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                            Id = 1,
                            CreatedAt = new DateTime(2019, 11, 6, 12, 23, 42, 136, DateTimeKind.Local).AddTicks(7792),
                            DepartmentName = "Sells"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 11, 6, 12, 23, 42, 136, DateTimeKind.Local).AddTicks(8342),
                            DepartmentName = "Finance"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 11, 6, 12, 23, 42, 136, DateTimeKind.Local).AddTicks(8364),
                            DepartmentName = "IT"
                        });
                });

            modelBuilder.Entity("Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BankAccount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PersonId")
                        .IsUnique()
                        .HasFilter("[PersonId] IS NOT NULL");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BankAccount = 100000,
                            CreatedAt = new DateTime(2019, 11, 6, 12, 23, 42, 137, DateTimeKind.Local).AddTicks(2728),
                            DepartmentId = 3,
                            EmployeeNumber = "EA0011",
                            PersonId = 2,
                            Telephone = "1231231"
                        });
                });

            modelBuilder.Entity("Models.EmployeeCustomers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeCustomers");
                });

            modelBuilder.Entity("Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                            Id = 1,
                            CreatedAt = new DateTime(2019, 11, 6, 12, 23, 42, 136, DateTimeKind.Local).AddTicks(3014),
                            CurrentQuantity = 100,
                            Description = "Daily",
                            ProductName = "T-shirt",
                            ProductPrice = 10m
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 11, 6, 12, 23, 42, 136, DateTimeKind.Local).AddTicks(5518),
                            CurrentQuantity = 50,
                            Description = "Daily",
                            ProductName = "Jacket",
                            ProductPrice = 150m
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 11, 6, 12, 23, 42, 136, DateTimeKind.Local).AddTicks(5570),
                            CurrentQuantity = 200,
                            Description = "Daily",
                            ProductName = "Shoes",
                            ProductPrice = 125m
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2019, 11, 6, 12, 23, 42, 136, DateTimeKind.Local).AddTicks(5576),
                            CurrentQuantity = 1000,
                            Description = "Daily",
                            ProductName = "Socks",
                            ProductPrice = 2m
                        });
                });

            modelBuilder.Entity("Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 11, 6, 12, 23, 42, 137, DateTimeKind.Local).AddTicks(4271),
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 11, 6, 12, 23, 42, 137, DateTimeKind.Local).AddTicks(4794),
                            RoleName = "User"
                        });
                });

            modelBuilder.Entity("Models.SaleOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfSale")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("SalesOrders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = 1,
                            DateOfSale = new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(885),
                            Note = "",
                            ProductId = 1,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3485),
                            CustomerId = 1,
                            DateOfSale = new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3427),
                            Note = "",
                            ProductId = 2,
                            Quantity = 15
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = 2,
                            DateOfSale = new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3490),
                            Note = "",
                            ProductId = 3,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2019, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = 1,
                            DateOfSale = new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3689),
                            Note = "",
                            ProductId = 4,
                            Quantity = 8
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = 1,
                            DateOfSale = new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3694),
                            Note = "",
                            ProductId = 1,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2019, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = 2,
                            DateOfSale = new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3698),
                            Note = "",
                            ProductId = 4,
                            Quantity = 7
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CustomerId = 1,
                            DateOfSale = new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3702),
                            Note = "",
                            ProductId = 2,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3709),
                            CustomerId = 2,
                            DateOfSale = new DateTime(2019, 11, 6, 12, 23, 42, 138, DateTimeKind.Local).AddTicks(3706),
                            Note = "",
                            ProductId = 2,
                            Quantity = 11
                        });
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2019, 11, 6, 12, 23, 42, 130, DateTimeKind.Local).AddTicks(5457),
                            Email = "dasda@das.vf",
                            FirstName = "one",
                            LastName = "one",
                            Password = "1234"
                        });
                });

            modelBuilder.Entity("Models.UserRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 11, 6, 12, 23, 42, 137, DateTimeKind.Local).AddTicks(5531),
                            RoleId = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 11, 6, 12, 23, 42, 137, DateTimeKind.Local).AddTicks(6508),
                            RoleId = 2,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Models.UserToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Models.Customer", b =>
                {
                    b.HasOne("Models.User", "Person")
                        .WithOne("Customer")
                        .HasForeignKey("Models.Customer", "PersonId");
                });

            modelBuilder.Entity("Models.Employee", b =>
                {
                    b.HasOne("Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.User", "Person")
                        .WithOne("Employee")
                        .HasForeignKey("Models.Employee", "PersonId");
                });

            modelBuilder.Entity("Models.EmployeeCustomers", b =>
                {
                    b.HasOne("Models.Customer", "Customer")
                        .WithMany("EmployeeCustomers")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Employee", "Employee")
                        .WithMany("EmployeeCustomers")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Photo", b =>
                {
                    b.HasOne("Models.Product", "Product")
                        .WithMany("Photos")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Models.SaleOrder", b =>
                {
                    b.HasOne("Models.Customer", "Customer")
                        .WithMany("SaleOrders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Product", "Product")
                        .WithMany("SalesOrders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.UserRoles", b =>
                {
                    b.HasOne("Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.UserToken", b =>
                {
                    b.HasOne("Models.User", "User")
                        .WithMany("UserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}