using HouseRenting.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using static HouseRenting.Data.DataConstants;
using static Humanizer.In;
using Category = HouseRenting.Data.Models.Category;
using House = HouseRenting.Data.Models.House;

namespace HouseRenting.Data
{
    public class HouseRentingDbContext : IdentityDbContext<Models.ApplicationUser>
    {
       

        public HouseRentingDbContext(DbContextOptions<HouseRentingDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<House>()
                .HasOne(h => h.Category)
                .WithMany(c => c.Houses)
                .HasForeignKey(h => h.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<House>()
                .HasOne(h => h.Agent)
                .WithMany()
                .HasForeignKey(h => h.AgentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<House>()
                .Property(h => h.PricePerMonth)
                .HasColumnType("decimal(18,2)");

            SeedUsers();
            modelBuilder.Entity<Models.ApplicationUser>()
                .HasData(AgentUser, GuestUser, AdminUser);

            SeedAgent();
            modelBuilder.Entity<Models.Agent>()
                .HasData(Agent, AdminAgent);

            SeedCategories();
            modelBuilder.Entity<Category>()
                .HasData(CottageCategory,
                SingleCategory,
                DuplexCategory);

            SeedHouses();
            modelBuilder.Entity<House>()
                .HasData(FirstHouse,
                SecondHouse,
                ThirdHouse);

            base.OnModelCreating(modelBuilder);
        }

        private Models.ApplicationUser AdminUser { get; set; }

        private Models.Agent AdminAgent { get; set; }

        public DbSet<House> Houses { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Models.Agent> Agents { get; set; } = null!;

        private Models.ApplicationUser AgentUser { get; set;}

        private Models.ApplicationUser GuestUser { get; set;}

        private Models.Agent Agent { get; set;}

        private Category CottageCategory { get; set; }

        private Category SingleCategory { get; set; }

        private Category DuplexCategory { get; set; }

        private House FirstHouse { get; set; }

        private House SecondHouse { get; set; }

        private House ThirdHouse { get; set; }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<Models.ApplicationUser>();

            AgentUser = new Models.ApplicationUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "agent@mail.com",
                NormalizedUserName = "agent@mail.com",
                Email = "agent@mail.com",
                NormalizedEmail = "agent@mail.com",
                FirstName = "Linda",
                LastName = "Michaels"
            };

            AgentUser.PasswordHash =
                hasher.HashPassword(AgentUser, "agent123");

            GuestUser = new Models.ApplicationUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com",
                FirstName = "Teodor",
                LastName = "Lesly"
            };

            GuestUser.PasswordHash =
                hasher.HashPassword(AgentUser, "guest123");

            AdminUser = new Models.ApplicationUser()
            {
                Id = "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                Email = "adminmail@abv.bg",
                NormalizedEmail = "adminmail@abv.bg",
                UserName = "adminmail@abv.bg",
                NormalizedUserName = "adminmail@abv.bg",
                FirstName = "Great",
                LastName = "Admin"
            };
            AdminUser.PasswordHash = hasher.HashPassword(AgentUser, "admin123");
        }

        private void SeedAgent()
        {
            Agent = new Models.Agent()
            {
                Id = 1,
                PhoneNumber = "+359888888888",
                UserId = AgentUser.Id
            };

            AdminAgent = new Models.Agent()
            {
                Id = 4,
                PhoneNumber = "+359123456789",
                UserId = AdminUser.Id
            };

        }

        private void SeedCategories()
        {
            CottageCategory = new Category()
            {
                Id = 1,
                Name = "Cottage"
            };
            SingleCategory = new Category()
            {
                Id = 2,
                Name = "Single-Family"
            };
            DuplexCategory = new Category()
            {
                Id = 3,
                Name = "Duplex"
            };
        }

        private void SeedHouses()
        {
            FirstHouse = new House()
            {
                Id = 1,
                Title = "Big House Marina",
                Address = "North London, UK (near the border)",
                Description = "A big house for your whole family. Don't miss to buy a house with three bedrooms.",
                ImageUrl = "https://www.luxury-architecture.net/wpcontent/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg",
                PricePerMonth = 2100.00M,
                CategoryId = DuplexCategory.Id,
                AgentId = Agent.Id,
                RenterId = GuestUser.Id
            };

            SecondHouse = new House()
            {
                Id = 2,
                Title = "Family House Comfort",
                Address = "Near the Sea Garden in Burgas, Bulgaria",
                Description = "It has the best comfort you will ever ask for. With two bedrooms, it is great for your family.",
                ImageUrl =
                "https://cf.bstatic.com/xdata/images/hotel/max1024x768/179489660.jpg?k=2029f6d9589b49c95dcc9503a265e292c2cdfcb5277487a0050397c3f8dd545a & o = &hp = 1",
                PricePerMonth = 1200.00M,
                CategoryId = SingleCategory.Id,
                AgentId = Agent.Id
             };

            ThirdHouse = new House()
            {
                Id = 3,
                Title = "Grand House",
                Address = "Boyana Neighbourhood, Sofia, Bulgaria",
                Description = "This luxurious house is everything you will need. It is just excellent.",
                ImageUrl = "https://i.pinimg.com/originals/a6/f5/85/a6f5850a77633c56e4e4ac4f867e3c00.jpg",
                PricePerMonth = 2000.00M,
                CategoryId = SingleCategory.Id,
                AgentId = Agent.Id
            };

        }

    }
}