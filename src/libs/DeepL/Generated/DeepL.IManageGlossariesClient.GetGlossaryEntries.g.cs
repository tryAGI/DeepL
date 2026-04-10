#nullable enable

namespace DeepL
{
    public partial interface IManageGlossariesClient
    {
        /// <summary>
        /// Retrieve Glossary Entries<br/>
        /// List the entries of a single glossary in the format specified by the `Accept` header.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="accept">
        /// Default Value: text/tab-separated-values
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task GetGlossaryEntriesAsync(
            string glossaryId,
            global::DeepL.GetGlossaryEntriesAccept? accept = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Glossary Entries<br/>
        /// List the entries of a single glossary in the format specified by the `Accept` header.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="accept">
        /// Default Value: text/tab-separated-values
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse> GetGlossaryEntriesAsResponseAsync(
            string glossaryId,
            global::DeepL.GetGlossaryEntriesAccept? accept = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}