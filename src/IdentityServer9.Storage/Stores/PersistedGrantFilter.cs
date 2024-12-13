﻿namespace IdentityServer9.Stores
{
    /// <summary>
    /// Represents a filter used when accessing the persisted grants store. 
    /// Setting multiple properties is interpreted as a logical 'AND' to further filter the query.
    /// At least one value must be supplied.
    /// </summary>
    public class PersistedGrantFilter
    {
        /// <summary>
        /// Subject id of the user.
        /// </summary>
        public string SubjectId { get; set; } = null!;
        
        /// <summary>
        /// Session id used for the grant.
        /// </summary>
        public string SessionId { get; set; } = null!;

        /// <summary>
        /// Client id the grant was issued to.
        /// </summary>
        public string ClientId { get; set; } = null!;

        /// <summary>
        /// The type of grant.
        /// </summary>
        public string Type { get; set; } = null!;
    }
}