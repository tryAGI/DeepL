#nullable enable

namespace DeepL
{
    public partial interface IManageStyleProfilesClient
    {
        /// <summary>
        /// Delete a style profile<br/>
        /// Delete a style profile. Only the account that owns a style profile can delete it. A style profile<br/>
        /// that was shared with your account returns `404 Not Found`.<br/>
        /// The glossaries, style rule lists and translation memories the style profile links are not deleted.<br/>
        /// Translation requests that pass the deleted `style_profile_id` fail after this call, so update your<br/>
        /// integration before deleting.<br/>
        /// Requires an API key with the `style_profiles:write` scope.
        /// </summary>
        /// <param name="styleProfileId">
        /// A unique ID assigned to a style profile.<br/>
        /// Example: 3f1c9d0e-7a24-4b58-9c31-8f0e5d2a1b47
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteStyleProfileAsync(
            global::System.Guid styleProfileId,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a style profile<br/>
        /// Delete a style profile. Only the account that owns a style profile can delete it. A style profile<br/>
        /// that was shared with your account returns `404 Not Found`.<br/>
        /// The glossaries, style rule lists and translation memories the style profile links are not deleted.<br/>
        /// Translation requests that pass the deleted `style_profile_id` fail after this call, so update your<br/>
        /// integration before deleting.<br/>
        /// Requires an API key with the `style_profiles:write` scope.
        /// </summary>
        /// <param name="styleProfileId">
        /// A unique ID assigned to a style profile.<br/>
        /// Example: 3f1c9d0e-7a24-4b58-9c31-8f0e5d2a1b47
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse> DeleteStyleProfileAsResponseAsync(
            global::System.Guid styleProfileId,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}