#nullable enable

namespace DeepL
{
    public partial interface IManageSpokenTermsClient
    {
        /// <summary>
        /// Retrieve Spoken Terms entries<br/>
        /// Retrieve the actual terms for a specific language from a Spoken Terms collection.
        /// </summary>
        /// <param name="spokenTermsId"></param>
        /// <param name="lang">
        /// Example: en
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.SpokenTermsEntries> GetSpokenTermsEntriesAsync(
            string spokenTermsId,
            string lang,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Spoken Terms entries<br/>
        /// Retrieve the actual terms for a specific language from a Spoken Terms collection.
        /// </summary>
        /// <param name="spokenTermsId"></param>
        /// <param name="lang">
        /// Example: en
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.SpokenTermsEntries>> GetSpokenTermsEntriesAsResponseAsync(
            string spokenTermsId,
            string lang,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}