#nullable enable

namespace DeepL
{
    public partial interface IManageSpokenTermsClient
    {
        /// <summary>
        /// Create Spoken Terms collection<br/>
        /// Create a new Spoken Terms collection with one or more term lists. Each term list contains terms for a single language.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.SpokenTerms> CreateSpokenTermsAsync(

            global::DeepL.CreateSpokenTermsParameters request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Spoken Terms collection<br/>
        /// Create a new Spoken Terms collection with one or more term lists. Each term list contains terms for a single language.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.SpokenTerms>> CreateSpokenTermsAsResponseAsync(

            global::DeepL.CreateSpokenTermsParameters request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Spoken Terms collection<br/>
        /// Create a new Spoken Terms collection with one or more term lists. Each term list contains terms for a single language.
        /// </summary>
        /// <param name="name">
        /// Name for the Spoken Terms collection.<br/>
        /// Example: Technical Terms
        /// </param>
        /// <param name="termLists">
        /// Array of term lists, one per language.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.SpokenTerms> CreateSpokenTermsAsync(
            string name,
            global::System.Collections.Generic.IList<global::DeepL.SpokenTermsListInput> termLists,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}