using HouseRenting.Contracts;
using HouseRenting.Data;
using HouseRenting.Models.Statistic;

namespace HouseRenting.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly HouseRentingDbContext _data;

        public StatisticsService(HouseRentingDbContext data)
        {
            _data = data;
        }
        public StatisticServiceModel Total()
        {
            var totalHouses = _data.Houses.Count();
            var totalRents = _data
                .Houses
                .Where(h => h.RenterId != null)
                .Count();

            return new StatisticServiceModel
            {
                TotalHouses = totalHouses,
                TotalRents = totalRents
            };
        }
    }
}
