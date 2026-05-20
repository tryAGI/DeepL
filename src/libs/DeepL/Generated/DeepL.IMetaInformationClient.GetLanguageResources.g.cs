#nullable enable

namespace DeepL
{
    public partial interface IMetaInformationClient
    {
        /// <summary>
        /// Retrieve Language Resources<br/>
        /// Returns all DeepL API resources and the features they support.<br/>
        /// For each feature, the response indicates which languages must support it for the feature to be<br/>
        /// available — source only (`needs_source_support`), target only (`needs_target_support`), or both.<br/>
        /// This allows clients to determine feature availability for a language pair by checking the<br/>
        /// appropriate language's `features` object returned by `GET /v3/languages`.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::DeepL.GetLanguageResourcesResponseItem>> GetLanguageResourcesAsync(
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Language Resources<br/>
        /// Returns all DeepL API resources and the features they support.<br/>
        /// For each feature, the response indicates which languages must support it for the feature to be<br/>
        /// available — source only (`needs_source_support`), target only (`needs_target_support`), or both.<br/>
        /// This allows clients to determine feature availability for a language pair by checking the<br/>
        /// appropriate language's `features` object returned by `GET /v3/languages`.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::DeepL.GetLanguageResourcesResponseItem>>> GetLanguageResourcesAsResponseAsync(
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}