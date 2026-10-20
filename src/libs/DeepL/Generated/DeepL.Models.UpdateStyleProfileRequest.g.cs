
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateStyleProfileRequest
    {
        /// <summary>
        /// A new name for the style profile. At most 255 characters. An empty string is rejected<br/>
        /// with `400 Bad Request`.<br/>
        /// Example: Legal, German (2026)
        /// </summary>
        /// <example>Legal, German (2026)</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A new description for the style profile. At most 1000 characters. Send an empty string<br/>
        /// to clear it.<br/>
        /// Example: Contract wording for the German market, 2026 revision.
        /// </summary>
        /// <example>Contract wording for the German market, 2026 revision.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A new industry for the style profile. At most 255 characters. Send an empty string to<br/>
        /// clear it.<br/>
        /// Example: Legal
        /// </summary>
        /// <example>Legal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("industry")]
        public string? Industry { get; set; }

        /// <summary>
        /// The IDs of the glossaries to link, highest priority first. The order only takes effect<br/>
        /// with `glossary_priority_order_enabled`. Replaces the linked glossaries in full. Send an<br/>
        /// empty list to unlink all of them.<br/>
        /// Example: [4d0a2e1c-6b93-4f7a-8d15-2c6e9a3b7f81]
        /// </summary>
        /// <example>[4d0a2e1c-6b93-4f7a-8d15-2c6e9a3b7f81]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("glossary_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? GlossaryIds { get; set; }

        /// <summary>
        /// The IDs of the style rule lists to link. At most one style rule list per target<br/>
        /// language. Replaces the linked style rule lists in full. Send an empty list to unlink<br/>
        /// all of them.<br/>
        /// Example: [bd0a38f3-1831-440b-a8dd-2c702e2325ab]
        /// </summary>
        /// <example>[bd0a38f3-1831-440b-a8dd-2c702e2325ab]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_rule_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? StyleRuleIds { get; set; }

        /// <summary>
        /// The IDs of the translation memories to link. At most one translation memory per source<br/>
        /// language. Replaces the linked translation memories in full. Send an empty list to<br/>
        /// unlink all of them.<br/>
        /// Example: [a74d88fb-ed2a-4943-a664-a4512398b994]
        /// </summary>
        /// <example>[a74d88fb-ed2a-4943-a664-a4512398b994]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation_memory_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? TranslationMemoryIds { get; set; }

        /// <summary>
        /// Whether the order of `glossary_ids` sets priority: when two linked glossaries define the<br/>
        /// same source term, the one listed first wins. When `false`, the order has no effect.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("glossary_priority_order_enabled")]
        public bool? GlossaryPriorityOrderEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStyleProfileRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateStyleProfileRequest(
            string? name,
            string? description,
            string? industry,
            global::System.Collections.Generic.IList<global::System.Guid>? glossaryIds,
            global::System.Collections.Generic.IList<global::System.Guid>? styleRuleIds,
            global::System.Collections.Generic.IList<global::System.Guid>? translationMemoryIds,
            bool? glossaryPriorityOrderEnabled)
        {
            this.Name = name;
            this.Description = description;
            this.Industry = industry;
            this.GlossaryIds = glossaryIds;
            this.StyleRuleIds = styleRuleIds;
            this.TranslationMemoryIds = translationMemoryIds;
            this.GlossaryPriorityOrderEnabled = glossaryPriorityOrderEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStyleProfileRequest" /> class.
        /// </summary>
        public UpdateStyleProfileRequest()
        {
        }

    }
}