
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateStyleProfileRequest
    {
        /// <summary>
        /// Name for the style profile. At most 255 characters. An empty name is rejected with<br/>
        /// `400 Bad Request`.<br/>
        /// Example: Legal, German
        /// </summary>
        /// <example>Legal, German</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Free-text description of the style profile. At most 1000 characters. Omit it to create<br/>
        /// the style profile without a description.<br/>
        /// Example: Contract wording for the German market.
        /// </summary>
        /// <example>Contract wording for the German market.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The industry the style profile is written for. At most 255 characters. Omit it to create<br/>
        /// the style profile without an industry.<br/>
        /// Example: Legal
        /// </summary>
        /// <example>Legal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("industry")]
        public string? Industry { get; set; }

        /// <summary>
        /// The IDs of the glossaries to link, highest priority first. The order only takes effect<br/>
        /// with `glossary_priority_order_enabled`. Defaults to an empty list.<br/>
        /// Example: [4d0a2e1c-6b93-4f7a-8d15-2c6e9a3b7f81]
        /// </summary>
        /// <example>[4d0a2e1c-6b93-4f7a-8d15-2c6e9a3b7f81]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("glossary_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? GlossaryIds { get; set; }

        /// <summary>
        /// The IDs of the style rule lists to link. At most one style rule list per target<br/>
        /// language. Defaults to an empty list.<br/>
        /// Example: [bd0a38f3-1831-440b-a8dd-2c702e2325ab]
        /// </summary>
        /// <example>[bd0a38f3-1831-440b-a8dd-2c702e2325ab]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_rule_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? StyleRuleIds { get; set; }

        /// <summary>
        /// The IDs of the translation memories to link. At most one translation memory per source<br/>
        /// language. Defaults to an empty list.<br/>
        /// Example: [a74d88fb-ed2a-4943-a664-a4512398b994]
        /// </summary>
        /// <example>[a74d88fb-ed2a-4943-a664-a4512398b994]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation_memory_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? TranslationMemoryIds { get; set; }

        /// <summary>
        /// Whether the order of `glossary_ids` sets priority: when two linked glossaries define the<br/>
        /// same source term, the one listed first wins. When `false`, the order has no effect.<br/>
        /// Defaults to `false`.<br/>
        /// Default Value: false<br/>
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
        /// Initializes a new instance of the <see cref="CreateStyleProfileRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStyleProfileRequest(
            string name,
            string? description,
            string? industry,
            global::System.Collections.Generic.IList<global::System.Guid>? glossaryIds,
            global::System.Collections.Generic.IList<global::System.Guid>? styleRuleIds,
            global::System.Collections.Generic.IList<global::System.Guid>? translationMemoryIds,
            bool? glossaryPriorityOrderEnabled)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Industry = industry;
            this.GlossaryIds = glossaryIds;
            this.StyleRuleIds = styleRuleIds;
            this.TranslationMemoryIds = translationMemoryIds;
            this.GlossaryPriorityOrderEnabled = glossaryPriorityOrderEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStyleProfileRequest" /> class.
        /// </summary>
        public CreateStyleProfileRequest()
        {
        }

    }
}