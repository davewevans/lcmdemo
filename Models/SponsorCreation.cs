namespace LCMSMSPWA.Models
{
    public class SponsorCreation
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        //[Email(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        //[Phone(ErrorMessage = "Invalid phone number.")]
        public string MainPhone { get; set; }
    }
}