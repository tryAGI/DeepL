#nullable enable

namespace DeepL
{
    public partial interface IStyleRulesClient
    {
        /// <summary>
        /// Update configured rules for a style rule list
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.StyleRuleList> UpdateStyleRuleConfiguredRulesAsync(
            string styleId,

            global::DeepL.ConfiguredRules request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update configured rules for a style rule list
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.StyleRuleList>> UpdateStyleRuleConfiguredRulesAsResponseAsync(
            string styleId,

            global::DeepL.ConfiguredRules request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update configured rules for a style rule list
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="datesAndTimes"></param>
        /// <param name="formatting"></param>
        /// <param name="numbers"></param>
        /// <param name="punctuation"></param>
        /// <param name="spellingAndGrammar"></param>
        /// <param name="styleAndTone"></param>
        /// <param name="vocabulary"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.StyleRuleList> UpdateStyleRuleConfiguredRulesAsync(
            string styleId,
            global::DeepL.ConfiguredRulesDatesAndTimes? datesAndTimes = default,
            global::DeepL.ConfiguredRulesFormatting? formatting = default,
            global::DeepL.ConfiguredRulesNumbers? numbers = default,
            global::DeepL.ConfiguredRulesPunctuation? punctuation = default,
            global::DeepL.ConfiguredRulesSpellingAndGrammar? spellingAndGrammar = default,
            global::DeepL.ConfiguredRulesStyleAndTone? styleAndTone = default,
            global::DeepL.ConfiguredRulesVocabulary? vocabulary = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}