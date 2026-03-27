#nullable enable

namespace DeepL
{
    public partial interface IStyleRulesClient
    {
        /// <summary>
        /// Create a style rule list
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.StyleRuleList> CreateStyleRuleListAsync(

            global::DeepL.CreateStyleRuleListRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a style rule list
        /// </summary>
        /// <param name="name">
        /// Name of the style rule list<br/>
        /// Example: Technical Documentation Rules
        /// </param>
        /// <param name="language">
        /// The language that the style rules are applied to.
        /// </param>
        /// <param name="configuredRules">
        /// The enabled rules for the style rule list including what option was selected for each rule. This schema combines rules from all supported languages.
        /// </param>
        /// <param name="customInstructions">
        /// List of custom instructions to enable for the style rule list
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.StyleRuleList> CreateStyleRuleListAsync(
            string name,
            global::DeepL.StyleRuleLanguage language,
            global::DeepL.ConfiguredRules? configuredRules = default,
            global::System.Collections.Generic.IList<global::DeepL.CustomInstructionRequest>? customInstructions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}