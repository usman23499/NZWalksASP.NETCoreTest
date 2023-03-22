using NZWalks.API.Models.Domian;

namespace NZWalks.API.Repositories
{
    public interface IUserRepository
    {
        Task<User> AuthenticateAsync(string username, string password);
    }
}
