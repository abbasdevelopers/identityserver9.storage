namespace IdentityServer9.Models
{
    /// <summary>
    /// Models the common data of API and identity resources.
    /// </summary>
    public abstract class Resource
    {
        private string DebuggerDisplay => Name ?? $"{{{typeof(Resource)}}}";

        /// <summary>
        /// Indicates if this resource is enabled. Defaults to true.
        /// </summary>
        public bool Enabled { get; set; } = true;

        /// <summary>
        /// The unique name of the resource.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Display name of the resource.
        /// </summary>
        public string DisplayName { get; set; } = null!;

        /// <summary>
        /// Description of the resource.
        /// </summary>
        public string Description { get; set; } = null!;

        /// <summary>
        /// Specifies whether this scope is shown in the discovery document. Defaults to true.
        /// </summary>
        public bool ShowInDiscoveryDocument { get; set; } = true;

        /// <summary>
        /// List of associated user claims that should be included when this resource is requested.
        /// </summary>
        public ICollection<string> UserClaims { get; set; } = new HashSet<string>();

        /// <summary>
        /// Gets or sets the custom properties for the resource.
        /// </summary>
        /// <value>
        /// The properties.
        /// </value>
        public IDictionary<string, string> Properties { get; set; } = new Dictionary<string, string>();
    }
}