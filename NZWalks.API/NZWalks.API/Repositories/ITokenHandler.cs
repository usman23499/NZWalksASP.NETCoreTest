using NZWalks.API.Models.Domian;

namespace NZWalks.API.Repositories
{
    public interface ITokenHandler
    {
        Task<string> CreateTokenAsync(User user);
    }
}
