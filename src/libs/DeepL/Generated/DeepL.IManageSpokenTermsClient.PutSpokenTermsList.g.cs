#nullable enable

namespace DeepL
{
    public partial interface IManageSpokenTermsClient
    {
        /// <summary>
        /// Replace or create a term list<br/>
        /// Replace an existing term list for a language, or create a new one if it doesn't exist.
        /// </summary>
        /// <param name="spokenTermsId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.SpokenTermsList> PutSpokenTermsListAsync(
            string spokenTermsId,

            global::DeepL.PutSpokenTermsListParameters request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace or create a term list<br/>
        /// Replace an existing term list for a language, or create a new one if it doesn't exist.
        /// </summary>
        /// <param name="spokenTermsId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.SpokenTermsList>> PutSpokenTermsListAsResponseAsync(
            string spokenTermsId,

            global::DeepL.PutSpokenTermsListParameters request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace or create a term list<br/>
        /// Replace an existing term list for a language, or create a new one if it doesn't exist.
        /// </summary>
        /// <param name="spokenTermsId"></param>
        /// <param name="lang">
        /// Language code (ISO 639-1) for this term list.<br/>
        /// Example: en
        /// </param>
        /// <param name="entries">
        /// Newline-separated list of terms. Maximum 300 characters total.<br/>
        /// Example: DeepL<br/>
        /// API<br/>
        /// webhook<br/>
        /// integration
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.SpokenTermsList> PutSpokenTermsListAsync(
            string spokenTermsId,
            string lang,
            string entries,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}