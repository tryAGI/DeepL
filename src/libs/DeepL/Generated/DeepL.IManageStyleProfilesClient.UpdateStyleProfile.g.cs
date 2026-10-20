#nullable enable

namespace DeepL
{
    public partial interface IManageStyleProfilesClient
    {
        /// <summary>
        /// Update a style profile<br/>
        /// Update a style profile you own or that was shared with you for editing. Fields you leave out of the<br/>
        /// request body are not changed.<br/>
        /// A component list you send replaces the linked list in full. To add a glossary to a style profile<br/>
        /// that already links two, send all three IDs. To unlink all components in a list, send an empty<br/>
        /// list.<br/>
        /// Requires an API key with the `style_profiles:write` scope.
        /// </summary>
        /// <param name="styleProfileId">
        /// A unique ID assigned to a style profile.<br/>
        /// Example: 3f1c9d0e-7a24-4b58-9c31-8f0e5d2a1b47
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.StyleProfile> UpdateStyleProfileAsync(
            global::System.Guid styleProfileId,

            global::DeepL.UpdateStyleProfileRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a style profile<br/>
        /// Update a style profile you own or that was shared with you for editing. Fields you leave out of the<br/>
        /// request body are not changed.<br/>
        /// A component list you send replaces the linked list in full. To add a glossary to a style profile<br/>
        /// that already links two, send all three IDs. To unlink all components in a list, send an empty<br/>
        /// list.<br/>
        /// Requires an API key with the `style_profiles:write` scope.
        /// </summary>
        /// <param name="styleProfileId">
        /// A unique ID assigned to a style profile.<br/>
        /// Example: 3f1c9d0e-7a24-4b58-9c31-8f0e5d2a1b47
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.StyleProfile>> UpdateStyleProfileAsResponseAsync(
            global::System.Guid styleProfileId,

            global::DeepL.UpdateStyleProfileRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a style profile<br/>
        /// Update a style profile you own or that was shared with you for editing. Fields you leave out of the<br/>
        /// request body are not changed.<br/>
        /// A component list you send replaces the linked list in full. To add a glossary to a style profile<br/>
        /// that already links two, send all three IDs. To unlink all components in a list, send an empty<br/>
        /// list.<br/>
        /// Requires an API key with the `style_profiles:write` scope.
        /// </summary>
        /// <param name="styleProfileId">
        /// A unique ID assigned to a style profile.<br/>
        /// Example: 3f1c9d0e-7a24-4b58-9c31-8f0e5d2a1b47
        /// </param>
        /// <param name="name">
        /// A new name for the style profile. At most 255 characters. An empty string is rejected<br/>
        /// with `400 Bad Request`.<br/>
        /// Example: Legal, German (2026)
        /// </param>
        /// <param name="description">
        /// A new description for the style profile. At most 1000 characters. Send an empty string<br/>
        /// to clear it.<br/>
        /// Example: Contract wording for the German market, 2026 revision.
        /// </param>
        /// <param name="industry">
        /// A new industry for the style profile. At most 255 characters. Send an empty string to<br/>
        /// clear it.<br/>
        /// Example: Legal
        /// </param>
        /// <param name="glossaryIds">
        /// The IDs of the glossaries to link, highest priority first. The order only takes effect<br/>
        /// with `glossary_priority_order_enabled`. Replaces the linked glossaries in full. Send an<br/>
        /// empty list to unlink all of them.<br/>
        /// Example: [4d0a2e1c-6b93-4f7a-8d15-2c6e9a3b7f81]
        /// </param>
        /// <param name="styleRuleIds">
        /// The IDs of the style rule lists to link. At most one style rule list per target<br/>
        /// language. Replaces the linked style rule lists in full. Send an empty list to unlink<br/>
        /// all of them.<br/>
        /// Example: [bd0a38f3-1831-440b-a8dd-2c702e2325ab]
        /// </param>
        /// <param name="translationMemoryIds">
        /// The IDs of the translation memories to link. At most one translation memory per source<br/>
        /// language. Replaces the linked translation memories in full. Send an empty list to<br/>
        /// unlink all of them.<br/>
        /// Example: [a74d88fb-ed2a-4943-a664-a4512398b994]
        /// </param>
        /// <param name="glossaryPriorityOrderEnabled">
        /// Whether the order of `glossary_ids` sets priority: when two linked glossaries define the<br/>
        /// same source term, the one listed first wins. When `false`, the order has no effect.<br/>
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.StyleProfile> UpdateStyleProfileAsync(
            global::System.Guid styleProfileId,
            string? name = default,
            string? description = default,
            string? industry = default,
            global::System.Collections.Generic.IList<global::System.Guid>? glossaryIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? styleRuleIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? translationMemoryIds = default,
            bool? glossaryPriorityOrderEnabled = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}