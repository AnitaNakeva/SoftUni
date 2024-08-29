namespace HouseRenting.Contracts
{
    public interface IAgentService
    {
        Task<bool> ExistsByid(string userId);

        Task<bool> UserWithPhoneNumberExists(string phoneNumber);

        Task<bool> UserHasRents(string userId);

        Task Create(string userId, string phoneNumber);

        Task<int> GetAgentId(string UserId);
    }
}
