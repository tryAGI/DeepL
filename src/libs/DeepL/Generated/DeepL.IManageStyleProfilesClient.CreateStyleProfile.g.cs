#nullable enable

namespace DeepL
{
    public partial interface IManageStyleProfilesClient
    {
        /// <summary>
        /// Create a style profile<br/>
        /// Create a style profile. Only `name` is required.<br/>
        /// If any of the component IDs cannot be used, the request fails and no style profile is created.<br/>
        /// Requires an API key with the `style_profiles:write` scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.StyleProfile> CreateStyleProfileAsync(

            global::DeepL.CreateStyleProfileRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a style profile<br/>
        /// Create a style profile. Only `name` is required.<br/>
        /// If any of the component IDs cannot be used, the request fails and no style profile is created.<br/>
        /// Requires an API key with the `style_profiles:write` scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.StyleProfile>> CreateStyleProfileAsResponseAsync(

            global::DeepL.CreateStyleProfileRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a style profile<br/>
        /// Create a style profile. Only `name` is required.<br/>
        /// If any of the component IDs cannot be used, the request fails and no style profile is created.<br/>
        /// Requires an API key with the `style_profiles:write` scope.
        /// </summary>
        /// <param name="name">
        /// Name for the style profile. At most 255 characters. An empty name is rejected with<br/>
        /// `400 Bad Request`.<br/>
        /// Example: Legal, German
        /// </param>
        /// <param name="description">
        /// Free-text description of the style profile. At most 1000 characters. Omit it to create<br/>
        /// the style profile without a description.<br/>
        /// Example: Contract wording for the German market.
        /// </param>
        /// <param name="industry">
        /// The industry the style profile is written for. At most 255 characters. Omit it to create<br/>
        /// the style profile without an industry.<br/>
        /// Example: Legal
        /// </param>
        /// <param name="glossaryIds">
        /// The IDs of the glossaries to link, highest priority first. The order only takes effect<br/>
        /// with `glossary_priority_order_enabled`. Defaults to an empty list.<br/>
        /// Example: [4d0a2e1c-6b93-4f7a-8d15-2c6e9a3b7f81]
        /// </param>
        /// <param name="styleRuleIds">
        /// The IDs of the style rule lists to link. At most one style rule list per target<br/>
        /// language. Defaults to an empty list.<br/>
        /// Example: [bd0a38f3-1831-440b-a8dd-2c702e2325ab]
        /// </param>
        /// <param name="translationMemoryIds">
        /// The IDs of the translation memories to link. At most one translation memory per source<br/>
        /// language. Defaults to an empty list.<br/>
        /// Example: [a74d88fb-ed2a-4943-a664-a4512398b994]
        /// </param>
        /// <param name="glossaryPriorityOrderEnabled">
        /// Whether the order of `glossary_ids` sets priority: when two linked glossaries define the<br/>
        /// same source term, the one listed first wins. When `false`, the order has no effect.<br/>
        /// Defaults to `false`.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.StyleProfile> CreateStyleProfileAsync(
            string name,
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