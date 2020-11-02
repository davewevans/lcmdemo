using System;
using System.Timers;

namespace LCMSMSPWA.Auth
{
    public class TokenRenewer
    {
        public TokenRenewer(ILoginService loginService)
        {
            this.loginService = loginService;
        }

        Timer timer;
        private readonly ILoginService loginService;

        public void Initiate()
        {
            timer = new Timer();
            timer.Interval = 1000 * 60 * 60; // 4 minutes
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("timer elapsed");
            loginService.TryRenewToken();
        }

        public void Dispose()
        {
            timer?.Dispose();
        }
    }
}