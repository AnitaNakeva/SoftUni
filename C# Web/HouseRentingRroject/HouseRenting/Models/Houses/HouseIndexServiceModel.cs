using HouseRenting.Contracts;

namespace HouseRenting.Models.Houses
{
    public class HouseIndexServiceModel : IHouseModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;
    }
}
