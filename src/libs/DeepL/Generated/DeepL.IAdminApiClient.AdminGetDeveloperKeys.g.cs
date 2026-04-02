#nullable enable

namespace DeepL
{
    public partial interface IAdminApiClient
    {
        /// <summary>
        /// Get all developer keys as an admin
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::DeepL.ApiKey>> AdminGetDeveloperKeysAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all developer keys as an admin
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::DeepL.ApiKey>>> AdminGetDeveloperKeysAsResponseAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}