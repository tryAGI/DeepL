#nullable enable

namespace DeepL
{
    public partial interface IManageStyleProfilesClient
    {
        /// <summary>
        /// List style profiles<br/>
        /// Retrieve a list of style profiles available to the authenticated account, newest first.<br/>
        /// The list includes style profiles that have been shared with the account.<br/>
        /// Requires an API key with the `style_profiles:read` scope.
        /// </summary>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.ListStyleProfilesResponse> ListStyleProfilesAsync(
            int? page = default,
            int? pageSize = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List style profiles<br/>
        /// Retrieve a list of style profiles available to the authenticated account, newest first.<br/>
        /// The list includes style profiles that have been shared with the account.<br/>
        /// Requires an API key with the `style_profiles:read` scope.
        /// </summary>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.ListStyleProfilesResponse>> ListStyleProfilesAsResponseAsync(
            int? page = default,
            int? pageSize = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}