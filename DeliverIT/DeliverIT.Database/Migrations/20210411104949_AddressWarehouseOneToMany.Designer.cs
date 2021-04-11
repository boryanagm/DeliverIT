﻿// <auto-generated />
using System;
using DeliverIT.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Deliverit.Database.Migrations
{
    [DbContext(typeof(DeliveritDbContext))]
    [Migration("20210411104949_AddressWarehouseOneToMany")]
    partial class AddressWarehouseOneToMany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeliverIT.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DeliverIT.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DeliverIT.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DeliverIT.Models.Parcel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ShipmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WarehouseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ShipmentId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Parcels");
                });

            modelBuilder.Entity("DeliverIT.Models.Shipment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WarehouseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Shipments");
                });

            modelBuilder.Entity("DeliverIT.Models.Warehouse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("Deliverit.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(35)")
                        .HasMaxLength(35);

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1db0c76c-ab76-4105-be89-3af983f6f137"),
                            CreatedOn = new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(7747),
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = new Guid("df79ccb6-1f56-41da-9f8f-df2f92a468bb"),
                            CreatedOn = new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(8177),
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = new Guid("7aeb290e-3592-4128-a77a-1a6db6fd81f5"),
                            CreatedOn = new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(8185),
                            Name = "Medical"
                        },
                        new
                        {
                            Id = new Guid("72280df2-7d81-4ec6-936a-51e19aabf7ff"),
                            CreatedOn = new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(8185),
                            Name = "Books"
                        });
                });

            modelBuilder.Entity("Deliverit.Models.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(55)")
                        .HasMaxLength(55);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                            CountryId = new Guid("2a84fe90-6605-4052-8a49-e7251af05754"),
                            CreatedOn = new DateTime(2021, 4, 11, 10, 49, 49, 12, DateTimeKind.Utc).AddTicks(6284),
                            Name = "Barcelona"
                        },
                        new
                        {
                            Id = new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                            CountryId = new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                            CreatedOn = new DateTime(2021, 4, 11, 10, 49, 49, 12, DateTimeKind.Utc).AddTicks(7661),
                            Name = "Berlin"
                        },
                        new
                        {
                            Id = new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                            CountryId = new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                            CreatedOn = new DateTime(2021, 4, 11, 10, 49, 49, 12, DateTimeKind.Utc).AddTicks(7695),
                            Name = "Paris"
                        },
                        new
                        {
                            Id = new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                            CountryId = new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                            CreatedOn = new DateTime(2021, 4, 11, 10, 49, 49, 12, DateTimeKind.Utc).AddTicks(7695),
                            Name = "Vilnius"
                        });
                });

            modelBuilder.Entity("Deliverit.Models.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(55)")
                        .HasMaxLength(55);

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2a84fe90-6605-4052-8a49-e7251af05754"),
                            CreatedOn = new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(5897),
                            Name = "Spain"
                        },
                        new
                        {
                            Id = new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                            CreatedOn = new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(6327),
                            Name = "Germany"
                        },
                        new
                        {
                            Id = new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                            CreatedOn = new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(6336),
                            Name = "France"
                        },
                        new
                        {
                            Id = new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                            CreatedOn = new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(6344),
                            Name = "Lithuania"
                        });
                });

            modelBuilder.Entity("Deliverit.Models.Status", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(35)")
                        .HasMaxLength(35);

                    b.HasKey("Id");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            Id = new Guid("917f8117-d392-4f64-81fb-48415f80f77e"),
                            CreatedOn = new DateTime(2021, 4, 11, 10, 49, 49, 14, DateTimeKind.Utc).AddTicks(9647),
                            Name = "Preparing"
                        },
                        new
                        {
                            Id = new Guid("858ac364-d94f-414c-bbea-a0f5b8679b3d"),
                            CreatedOn = new DateTime(2021, 4, 11, 10, 49, 49, 15, DateTimeKind.Utc).AddTicks(51),
                            Name = "OnTheWay"
                        },
                        new
                        {
                            Id = new Guid("84568d3c-04df-47c3-9ad8-216b1d664166"),
                            CreatedOn = new DateTime(2021, 4, 11, 10, 49, 49, 15, DateTimeKind.Utc).AddTicks(60),
                            Name = "Completed"
                        },
                        new
                        {
                            Id = new Guid("b31754e2-82fc-4862-ad20-9331a87537eb"),
                            CreatedOn = new DateTime(2021, 4, 11, 10, 49, 49, 15, DateTimeKind.Utc).AddTicks(68),
                            Name = "Canceled"
                        });
                });

            modelBuilder.Entity("DeliverIT.Models.Address", b =>
                {
                    b.HasOne("Deliverit.Models.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DeliverIT.Models.Customer", b =>
                {
                    b.HasOne("DeliverIT.Models.Address", "Address")
                        .WithMany("Customers")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DeliverIT.Models.Employee", b =>
                {
                    b.HasOne("DeliverIT.Models.Address", "Address")
                        .WithMany("Employees")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DeliverIT.Models.Parcel", b =>
                {
                    b.HasOne("Deliverit.Models.Category", "Category")
                        .WithMany("Parcels")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DeliverIT.Models.Customer", "Customer")
                        .WithMany("Parcels")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DeliverIT.Models.Employee", "Employee")
                        .WithMany("Parcels")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DeliverIT.Models.Shipment", "Shipment")
                        .WithMany("Parcels")
                        .HasForeignKey("ShipmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DeliverIT.Models.Warehouse", "Warehouse")
                        .WithMany("Parcels")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DeliverIT.Models.Shipment", b =>
                {
                    b.HasOne("Deliverit.Models.Status", "Status")
                        .WithMany("Shipments")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DeliverIT.Models.Warehouse", "Warehouse")
                        .WithMany("Shipments")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DeliverIT.Models.Warehouse", b =>
                {
                    b.HasOne("DeliverIT.Models.Address", "Address")
                        .WithMany("Warehouses")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Deliverit.Models.City", b =>
                {
                    b.HasOne("Deliverit.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
