using HouseRenting.Services.Agents.Models;

namespace HouseRenting.Services.Houses.Models
{
    public class HouseDetailsServiceModel : HouseServiceModel
    {
        public string Description { get; set; } = null!;

        public string Category { get; set; } = null!;

        public AgentServiceModel Agent { get; set; } = null!;
    }
}
