
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateStyleRuleListRequest
    {
        /// <summary>
        /// Name associated with the style rule list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The target language the style rule list applies to. Codes are matched case-insensitively;<br/>
        /// the response returns the canonical form (for example `de-CH`).<br/>
        /// A root code (for example `en`) applies to that language and all of its variants. A variant<br/>
        /// code (for example `en-GB`) applies only when `target_lang` is that variant.<br/>
        /// Variant lists for `de-CH`, `fr-CA`, `pt-BR`, and `pt-PT` are generally available. Variant<br/>
        /// lists for `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-FR`, `zh-Hans`, and `zh-Hant`<br/>
        /// are in beta. The current list and the status of each language are returned by<br/>
        /// [`GET /v3/languages?resource=style_rules&amp;include=beta`](/docs/languages/using-the-languages-api).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.StyleRuleLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.StyleRuleLanguage Language { get; set; }

        /// <summary>
        /// The enabled rules for the style rule list including what option was selected for each rule. This schema combines rules from all supported languages.<br/>
        /// Example: {"style_and_tone":{"abbreviations":"use_abbreviations_and_symbols","short_vs_long_words":"use_short_words"},"punctuation":{"apostrophe":"use_curly_apostrophes"}}
        /// </summary>
        /// <example>{"style_and_tone":{"abbreviations":"use_abbreviations_and_symbols","short_vs_long_words":"use_short_words"},"punctuation":{"apostrophe":"use_curly_apostrophes"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("configured_rules")]
        public global::DeepL.ConfiguredRules? ConfiguredRules { get; set; }

        /// <summary>
        /// Array of custom instruction objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_instructions")]
        public global::System.Collections.Generic.IList<global::DeepL.CreateStyleRuleListRequestCustomInstruction>? CustomInstructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStyleRuleListRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStyleRuleListRequest(
            string name,
            global::DeepL.StyleRuleLanguage language,
            global::DeepL.ConfiguredRules? configuredRules,
            global::System.Collections.Generic.IList<global::DeepL.CreateStyleRuleListRequestCustomInstruction>? customInstructions)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Language = language;
            this.ConfiguredRules = configuredRules;
            this.CustomInstructions = customInstructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStyleRuleListRequest" /> class.
        /// </summary>
        public CreateStyleRuleListRequest()
        {
        }

    }
}