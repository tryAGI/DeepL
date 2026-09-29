
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StyleRuleList
    {
        /// <summary>
        /// A unique ID assigned to a style rule list.<br/>
        /// Example: bd0a38f3-1831-440b-a8dd-2c702e2325ab
        /// </summary>
        /// <example>bd0a38f3-1831-440b-a8dd-2c702e2325ab</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StyleId { get; set; }

        /// <summary>
        /// Name associated with the style rule list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The creation time of the style rule list in the ISO 8601-1:2019 format (e.g.: `2021-08-03T14:16:18.329Z`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreationTime { get; set; }

        /// <summary>
        /// The time of the style rule list when it was last updated in the ISO 8601-1:2019 format (e.g.: `2022-08-03T14:16:18.329Z`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedTime { get; set; }

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
        /// The version of the style rule list. Incremented when the style rule list is updated.<br/>
        /// Example: 13
        /// </summary>
        /// <example>13</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// The enabled rules for the style rule list including what option was selected for each rule. This schema combines rules from all supported languages.<br/>
        /// Example: {"style_and_tone":{"abbreviations":"use_abbreviations_and_symbols","short_vs_long_words":"use_short_words"},"punctuation":{"apostrophe":"use_curly_apostrophes"}}
        /// </summary>
        /// <example>{"style_and_tone":{"abbreviations":"use_abbreviations_and_symbols","short_vs_long_words":"use_short_words"},"punctuation":{"apostrophe":"use_curly_apostrophes"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("configured_rules")]
        public global::DeepL.ConfiguredRules? ConfiguredRules { get; set; }

        /// <summary>
        /// List of custom instructions enabled for the style rule list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_instructions")]
        public global::System.Collections.Generic.IList<global::DeepL.CustomInstruction>? CustomInstructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleRuleList" /> class.
        /// </summary>
        /// <param name="styleId">
        /// A unique ID assigned to a style rule list.<br/>
        /// Example: bd0a38f3-1831-440b-a8dd-2c702e2325ab
        /// </param>
        /// <param name="name">
        /// Name associated with the style rule list.
        /// </param>
        /// <param name="creationTime">
        /// The creation time of the style rule list in the ISO 8601-1:2019 format (e.g.: `2021-08-03T14:16:18.329Z`).
        /// </param>
        /// <param name="updatedTime">
        /// The time of the style rule list when it was last updated in the ISO 8601-1:2019 format (e.g.: `2022-08-03T14:16:18.329Z`).
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
        /// <param name="version">
        /// The version of the style rule list. Incremented when the style rule list is updated.<br/>
        /// Example: 13
        /// </param>
        /// <param name="configuredRules">
        /// The enabled rules for the style rule list including what option was selected for each rule. This schema combines rules from all supported languages.<br/>
        /// Example: {"style_and_tone":{"abbreviations":"use_abbreviations_and_symbols","short_vs_long_words":"use_short_words"},"punctuation":{"apostrophe":"use_curly_apostrophes"}}
        /// </param>
        /// <param name="customInstructions">
        /// List of custom instructions enabled for the style rule list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StyleRuleList(
            string styleId,
            string name,
            global::System.DateTime creationTime,
            global::System.DateTime updatedTime,
            global::DeepL.StyleRuleLanguage language,
            int version,
            global::DeepL.ConfiguredRules? configuredRules,
            global::System.Collections.Generic.IList<global::DeepL.CustomInstruction>? customInstructions)
        {
            this.StyleId = styleId ?? throw new global::System.ArgumentNullException(nameof(styleId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreationTime = creationTime;
            this.UpdatedTime = updatedTime;
            this.Language = language;
            this.Version = version;
            this.ConfiguredRules = configuredRules;
            this.CustomInstructions = customInstructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleRuleList" /> class.
        /// </summary>
        public StyleRuleList()
        {
        }

    }
}