﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransportManagement.DbContexts;

namespace TransportManagement.Migrations
{
    [DbContext(typeof(TransportDbContext))]
    [Migration("20230512221801_user")]
    partial class user
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.HasData(
                        new
                        {
                            UserId = "84572bc3-25fc-4ef8-9056-67c4da04069b",
                            RoleId = "8dd36636-b4d8-4010-8594-caebfbe55991"
                        },
                        new
                        {
                            UserId = "6ba7b810-9dad-11d1-80b4-00c04fd430c8}",
                            RoleId = "277D668B-264A-433E-9EEB-867C02C6D48D"
                        },
                        new
                        {
                            UserId = "7ba7b810-5dad-11d1-81b4-80c04fd430r8",
                            RoleId = "276D668B-264A-433E-9EEB-867C02C6D48D"
                        });
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

            modelBuilder.Entity("TransportManagement.Entities.AppIdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<byte>("RolePriority")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "8dd36636-b4d8-4010-8594-caebfbe55991",
                            ConcurrencyStamp = "7873841e-d09b-4a0c-a617-05dab2d864c1",
                            IsActive = true,
                            Name = "Quản trị viên hệ thống",
                            NormalizedName = "QUẢN TRỊ VIÊN HỆ THỐNG",
                            RolePriority = (byte)1
                        },
                        new
                        {
                            Id = "277D668B-264A-433E-9EEB-867C02C6D48D",
                            ConcurrencyStamp = "bceb558b-f57f-49e6-80ab-613ba2298d3e",
                            IsActive = true,
                            Name = "Lái xe",
                            NormalizedName = "Lái xe",
                            RolePriority = (byte)2
                        },
                        new
                        {
                            Id = "276D668B-264A-433E-9EEB-867C02C6D48D",
                            ConcurrencyStamp = "1788d30a-6fb7-4bc2-92e5-dd1ccb768a59",
                            IsActive = true,
                            Name = "Admin",
                            NormalizedName = "Admin",
                            RolePriority = (byte)2
                        });
                });

            modelBuilder.Entity("TransportManagement.Entities.AppIdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("RolePriority")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "84572bc3-25fc-4ef8-9056-67c4da04069b",
                            AccessFailedCount = 0,
                            Avatar = "facb3595-8562-4556-8f49-10b561de361d.png",
                            ConcurrencyStamp = "d503b679-bef5-4119-b6fb-f7cc5903ce7c",
                            EmailConfirmed = false,
                            FirstName = "Administrator",
                            IsActive = true,
                            IsAvailable = true,
                            LastName = "System",
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEOnlLiIwsl7psKfwt6JaDj/hyWps4H/nD10udODOty7vRJvH6otCU3RRU8HSciOZSw==",
                            PhoneNumber = "0911345992",
                            PhoneNumberConfirmed = true,
                            RolePriority = 0,
                            SecurityStamp = "19b1c510-0db5-4d86-9ada-cbd835f9e38c",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "6ba7b810-9dad-11d1-80b4-00c04fd430c8}",
                            AccessFailedCount = 0,
                            Avatar = "facb3595-8562-4556-8f49-10b561de361d.png",
                            ConcurrencyStamp = "53e6566a-e700-448d-af71-a5e0d7928b1a",
                            EmailConfirmed = false,
                            FirstName = "Driver",
                            IsActive = true,
                            IsAvailable = true,
                            LastName = "Cheffeur",
                            LockoutEnabled = false,
                            NormalizedUserName = "Driver",
                            PasswordHash = "AQAAAAEAACcQAAAAEAvm8OkxTbxE4jI1KrlBQVAUiCLbc4YGdS86cHIEOmf7QBx2KWTIgIMVjmxgEqdqRw==",
                            PhoneNumber = "0610345992",
                            PhoneNumberConfirmed = true,
                            RolePriority = 0,
                            SecurityStamp = "b93e6e1a-acb5-422c-969e-4dd0566cfe10",
                            TwoFactorEnabled = false,
                            UserName = "DRIVER"
                        },
                        new
                        {
                            Id = "7ba7b810-5dad-11d1-81b4-80c04fd430r8",
                            AccessFailedCount = 0,
                            Avatar = "download (1).jpg",
                            ConcurrencyStamp = "e3fd6026-96ee-4196-90d8-c4bd182f2225",
                            EmailConfirmed = false,
                            FirstName = "Saad ",
                            IsActive = true,
                            IsAvailable = true,
                            LastName = "Haouri",
                            LockoutEnabled = false,
                            NormalizedUserName = "Admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEK0MyWkBAmuDKmgCRPeI8uYbGnuLaAQ0RcxYH9S1PMQ74qcSzR/kXDWxJLyQhp+EMQ==",
                            PhoneNumber = "0610345992",
                            PhoneNumberConfirmed = true,
                            RolePriority = 0,
                            SecurityStamp = "890b9b5e-1fbc-428d-a57d-ad04436e195e",
                            TwoFactorEnabled = false,
                            UserName = "Haouri"
                        });
                });

            modelBuilder.Entity("TransportManagement.Entities.DayJob", b =>
                {
                    b.Property<string>("DayJobId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Date")
                        .HasColumnType("float");

                    b.Property<string>("DriverId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DayJobId");

                    b.HasIndex("DriverId");

                    b.ToTable("DayJobs");
                });

            modelBuilder.Entity("TransportManagement.Entities.EditTransportInformation", b =>
                {
                    b.Property<string>("EditId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("DateEditLocal")
                        .HasColumnType("float");

                    b.Property<double>("DateEditUTC")
                        .HasColumnType("float");

                    b.Property<string>("EditContent")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("TimeZone")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("TransportId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserEditId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EditId");

                    b.HasIndex("TransportId");

                    b.HasIndex("UserEditId");

                    b.ToTable("EditTransportInformations");
                });

            modelBuilder.Entity("TransportManagement.Entities.Fuel", b =>
                {
                    b.Property<int>("FuelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FuelName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("FuelPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FuelId");

                    b.ToTable("Fuels");
                });

            modelBuilder.Entity("TransportManagement.Entities.Location", b =>
                {
                    b.Property<string>("LocationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("TransportManagement.Entities.RouteInformation", b =>
                {
                    b.Property<string>("RouteId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ArrivalPlace")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ArrivalPlaceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DeparturePlace")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DeparturePlaceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.HasKey("RouteId");

                    b.HasIndex("ArrivalPlaceId");

                    b.HasIndex("DeparturePlaceId");

                    b.ToTable("RouteInformations");
                });

            modelBuilder.Entity("TransportManagement.Entities.TransportInformation", b =>
                {
                    b.Property<string>("TransportId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("AdvanceMoney")
                        .HasColumnType("decimal(18,0)");

                    b.Property<decimal>("CargoTonnage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CargoTypes")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<double>("DateCompletedLocal")
                        .HasColumnType("float");

                    b.Property<double>("DateCompletedUTC")
                        .HasColumnType("float");

                    b.Property<double>("DateStartLocal")
                        .HasColumnType("float");

                    b.Property<double>("DateStartUTC")
                        .HasColumnType("float");

                    b.Property<string>("DayJobId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsCancel")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ReasonCancel")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("ReturnOfAdvances")
                        .HasColumnType("decimal(18,0)");

                    b.Property<string>("RouteId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TimeZone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserCreateId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("TransportId");

                    b.HasIndex("DayJobId");

                    b.HasIndex("RouteId");

                    b.HasIndex("UserCreateId");

                    b.HasIndex("VehicleId");

                    b.ToTable("TransportInformations");
                });

            modelBuilder.Entity("TransportManagement.Entities.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("FuelConsumptionPerTone")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FuelId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasMaxLength(10)
                        .HasColumnType("bit");

                    b.Property<bool>("IsInUse")
                        .HasColumnType("bit");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Specifications")
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<string>("VehicleBrandId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("VehicleName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("VehiclePayload")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("VehicleId");

                    b.HasIndex("FuelId");

                    b.HasIndex("LicensePlate")
                        .IsUnique();

                    b.HasIndex("VehicleBrandId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("TransportManagement.Entities.VehicleBrand", b =>
                {
                    b.Property<string>("BrandId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("BrandId");

                    b.ToTable("VehicleBrands");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("TransportManagement.Entities.AppIdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TransportManagement.Entities.AppIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TransportManagement.Entities.AppIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("TransportManagement.Entities.AppIdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportManagement.Entities.AppIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TransportManagement.Entities.AppIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TransportManagement.Entities.DayJob", b =>
                {
                    b.HasOne("TransportManagement.Entities.AppIdentityUser", "Driver")
                        .WithMany("DayJobs")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("TransportManagement.Entities.EditTransportInformation", b =>
                {
                    b.HasOne("TransportManagement.Entities.TransportInformation", "TransportInfo")
                        .WithMany("ListEdit")
                        .HasForeignKey("TransportId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("TransportManagement.Entities.AppIdentityUser", "UserEdit")
                        .WithMany("ListEdit")
                        .HasForeignKey("UserEditId");

                    b.Navigation("TransportInfo");

                    b.Navigation("UserEdit");
                });

            modelBuilder.Entity("TransportManagement.Entities.RouteInformation", b =>
                {
                    b.HasOne("TransportManagement.Entities.Location", "Arrival")
                        .WithMany()
                        .HasForeignKey("ArrivalPlaceId");

                    b.HasOne("TransportManagement.Entities.Location", "Departure")
                        .WithMany()
                        .HasForeignKey("DeparturePlaceId");

                    b.Navigation("Arrival");

                    b.Navigation("Departure");
                });

            modelBuilder.Entity("TransportManagement.Entities.TransportInformation", b =>
                {
                    b.HasOne("TransportManagement.Entities.DayJob", "DayJob")
                        .WithMany("Transports")
                        .HasForeignKey("DayJobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportManagement.Entities.RouteInformation", "Route")
                        .WithMany("Transports")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportManagement.Entities.AppIdentityUser", "UserCreate")
                        .WithMany()
                        .HasForeignKey("UserCreateId");

                    b.HasOne("TransportManagement.Entities.Vehicle", "Vehicle")
                        .WithMany("Transports")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DayJob");

                    b.Navigation("Route");

                    b.Navigation("UserCreate");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("TransportManagement.Entities.Vehicle", b =>
                {
                    b.HasOne("TransportManagement.Entities.Fuel", "Fuel")
                        .WithMany()
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportManagement.Entities.VehicleBrand", "Brand")
                        .WithMany("Vehicles")
                        .HasForeignKey("VehicleBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Fuel");
                });

            modelBuilder.Entity("TransportManagement.Entities.AppIdentityUser", b =>
                {
                    b.Navigation("DayJobs");

                    b.Navigation("ListEdit");
                });

            modelBuilder.Entity("TransportManagement.Entities.DayJob", b =>
                {
                    b.Navigation("Transports");
                });

            modelBuilder.Entity("TransportManagement.Entities.RouteInformation", b =>
                {
                    b.Navigation("Transports");
                });

            modelBuilder.Entity("TransportManagement.Entities.TransportInformation", b =>
                {
                    b.Navigation("ListEdit");
                });

            modelBuilder.Entity("TransportManagement.Entities.Vehicle", b =>
                {
                    b.Navigation("Transports");
                });

            modelBuilder.Entity("TransportManagement.Entities.VehicleBrand", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
