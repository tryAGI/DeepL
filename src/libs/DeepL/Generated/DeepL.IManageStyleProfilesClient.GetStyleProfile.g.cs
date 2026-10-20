#nullable enable

namespace DeepL
{
    public partial interface IManageStyleProfilesClient
    {
        /// <summary>
        /// Retrieve a style profile<br/>
        /// Retrieve a single style profile by its ID, including the components it links and its timestamps.<br/>
        /// Requires an API key with the `style_profiles:read` scope.
        /// </summary>
        /// <param name="styleProfileId">
        /// A unique ID assigned to a style profile.<br/>
        /// Example: 3f1c9d0e-7a24-4b58-9c31-8f0e5d2a1b47
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.StyleProfile> GetStyleProfileAsync(
            global::System.Guid styleProfileId,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a style profile<br/>
        /// Retrieve a single style profile by its ID, including the components it links and its timestamps.<br/>
        /// Requires an API key with the `style_profiles:read` scope.
        /// </summary>
        /// <param name="styleProfileId">
        /// A unique ID assigned to a style profile.<br/>
        /// Example: 3f1c9d0e-7a24-4b58-9c31-8f0e5d2a1b47
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.StyleProfile>> GetStyleProfileAsResponseAsync(
            global::System.Guid styleProfileId,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}