using System.Threading.Tasks;
using LCMSMSPWA.Models;

namespace LCMSMSPWA.Repository
{
    public interface IAccountsRepository
    {
        Task<UserToken> Login(UserInfo userInfo);
        Task<UserToken> Register(UserInfo userInfo);
        Task<UserToken> RenewToken();
    }
}