namespace LCMSMSPWA.Models
{
    public class AuthenticateResponse
    {
        public AuthenticateResponse(User user, string token)
        {
            UserId = user.UserID;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            JwtToken = token;
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string JwtToken { get; set; }
    }
}