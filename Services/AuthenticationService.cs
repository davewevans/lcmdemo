
using LCMSMSPWA.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using System.Net.Http;
using LCMSMSPWA.Repository;

namespace LCMSMSPWA.Services
{
    public interface IAuthenticationService
    {
        User User { get; }
        Task Initialize();
        Task Login(string username, string password);
        Task Logout();
    }
    
    public class AuthenticationService : IAuthenticationService
    {
        private IHttpService httpService;
        private NavigationManager navigationManager;
        private ILocalStorageService localStorageService;
        private readonly HttpClient httpClient;

        public User User { get; private set; }

        public AuthenticationService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService
        ) {
            this.httpService = httpService;
            this.navigationManager = navigationManager;
            this.localStorageService = localStorageService;
        }

        public async Task Initialize()
        {
            User = await localStorageService.GetItem<User>("user");
        }

        public async Task Login(string username, string password)
        {
            string url = $"{ httpService.BaseAddress }/accounts/login";
            var userInfo = new UserInfo
            {
                Email = username,
                Password = password
            };
            User = await httpService.Post<UserInfo, User>(url, userInfo, includeToken:false);
            await localStorageService.SetItem("user", User);
        }

        public async Task Logout()
        {
            User = null;
            await localStorageService.RemoveItem("user");
            navigationManager.NavigateTo("login");
        }
    }
}