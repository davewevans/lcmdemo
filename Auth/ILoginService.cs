using System.Threading.Tasks;
using LCMSMSPWA.Models;

namespace LCMSMSPWA.Auth
{
    public interface ILoginService
    {
        Task Login(UserToken userToken);
        Task Logout();
        Task TryRenewToken();
    }
}