﻿// <auto-generated />
using System;
using DeliverIT.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Deliverit.Database.Migrations
{
    [DbContext(typeof(DeliveritDbContext))]
    partial class DeliveritDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<bool>("IsDeleted")
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("36049406-10ba-499d-916b-063422046239"),
                            CityId = new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 678, DateTimeKind.Utc).AddTicks(1936),
                            IsDeleted = false,
                            StreetName = "Ramon Berenguer El Vell 1"
                        },
                        new
                        {
                            Id = new Guid("ac2fee3a-f76e-4d94-aa42-d85b4bb45299"),
                            CityId = new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 678, DateTimeKind.Utc).AddTicks(2711),
                            IsDeleted = false,
                            StreetName = "Zeughofstraße 20"
                        },
                        new
                        {
                            Id = new Guid("b1347388-583d-4324-870a-e487e61ef483"),
                            CityId = new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 678, DateTimeKind.Utc).AddTicks(2994),
                            IsDeleted = false,
                            StreetName = "Rue La Boetie 7"
                        },
                        new
                        {
                            Id = new Guid("97fa423a-a144-4d67-97f5-4211c2758dc5"),
                            CityId = new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 678, DateTimeKind.Utc).AddTicks(3003),
                            IsDeleted = false,
                            StreetName = "Liepkalnio 117"
                        },
                        new
                        {
                            Id = new Guid("5fd8c18f-6885-488e-af8c-ff06901a7d37"),
                            CityId = new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 678, DateTimeKind.Utc).AddTicks(3003),
                            IsDeleted = false,
                            StreetName = "Gran Via De Les Corts Catalanes 105"
                        },
                        new
                        {
                            Id = new Guid("da703902-00bc-47da-b950-4fa730494d4e"),
                            CityId = new Guid("e99abf10-63e9-4212-9053-87cb1d80763e"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 678, DateTimeKind.Utc).AddTicks(3012),
                            IsDeleted = false,
                            StreetName = "Passatge De Bocabella 11"
                        });
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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c803ff6d-efb9-401a-81d8-7e9df0fcd4c1"),
                            AddressId = new Guid("b1347388-583d-4324-870a-e487e61ef483"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 678, DateTimeKind.Utc).AddTicks(5265),
                            Email = "isabelle.huppert@gmail.com",
                            FirstName = "Isabelle",
                            IsDeleted = false,
                            LastName = "Huppert"
                        },
                        new
                        {
                            Id = new Guid("5adb06fe-fca4-4347-b1ea-118c55e17331"),
                            AddressId = new Guid("97fa423a-a144-4d67-97f5-4211c2758dc5"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 678, DateTimeKind.Utc).AddTicks(6710),
                            Email = "lukas.petr@gmail.com",
                            FirstName = "Lukas",
                            IsDeleted = false,
                            LastName = "Petrauskas"
                        });
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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d2c26c93-d589-4b05-850b-fbf21c59c84d"),
                            AddressId = new Guid("5fd8c18f-6885-488e-af8c-ff06901a7d37"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 678, DateTimeKind.Utc).AddTicks(7450),
                            Email = "fer.trujillo@gmail.com",
                            FirstName = "Fermin",
                            IsDeleted = false,
                            LastName = "Trujillo"
                        },
                        new
                        {
                            Id = new Guid("facdefb9-19df-42b3-9d3d-6524076e152f"),
                            AddressId = new Guid("da703902-00bc-47da-b950-4fa730494d4e"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 678, DateTimeKind.Utc).AddTicks(8594),
                            Email = "a.rivas@gmail.com",
                            FirstName = "Amador",
                            IsDeleted = false,
                            LastName = "Rivas"
                        });
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

                    b.Property<bool>("IsDeleted")
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("198457ae-236c-4592-90af-3ca2302a8737"),
                            CategoryId = new Guid("1db0c76c-ab76-4105-be89-3af983f6f137"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 678, DateTimeKind.Utc).AddTicks(9291),
                            CustomerId = new Guid("c803ff6d-efb9-401a-81d8-7e9df0fcd4c1"),
                            EmployeeId = new Guid("d2c26c93-d589-4b05-850b-fbf21c59c84d"),
                            IsDeleted = false,
                            ShipmentId = new Guid("ce465c59-4866-4905-bdbd-943a26f59fdd"),
                            WarehouseId = new Guid("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba"),
                            Weight = 10
                        },
                        new
                        {
                            Id = new Guid("28ae32a1-10a4-4aef-b262-3baaa1102753"),
                            CategoryId = new Guid("72280df2-7d81-4ec6-936a-51e19aabf7ff"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 679, DateTimeKind.Utc).AddTicks(1183),
                            CustomerId = new Guid("5adb06fe-fca4-4347-b1ea-118c55e17331"),
                            EmployeeId = new Guid("facdefb9-19df-42b3-9d3d-6524076e152f"),
                            IsDeleted = false,
                            ShipmentId = new Guid("e2a2c29b-b7f4-458a-9cde-4a70717607c8"),
                            WarehouseId = new Guid("988a4201-8c55-42fc-b2a6-e08d1abe6693"),
                            Weight = 5
                        });
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

                    b.Property<bool>("IsDeleted")
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("ce465c59-4866-4905-bdbd-943a26f59fdd"),
                            ArrivalDate = new DateTime(2021, 4, 22, 15, 26, 59, 679, DateTimeKind.Utc).AddTicks(2336),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 679, DateTimeKind.Utc).AddTicks(1983),
                            DepartureDate = new DateTime(2021, 4, 15, 15, 26, 59, 679, DateTimeKind.Utc).AddTicks(1983),
                            IsDeleted = false,
                            StatusId = new Guid("917f8117-d392-4f64-81fb-48415f80f77e"),
                            WarehouseId = new Guid("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba")
                        },
                        new
                        {
                            Id = new Guid("e2a2c29b-b7f4-458a-9cde-4a70717607c8"),
                            ArrivalDate = new DateTime(2021, 4, 20, 15, 26, 59, 679, DateTimeKind.Utc).AddTicks(3472),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 679, DateTimeKind.Utc).AddTicks(3446),
                            DepartureDate = new DateTime(2021, 4, 15, 15, 26, 59, 679, DateTimeKind.Utc).AddTicks(3446),
                            IsDeleted = false,
                            StatusId = new Guid("858ac364-d94f-414c-bbea-a0f5b8679b3d"),
                            WarehouseId = new Guid("988a4201-8c55-42fc-b2a6-e08d1abe6693")
                        });
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Warehouses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f15b5cf4-6eb6-4e5a-b84f-297e16c206ba"),
                            AddressId = new Guid("36049406-10ba-499d-916b-063422046239"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 678, DateTimeKind.Utc).AddTicks(3743),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("988a4201-8c55-42fc-b2a6-e08d1abe6693"),
                            AddressId = new Guid("ac2fee3a-f76e-4d94-aa42-d85b4bb45299"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 678, DateTimeKind.Utc).AddTicks(4130),
                            IsDeleted = false
                        });
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

                    b.Property<bool>("IsDeleted")
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
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 677, DateTimeKind.Utc).AddTicks(9321),
                            IsDeleted = false,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = new Guid("df79ccb6-1f56-41da-9f8f-df2f92a468bb"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 677, DateTimeKind.Utc).AddTicks(9674),
                            IsDeleted = false,
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = new Guid("7aeb290e-3592-4128-a77a-1a6db6fd81f5"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 677, DateTimeKind.Utc).AddTicks(9682),
                            IsDeleted = false,
                            Name = "Medical"
                        },
                        new
                        {
                            Id = new Guid("72280df2-7d81-4ec6-936a-51e19aabf7ff"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 677, DateTimeKind.Utc).AddTicks(9682),
                            IsDeleted = false,
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

                    b.Property<bool>("IsDeleted")
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
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 676, DateTimeKind.Utc).AddTicks(2650),
                            IsDeleted = false,
                            Name = "Barcelona"
                        },
                        new
                        {
                            Id = new Guid("e422b2de-f54d-4a4e-9259-0f3f4033f93d"),
                            CountryId = new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 676, DateTimeKind.Utc).AddTicks(3683),
                            IsDeleted = false,
                            Name = "Berlin"
                        },
                        new
                        {
                            Id = new Guid("7fdbb1a0-9f76-4b63-aab4-901c61591336"),
                            CountryId = new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 676, DateTimeKind.Utc).AddTicks(3700),
                            IsDeleted = false,
                            Name = "Paris"
                        },
                        new
                        {
                            Id = new Guid("8bf95d78-e5ac-495d-ab67-14b60f644b70"),
                            CountryId = new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 676, DateTimeKind.Utc).AddTicks(3708),
                            IsDeleted = false,
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

                    b.Property<bool>("IsDeleted")
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
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 677, DateTimeKind.Utc).AddTicks(8048),
                            IsDeleted = false,
                            Name = "Spain"
                        },
                        new
                        {
                            Id = new Guid("afbcad66-1a0a-49f2-9e9c-2c61ded8ae08"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 677, DateTimeKind.Utc).AddTicks(8444),
                            IsDeleted = false,
                            Name = "Germany"
                        },
                        new
                        {
                            Id = new Guid("72ec653b-aeb1-42fc-bcd1-153f005b1cd4"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 677, DateTimeKind.Utc).AddTicks(8452),
                            IsDeleted = false,
                            Name = "France"
                        },
                        new
                        {
                            Id = new Guid("c4b3bb07-585f-412b-9f5f-f423928015d4"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 677, DateTimeKind.Utc).AddTicks(8461),
                            IsDeleted = false,
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

                    b.Property<bool>("IsDeleted")
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
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 678, DateTimeKind.Utc).AddTicks(405),
                            IsDeleted = false,
                            Name = "preparing"
                        },
                        new
                        {
                            Id = new Guid("858ac364-d94f-414c-bbea-a0f5b8679b3d"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 678, DateTimeKind.Utc).AddTicks(741),
                            IsDeleted = false,
                            Name = "on The Way"
                        },
                        new
                        {
                            Id = new Guid("84568d3c-04df-47c3-9ad8-216b1d664166"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 678, DateTimeKind.Utc).AddTicks(749),
                            IsDeleted = false,
                            Name = "completed"
                        },
                        new
                        {
                            Id = new Guid("b31754e2-82fc-4862-ad20-9331a87537eb"),
                            CreatedOn = new DateTime(2021, 4, 15, 15, 26, 59, 678, DateTimeKind.Utc).AddTicks(758),
                            IsDeleted = false,
                            Name = "preparing"
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
