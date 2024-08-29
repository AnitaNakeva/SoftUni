using HouseRenting.Infrastructure;
using HouseRenting.Models.Houses;
using HouseRenting.Services.Houses.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HouseRenting.Contracts
{
    public interface IHouseService
    {
        Task<IEnumerable<HouseIndexServiceModel>> LastThreeHouses();

        Task<IEnumerable<HouseCategoryServiceModel>> AllCategories();

        Task<bool> CategoryExists(int categoryId);

        Task<int> Create(string title, string address, string description, 
            string imageUrl, decimal price, int categoryId, int agentId);

        HouseQueryServiceModel All(string category = null,
            string serchTerm = null,
            HouseSorting sorting = HouseSorting.Newest,
            int currentPage = 1,
            int housesPerPage = 1);

        Task<IEnumerable<string>> AllCategoriesNames();

        Task<IEnumerable<HouseServiceModel>> AllHousesByAgentId(int agentId);

        Task<IEnumerable<HouseServiceModel>> AllHousesByUserId(string userId);

        Task<bool> Exists(int id);

        Task<HouseDetailsServiceModel> HouseDetailsBYId(int id);

        Task Edit(int houseiD, String title, string address,
            string description, string imageUrl, decimal price, int categoryId);

        Task<bool> HasAgentWithId(int houseId, string currentUserId);

        Task<int> GetHouseCategoryId(int houseId);

        Task Delete(int houseId);

        Task<bool> IsRented(int id);

        Task<bool> IsRentedByUserWithId(int houseId, string userId);

        Task Rent(int houseId, string userId);

        Task Leave(int houseId);
    }
}
