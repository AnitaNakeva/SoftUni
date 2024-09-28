namespace HouseRenting.Contracts
{
    public interface IApplicationUserService
    {
        Task<string> UserFullName(string userId);
    }
}
