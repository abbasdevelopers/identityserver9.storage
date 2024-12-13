namespace IdentityServer9.Stores.Serialization
{
    public class ClaimsPrincipalLite
    {
        public string AuthenticationType { get; set; } = null!;
        public ClaimLite[] Claims { get; set; } = null!;
    }
}
