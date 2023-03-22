using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domian;

namespace NZWalks.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly NZWalksDBContext nZWalksDbContext;

        public UserRepository(NZWalksDBContext nZWalksDbContext)
        {
            this.nZWalksDbContext = nZWalksDbContext;
        }


        public async Task<User> AuthenticateAsync(string username, string password)
        {
            var user = await nZWalksDbContext.Users
                .FirstOrDefaultAsync(x => x.Username.ToLower() == username.ToLower() && x.Password == password);

            if (user == null)
            {
                return null;
            }

            var userRoles = await nZWalksDbContext.Users_Roles.Where(x => x.UserId == user.Id).ToListAsync();

            if (userRoles.Any())
            {
                user.Roles = new List<string>();
                foreach (var userRole in userRoles)
                {
                    var role = await nZWalksDbContext.Roles.FirstOrDefaultAsync(x => x.Id == userRole.RoleId);
                    if (role != null)
                    {
                        user.Roles.Add(role.Name);
                    }
                }
            }

            user.Password = null;
            return user;
        }
    }
}

