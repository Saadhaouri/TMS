using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportManagement.Entities;

namespace TransportManagement.DbContexts
{
    public class TransportDbContext : IdentityDbContext<AppIdentityUser, AppIdentityRole, string>
    {
        public TransportDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<VehicleBrand> VehicleBrands { get; set; }
        public DbSet<RouteInformation> RouteInformations { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<DayJob> DayJobs { get; set; }
        public DbSet<TransportInformation> TransportInformations { get; set; }
        public DbSet<EditTransportInformation> EditTransportInformations { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Vehicle>()
                    .HasIndex(v => v.LicensePlate)
                    .IsUnique();
            builder.Entity<EditTransportInformation>()
                    .HasOne(t => t.TransportInfo)
                    .WithMany(e => e.ListEdit)
                    .OnDelete(DeleteBehavior.SetNull);

            //seed user administrator account
            builder.Entity<AppIdentityRole>().HasData(new List<AppIdentityRole>
            {
                new AppIdentityRole()
                {
                    Id = "8dd36636-b4d8-4010-8594-caebfbe55991",
                    Name = "Quản trị viên hệ thống",
                    NormalizedName = "QUẢN TRỊ VIÊN HỆ THỐNG",
                    IsActive = true,
                    RolePriority = 1
                }
            });

            var hasher = new PasswordHasher<AppIdentityUser>();

            builder.Entity<AppIdentityUser>().HasData(
                new AppIdentityUser
                {
                    Id = "84572bc3-25fc-4ef8-9056-67c4da04069b",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    FirstName = "Administrator",
                    LastName = "System",
                    Avatar = "facb3595-8562-4556-8f49-10b561de361d.png",
                    IsActive = true,
                    PasswordHash = hasher.HashPassword(null, "Lovelykid1@"),
                    IsAvailable = true,
                    PhoneNumber = "0911345992",
                    PhoneNumberConfirmed = true
                });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "8dd36636-b4d8-4010-8594-caebfbe55991",
                    UserId = "84572bc3-25fc-4ef8-9056-67c4da04069b"
                }
                );
             // Add  User Driver Account 

            builder.Entity<AppIdentityRole>().HasData(new List<AppIdentityRole>
            {
                new AppIdentityRole()
                {
                    Id = "277D668B-264A-433E-9EEB-867C02C6D48D",
                    Name = "Lái xe",
                    NormalizedName = "Lái xe",
                    IsActive = true,
                    RolePriority = 2
                }
            });

            var hashe = new PasswordHasher<AppIdentityUser>();

            builder.Entity<AppIdentityUser>().HasData(
                new AppIdentityUser
                {
                    Id = "6ba7b810-9dad-11d1-80b4-00c04fd430c8}",
                    UserName = "DRIVER",
                    NormalizedUserName = "Driver",
                    FirstName = "Driver",
                    LastName = "Cheffeur",
                    Avatar = "facb3595-8562-4556-8f49-10b561de361d.png",
                    IsActive = true,
                    PasswordHash = hasher.HashPassword(null, "LoveSaad@"),
                    IsAvailable = true,
                    PhoneNumber = "0610345992",
                    PhoneNumberConfirmed = true
                });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "277D668B-264A-433E-9EEB-867C02C6D48D",
                    UserId = "6ba7b810-9dad-11d1-80b4-00c04fd430c8}"
                }
                ); 

            // New Account 
            builder.Entity<AppIdentityRole>().HasData(new List<AppIdentityRole>
            {
                new AppIdentityRole()
                {
                    Id = "2AA676BC-5BB8-4353-9A62-ABF7533CF2A0",
                    Name = "Saad",
                    NormalizedName = "SysAdmin",
                    IsActive = true,
                    RolePriority = 3
                }
            });

            var Hashe = new PasswordHasher<AppIdentityUser>();

            builder.Entity<AppIdentityUser>().HasData(
                new AppIdentityUser
                {
                    Id = "3F634FF4-4FC5-4387-86DC-AC8E42FBB41A",
                    UserName = "Haouri",
                    NormalizedUserName = "Karim",
                    FirstName = "Saad ",
                    LastName = "Haouri",
                    Avatar = "download (1).jpg",
                    IsActive = true,
                    PasswordHash = hasher.HashPassword(null, "LoveCR7@"),
                    IsAvailable = true,
                    PhoneNumber = "0766444205",
                    PhoneNumberConfirmed = true
                });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "276D668B-264A-433E-9EEB-867C02C6D48D",
                    UserId = "7ba7b810-5dad-11d1-81b4-80c04fd430r8"
                }
                );

        }
    }
}
