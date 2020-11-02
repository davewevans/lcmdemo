using System;
using System.Threading.Tasks;
using LCMSMSPWA.Models;
using LCMSMSPWA.Services;

namespace LCMSMSPWA.Repository
{
    public class AccountsRepository : IAccountsRepository
    {
        private readonly IHttpService httpService;

        public AccountsRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        
        public async Task<UserToken> Login(UserInfo userInfo)
        {
            string url = $"{ httpService.BaseAddress }/accounts/login";
            
            var httpResponse = await httpService.Post<UserInfo, UserToken>(url, userInfo);

            if (!httpResponse.Success)
            {
                throw new ApplicationException(await httpResponse.GetBody());
            }

            return httpResponse.Response;
            
        }

        public async Task<UserToken> Register(UserInfo userInfo)
        {
            string url = $"{ httpService.BaseAddress }/accounts/create";
            var httpResponse = await httpService.Post<UserInfo, UserToken>(url, userInfo);
            
            if (!httpResponse.Success)
            {
                throw new ApplicationException(await httpResponse.GetBody());
            }

            return httpResponse.Response;
        }

        public async Task<UserToken> RenewToken()
        {
            string url = $"{ httpService.BaseAddress }/accounts/RenewToken";
            var response = await httpService.Get<UserToken>(url);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }
    }
}