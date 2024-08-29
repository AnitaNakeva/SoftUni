using HouseRenting.Contracts;
using HouseRenting.Data;
using HouseRenting.Data.Models;
using HouseRenting.Infrastructure;
using HouseRenting.Models.Houses;
using HouseRenting.Services.Agents.Models;
using HouseRenting.Services.Houses.Models;
using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Signing;
using System.ComponentModel.DataAnnotations;

namespace HouseRenting.Services
{
    public class HouseService : IHouseService
    {
        private readonly HouseRentingDbContext _data;

        public HouseService(HouseRentingDbContext data)
        {
            _data = data;
        }

        public HouseQueryServiceModel All(string category = null, string serchTerm = null,
            HouseSorting sorting = HouseSorting.Newest, int currentPage = 1, int housesPerPage = 1)
        {
            var housesQuery = _data.Houses.AsQueryable();

            if (!string.IsNullOrWhiteSpace(category))
            {
                housesQuery = _data.Houses
                    .Where(h => h.Category.Name == category);
            }

            if (!string.IsNullOrWhiteSpace(serchTerm))
            {
                housesQuery = housesQuery
                    .Where(h =>
                        h.Title.ToLower().Contains(serchTerm.ToLower()) ||
                        h.Address.ToLower().Contains(serchTerm.ToLower()) ||
                        h.Description.ToLower().Contains(serchTerm.ToLower()));
            }

            housesQuery = sorting switch
            {
                HouseSorting.Price => housesQuery
                .OrderBy(h => h.PricePerMonth),
                HouseSorting.NotRentedFirst => housesQuery
                .OrderBy(h => h.RenterId != null)
                .ThenByDescending(h => h.Id),
                _ => housesQuery.OrderByDescending(h => h.Id)
            };

            var houses = housesQuery
                .Skip((currentPage - 1) * housesPerPage)
                .Take(housesPerPage)
                .Select(h => new HouseServiceModel
                {
                    Id = h.Id,
                    Title = h.Title,
                    Address = h.Address,
                    ImageUrl = h.ImageUrl,
                    IsRented = h.RenterId != null,
                    PricePerMonth = h.PricePerMonth
                })
                .ToList();

            var totalHouses = housesQuery.Count();

            return new HouseQueryServiceModel()
            {
                TotalHousesCount = totalHouses,
                Houses = houses
            };
        }

        public async Task<IEnumerable<HouseCategoryServiceModel>> AllCategories()
        {
            return await _data
                .Categories
                .Select(c => new HouseCategoryServiceModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<string>> AllCategoriesNames()
        {
            return await _data
                .Categories
                .Select(c => c.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<IEnumerable<HouseServiceModel>> AllHousesByAgentId(int agentId)
        {
            var houses = await _data
                .Houses
                .Where(h => h.AgentId == agentId)
                .ToListAsync();

            return ProjectToModel(houses);
        }

        public async Task<IEnumerable<HouseServiceModel>> AllHousesByUserId(string userId)
        {
            var houses = await _data
               .Houses
               .Where(h => h.RenterId == userId)
               .ToListAsync();

            return ProjectToModel(houses);
        }

        private List<HouseServiceModel> ProjectToModel(List<House> houses)
        {
            var result = houses
                .Select(h => new HouseServiceModel()
                {
                    Id = h.Id,
                    Title = h.Title,
                    Address = h.Address,
                    ImageUrl = h.ImageUrl,
                    PricePerMonth = h.PricePerMonth,
                    IsRented = h.RenterId != null
                })
                .ToList();

            return result;
        }

        public async Task<bool> CategoryExists(int categoryId)
        {
            return await _data.Categories.AnyAsync(c => c.Id == categoryId);
        }

        public async Task<int> Create(string title, string address, string description, string imageUrl, decimal price, int categoryId, int agentId)
        {
            var house = new House()
            {
                Title = title,
                Address = address,
                Description = description,
                ImageUrl = imageUrl,
                PricePerMonth = price,
                CategoryId = categoryId,
                AgentId = agentId
            };

            await _data.Houses.AddAsync(house);
            await _data.SaveChangesAsync();

            return house.Id;
        }

        public async Task<IEnumerable<HouseIndexServiceModel>> LastThreeHouses()
        {
            return _data
                .Houses
                .OrderByDescending(x => x.Id)
                .Select(x => new HouseIndexServiceModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    ImageUrl = x.ImageUrl
                })
                .Take(3);
        }

        public async Task<bool> Exists(int id)
        {
            return await _data
                .Houses
                .AnyAsync(Houses => Houses.Id == id);
        }

        public async Task<HouseDetailsServiceModel> HouseDetailsBYId(int id)
        {
            return await _data
                .Houses
                .Where(h => h.Id == id)
                .Select(h => new HouseDetailsServiceModel()
                {
                    Id = h.Id,
                    Title = h.Title,
                    Address = h.Address,
                    Description = h.Description,
                    ImageUrl = h.ImageUrl,
                    PricePerMonth = h.PricePerMonth,
                    IsRented = h.RenterId != null,
                    Category = h.Category.Name,
                    Agent = new AgentServiceModel()
                    {
                        PhoneNumber = h.Agent.PhoneNumber,
                        Email = h.Agent.User.Email
                    }
                })
                .FirstOrDefaultAsync();
        }

        public async Task Edit(int houseiD, string title, string address, string description, string imageUrl, decimal price, int categoryId)
        {
            var house = _data.Houses.Find(houseiD);

            house.Title = title;
            house.Address = address;
            house.Description = description;
            house.ImageUrl = imageUrl;
            house.PricePerMonth = price;
            house.CategoryId = categoryId;

            await _data.SaveChangesAsync();
        }

        public async Task<bool> HasAgentWithId(int houseId, string currentUserId)
        {
            var house = await _data.Houses.FindAsync(houseId);

            if (house.AgentId == null)
            {
                return false;
            }

            var agent = await _data.Agents.FirstOrDefaultAsync(a => a.Id == house.AgentId);

            if (agent == null || agent.UserId != currentUserId)
            {
                return false;
            }

            return true;
        }

        public async Task<int> GetHouseCategoryId(int houseId)
        {
            House house = await _data.Houses.FindAsync(houseId);

            return house.CategoryId;
        }

        public async Task Delete(int houseId)
        {
            var house = await _data.Houses.FindAsync(houseId);

            _data.Remove(house);
            await _data.SaveChangesAsync();
        }

        public async Task<bool> IsRented(int id)
        {
            var house = await _data.Houses.FindAsync(id);

            var result = house.RenterId != null;

            return result;
        }

        public async Task<bool> IsRentedByUserWithId(int houseId, string userId)
        {
            var house = await _data.Houses.FindAsync(houseId);

            if(house == null)
            {
                return false;
            }

            if(house.RenterId != userId)
            {
                return false;
            }

            return true;
        }

        public async Task Rent(int houseId, string userId)
        {
            var house = await _data.Houses.FindAsync(houseId);

            house.RenterId = userId;

            var entry = _data.Entry(house);
            if (entry.State == EntityState.Detached)
            {
                _data.Attach(house);
                entry.State = EntityState.Modified;
            }


            await _data.SaveChangesAsync();
        }

        public async Task Leave(int houseId)
        {
            var house = await _data.Houses.FindAsync(houseId);

            house.RenterId = null;

            await _data.SaveChangesAsync();
        }
    }
}
