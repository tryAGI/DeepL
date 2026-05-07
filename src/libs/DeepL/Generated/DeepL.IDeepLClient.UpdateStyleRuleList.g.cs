#nullable enable

namespace DeepL
{
    public partial interface IDeepLClient
    {
        /// <summary>
        /// Update a style rule list's name
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.StyleRuleList> UpdateStyleRuleListAsync(
            string styleId,

            global::DeepL.UpdateStyleRuleListRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a style rule list's name
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.StyleRuleList>> UpdateStyleRuleListAsResponseAsync(
            string styleId,

            global::DeepL.UpdateStyleRuleListRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a style rule list's name
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="name">
        /// Name associated with the style rule list.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.StyleRuleList> UpdateStyleRuleListAsync(
            string styleId,
            string? name = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}