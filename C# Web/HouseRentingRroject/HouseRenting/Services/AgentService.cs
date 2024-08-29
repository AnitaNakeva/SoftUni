using HouseRenting.Contracts;
using HouseRenting.Data;
using HouseRenting.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRenting.Services
{
    public class AgentService : IAgentService
    {
        private readonly HouseRentingDbContext _data;

        public AgentService(HouseRentingDbContext data)
        {
            _data = data;
        }

        public async Task Create(string userId, string phoneNumber)
        {
            var agent = new Agent()
            {
                UserId = userId,
                PhoneNumber = phoneNumber
            };

            await _data.Agents.AddAsync(agent);
            await _data.SaveChangesAsync();
        }

        public async Task<bool> ExistsByid(string userId)
        {
            return await _data.Agents.AnyAsync(a => a.UserId == userId);
        }

        public async Task<int> GetAgentId(string userId)
        {
            var agent = await _data.Agents.FirstOrDefaultAsync(a => a.UserId == userId);

            if (agent == null)
            {
                throw new InvalidOperationException("Agent not found.");
            }

            return agent.Id;
        }

        public async Task<bool> UserHasRents(string userId)
        {
            return await _data.Houses.AnyAsync(h => h.RenterId == userId);
        }

        public async Task<bool> UserWithPhoneNumberExists(string phoneNumber)
        {
            return await _data.Agents.AnyAsync(a => a.PhoneNumber == phoneNumber);
        }
    }
}
