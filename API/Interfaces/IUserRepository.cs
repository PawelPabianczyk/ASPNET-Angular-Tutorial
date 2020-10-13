using System.Threading.Tasks;
using System.Collections.Generic;
using API.Entities;

namespace API.Interfaces
{
    public class IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
    }
}