#nullable enable

namespace DeepL
{
    public partial interface IAdminApiClient
    {
        /// <summary>
        /// Create a developer key as an admin
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.ApiKey> AdminCreateDeveloperKeyAsync(

            global::DeepL.AdminCreateDeveloperKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a developer key as an admin
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.ApiKey>> AdminCreateDeveloperKeyAsResponseAsync(

            global::DeepL.AdminCreateDeveloperKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a developer key as an admin
        /// </summary>
        /// <param name="label">
        /// API key label. The default value is `DeepL API Key`.<br/>
        /// Example: developer key prod
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.ApiKey> AdminCreateDeveloperKeyAsync(
            string? label = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}