using LCMSMSPWA.Repository;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using MatBlazor;
using Tewr.Blazor.FileReader;
using Syncfusion.Blazor;
using LCMSMSPWA.Adaptors;
using LCMSMSPWA.Auth;
using LCMSMSPWA.Helpers;
using LCMSMSPWA.Models;
using LCMSMSPWA.Services;
using Microsoft.AspNetCore.Components.Authorization;
// using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
// using Microsoft.Extensions.Configuration;
using Syncfusion.Blazor.Diagrams;

namespace LCMSMSPWA
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // Syncfusion -- register community service license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzAxNTM2QDMxMzgyZTMyMmUzMFU3VlM3WlV6ZEtTazYyd0YxTVlNamRHTThxbG5qR2cxTk0vaFF6YTE4ZlU9");

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            var baseUrl = builder.Configuration["useLocalHost"].Equals("true")
                ? new Uri(builder.Configuration["localHostUrl"])
                : new Uri(builder.Configuration["apiUrl"]);

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = baseUrl });
            
            // builder.Services.AddHttpClient<HttpClientWithToken>(client =>
            //     {
            //         client.BaseAddress = baseUrl;
            //     })
            //     .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();
            //
            // builder.Services.AddHttpClient<HttpClientWithoutToken>(client =>
            //     {
            //         client.BaseAddress = baseUrl;
            //     });
            //
            //
            // TODO Use IHttpClientFactory instead??
            //
            // builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("LCMSMSWebApi"));
            
            // configure HttpClient
            // builder.Services.AddScoped(sp =>
            // {
            //     var baseUrl = builder.Configuration["useLocalHost"].Equals("true") 
            //         ? new Uri(builder.Configuration["localHostUrl"]) : new Uri(builder.Configuration["apiUrl"]);
            //     return new HttpClient { BaseAddress = baseUrl };
            // });
            
            
            ConfigureServices(builder.Services);

            var host = builder.Build();

            await host.RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            //  services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IHttpService, HttpService>();
            services.AddScoped<ILocalStorageService, LocalStorageService>();
            services.AddScoped<IDashboardRepository, DashboardRepository>(); 
            services.AddScoped<IOrphanRepository, OrphanRepository>();
            services.AddScoped<IGuardianRepository, GuardianRepository>();
            services.AddScoped<ISponsorRepository, SponsorRepository>();
            services.AddScoped<IPictureRepository, PictureRepository>();
            services.AddScoped<INarrationRepository, NarrationRepository>();
            services.AddScoped<IAcademicRepository, AcademicRepository>();
            services.AddScoped<IOrphanSponsorRepository, OrphanSponsorRepository>();
            services.AddScoped<IAccountsRepository, AccountsRepository>();
            services.AddScoped<IPDFRepository, PDFRepository>();
            
            // Authentication and Authorization
            services.AddAuthorizationCore();
            
            services.AddScoped<JWTAuthenticationStateProvider>();
            services.AddScoped<AuthenticationStateProvider, JWTAuthenticationStateProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationStateProvider>()
            );
            services.AddScoped<ILoginService, JWTAuthenticationStateProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationStateProvider>()
            );
            
            services.AddScoped<TokenRenewer>();

            // services.AddApiAuthorization();
            
            // Syncfusion
            services.AddSyncfusionBlazor();   

            // Syncfusion -- may be needed for offline ???
            // builder.Services.AddSyncfusionBlazor(true);   

            
            services.AddMatToaster(config =>
            {
                config.Position = MatToastPosition.BottomRight;
                config.PreventDuplicates = true;
                config.NewestOnTop = true;
                config.ShowCloseButton = true;
                config.MaximumOpacity = 95;
                config.VisibleStateDuration = 3000;
            });

            services.AddFileReaderService(o => o.UseWasmSharedBuffer = true);
        }
    }
}
