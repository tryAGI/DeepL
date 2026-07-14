#nullable enable

namespace DeepL
{
    public partial interface IManageSpokenTermsClient
    {
        /// <summary>
        /// Edit Spoken Terms collection details<br/>
        /// Update the name of a Spoken Terms collection or merge new entries into an existing term list.
        /// </summary>
        /// <param name="spokenTermsId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.SpokenTerms> PatchSpokenTermsAsync(
            string spokenTermsId,

            global::DeepL.PatchSpokenTermsParameters request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Spoken Terms collection details<br/>
        /// Update the name of a Spoken Terms collection or merge new entries into an existing term list.
        /// </summary>
        /// <param name="spokenTermsId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.SpokenTerms>> PatchSpokenTermsAsResponseAsync(
            string spokenTermsId,

            global::DeepL.PatchSpokenTermsParameters request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Spoken Terms collection details<br/>
        /// Update the name of a Spoken Terms collection or merge new entries into an existing term list.
        /// </summary>
        /// <param name="spokenTermsId"></param>
        /// <param name="name">
        /// New name for the Spoken Terms collection.<br/>
        /// Example: Updated Technical Terms
        /// </param>
        /// <param name="termLists">
        /// Term lists to merge with existing lists.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.SpokenTerms> PatchSpokenTermsAsync(
            string spokenTermsId,
            string? name = default,
            global::System.Collections.Generic.IList<global::DeepL.SpokenTermsListInput>? termLists = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}