#nullable enable

namespace DeepL
{
    public partial interface IManageSpokenTermsClient
    {
        /// <summary>
        /// Delete a term list<br/>
        /// Delete a term list for a specific language from the Spoken Terms collection.
        /// </summary>
        /// <param name="spokenTermsId"></param>
        /// <param name="lang">
        /// Example: en
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteSpokenTermsListAsync(
            string spokenTermsId,
            string lang,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a term list<br/>
        /// Delete a term list for a specific language from the Spoken Terms collection.
        /// </summary>
        /// <param name="spokenTermsId"></param>
        /// <param name="lang">
        /// Example: en
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse> DeleteSpokenTermsListAsResponseAsync(
            string spokenTermsId,
            string lang,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}