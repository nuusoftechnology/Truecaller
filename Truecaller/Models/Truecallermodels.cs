namespace Truecaller.Models
{
    public class Truecallermodels
    {
        public string phoneNumbers { get; set; } = default!;
        public Addresses addresses { get; set; } = new();
        public string aboutMe { get; set; } = default!;
        public string jobTitle { get; set; } = default!;
        public string companyName { get; set; } = default!;
        public bool isActive { get; set; }
        public string gender { get; set; } = default!;
        public string createdTime { get; set; } = default!;
        public OnlineIdentity onlineIdentities { get; set; } = new();
        public string type { get; set; } = default!;
        public string id { get; set; } = default!;
        public string userId { get; set; } = default!;
        public List<Badges> badges { get; set; } = new();
        public Name name { get; set; } = new();
    }
    public class Addresses
    {
        public string countryCode { get; set; } = default!;
        public string city { get; set; } = default!;
        public string street { get; set; } = default!;
        public string zipcode { get; set; } = default!;
    }
    public class OnlineIdentity
    {
        public string url { get; set; } = default!;
        public string email { get; set; } = default!;
        public string facebookId { get; set; } = default!;
    }
    public class Badges
    {
        public List<string> badges { get; set; } = new();
    }
    public class Name
    {
        public string last { get; set; } = default!;
        public string first { get; set; } = default!;
    }
}
