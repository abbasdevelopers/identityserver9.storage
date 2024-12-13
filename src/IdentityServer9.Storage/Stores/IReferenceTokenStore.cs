﻿using IdentityServer9.Models;

namespace IdentityServer9.Stores
{
    /// <summary>
    /// Interface for reference token storage
    /// </summary>
    public interface IReferenceTokenStore
    {
        /// <summary>
        /// Stores the reference token.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        Task<string> StoreReferenceTokenAsync(Token token);

        /// <summary>
        /// Gets the reference token.
        /// </summary>
        /// <param name="handle">The handle.</param>
        /// <returns></returns>
        Task<Token> GetReferenceTokenAsync(string handle);

        /// <summary>
        /// Removes the reference token.
        /// </summary>
        /// <param name="handle">The handle.</param>
        /// <returns></returns>
        Task RemoveReferenceTokenAsync(string handle);

        /// <summary>
        /// Removes the reference tokens.
        /// </summary>
        /// <param name="subjectId">The subject identifier.</param>
        /// <param name="clientId">The client identifier.</param>
        /// <returns></returns>
        Task RemoveReferenceTokensAsync(string subjectId, string clientId);
    }
}