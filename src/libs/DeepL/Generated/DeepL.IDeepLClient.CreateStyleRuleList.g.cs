#nullable enable

namespace DeepL
{
    public partial interface IDeepLClient
    {
        /// <summary>
        /// Create a style rule list<br/>
        /// Create a style rule list for a single language, optionally with its configured rules<br/>
        /// and custom instructions. The `language` can be a root code such as `de` or a variant<br/>
        /// code such as `de-CH`. Use the returned `style_id` with the translation endpoints<br/>
        /// to apply the list.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.StyleRuleList> CreateStyleRuleListAsync(

            global::DeepL.CreateStyleRuleListRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a style rule list<br/>
        /// Create a style rule list for a single language, optionally with its configured rules<br/>
        /// and custom instructions. The `language` can be a root code such as `de` or a variant<br/>
        /// code such as `de-CH`. Use the returned `style_id` with the translation endpoints<br/>
        /// to apply the list.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.StyleRuleList>> CreateStyleRuleListAsResponseAsync(

            global::DeepL.CreateStyleRuleListRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a style rule list<br/>
        /// Create a style rule list for a single language, optionally with its configured rules<br/>
        /// and custom instructions. The `language` can be a root code such as `de` or a variant<br/>
        /// code such as `de-CH`. Use the returned `style_id` with the translation endpoints<br/>
        /// to apply the list.
        /// </summary>
        /// <param name="name">
        /// Name associated with the style rule list.
        /// </param>
        /// <param name="language">
        /// The target language the style rule list applies to. Codes are matched case-insensitively;<br/>
        /// the response returns the canonical form (for example `de-CH`).<br/>
        /// A root code (for example `en`) applies to that language and all of its variants. A variant<br/>
        /// code (for example `en-GB`) applies only when `target_lang` is that variant.<br/>
        /// Variant lists for `de-CH`, `fr-CA`, `pt-BR`, and `pt-PT` are generally available. Variant<br/>
        /// lists for `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-FR`, `zh-Hans`, and `zh-Hant`<br/>
        /// are in beta. The current list and the status of each language are returned by<br/>
        /// [`GET /v3/languages?resource=style_rules&amp;include=beta`](/docs/languages/using-the-languages-api).
        /// </param>
        /// <param name="configuredRules">
        /// The enabled rules for the style rule list including what option was selected for each rule. This schema combines rules from all supported languages.<br/>
        /// Example: {"style_and_tone":{"abbreviations":"use_abbreviations_and_symbols","short_vs_long_words":"use_short_words"},"punctuation":{"apostrophe":"use_curly_apostrophes"}}
        /// </param>
        /// <param name="customInstructions">
        /// Array of custom instruction objects
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.StyleRuleList> CreateStyleRuleListAsync(
            string name,
            global::DeepL.StyleRuleLanguage language,
            global::DeepL.ConfiguredRules? configuredRules = default,
            global::System.Collections.Generic.IList<global::DeepL.CreateStyleRuleListRequestCustomInstruction>? customInstructions = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}