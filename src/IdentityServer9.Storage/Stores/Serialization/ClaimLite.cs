namespace IdentityServer9.Stores.Serialization
{
    public class ClaimLite
    {
        public string Type { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string ValueType { get; set; } = null!;
    }
}