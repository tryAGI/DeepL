
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StyleProfile
    {
        /// <summary>
        /// A unique ID assigned to a style profile.<br/>
        /// Example: 3f1c9d0e-7a24-4b58-9c31-8f0e5d2a1b47
        /// </summary>
        /// <example>3f1c9d0e-7a24-4b58-9c31-8f0e5d2a1b47</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_profile_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid StyleProfileId { get; set; }

        /// <summary>
        /// Name associated with the style profile. At most 255 characters.<br/>
        /// Example: Legal, German
        /// </summary>
        /// <example>Legal, German</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Free-text description of the style profile. At most 1000 characters. Omitted from the response<br/>
        /// when the style profile has no description.<br/>
        /// Example: Contract wording for the German market.
        /// </summary>
        /// <example>Contract wording for the German market.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The industry the style profile is written for. At most 255 characters. Omitted from the response<br/>
        /// when the style profile has no industry.<br/>
        /// Example: Legal
        /// </summary>
        /// <example>Legal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("industry")]
        public string? Industry { get; set; }

        /// <summary>
        /// The IDs of the glossaries linked to the style profile, highest priority first. The order only<br/>
        /// takes effect with `glossary_priority_order_enabled`.<br/>
        /// Example: [4d0a2e1c-6b93-4f7a-8d15-2c6e9a3b7f81]
        /// </summary>
        /// <example>[4d0a2e1c-6b93-4f7a-8d15-2c6e9a3b7f81]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("glossary_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> GlossaryIds { get; set; }

        /// <summary>
        /// The IDs of the style rule lists linked to the style profile. A style profile links at most one<br/>
        /// style rule list per target language.<br/>
        /// Example: [bd0a38f3-1831-440b-a8dd-2c702e2325ab]
        /// </summary>
        /// <example>[bd0a38f3-1831-440b-a8dd-2c702e2325ab]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_rule_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> StyleRuleIds { get; set; }

        /// <summary>
        /// The IDs of the translation memories linked to the style profile. A style profile links at most<br/>
        /// one translation memory per source language.<br/>
        /// Example: [a74d88fb-ed2a-4943-a664-a4512398b994]
        /// </summary>
        /// <example>[a74d88fb-ed2a-4943-a664-a4512398b994]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation_memory_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> TranslationMemoryIds { get; set; }

        /// <summary>
        /// Whether the order of `glossary_ids` sets priority: when two linked glossaries define the same<br/>
        /// source term, the one listed first wins. When `false`, the order has no effect.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("glossary_priority_order_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool GlossaryPriorityOrderEnabled { get; set; }

        /// <summary>
        /// The creation time of the style profile in the ISO 8601-1:2019 format (e.g.: `2021-08-03T14:16:18.329Z`).<br/>
        /// Example: 2026-04-01T16:34:25.223Z
        /// </summary>
        /// <example>2026-04-01T16:34:25.223Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreationTime { get; set; }

        /// <summary>
        /// The time of the last update to the style profile in the ISO 8601-1:2019 format (e.g.: `2021-08-03T14:16:18.329Z`).<br/>
        /// Example: 2026-08-06T09:12:44.108Z
        /// </summary>
        /// <example>2026-08-06T09:12:44.108Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleProfile" /> class.
        /// </summary>
        /// <param name="styleProfileId">
        /// A unique ID assigned to a style profile.<br/>
        /// Example: 3f1c9d0e-7a24-4b58-9c31-8f0e5d2a1b47
        /// </param>
        /// <param name="name">
        /// Name associated with the style profile. At most 255 characters.<br/>
        /// Example: Legal, German
        /// </param>
        /// <param name="glossaryIds">
        /// The IDs of the glossaries linked to the style profile, highest priority first. The order only<br/>
        /// takes effect with `glossary_priority_order_enabled`.<br/>
        /// Example: [4d0a2e1c-6b93-4f7a-8d15-2c6e9a3b7f81]
        /// </param>
        /// <param name="styleRuleIds">
        /// The IDs of the style rule lists linked to the style profile. A style profile links at most one<br/>
        /// style rule list per target language.<br/>
        /// Example: [bd0a38f3-1831-440b-a8dd-2c702e2325ab]
        /// </param>
        /// <param name="translationMemoryIds">
        /// The IDs of the translation memories linked to the style profile. A style profile links at most<br/>
        /// one translation memory per source language.<br/>
        /// Example: [a74d88fb-ed2a-4943-a664-a4512398b994]
        /// </param>
        /// <param name="glossaryPriorityOrderEnabled">
        /// Whether the order of `glossary_ids` sets priority: when two linked glossaries define the same<br/>
        /// source term, the one listed first wins. When `false`, the order has no effect.<br/>
        /// Example: true
        /// </param>
        /// <param name="creationTime">
        /// The creation time of the style profile in the ISO 8601-1:2019 format (e.g.: `2021-08-03T14:16:18.329Z`).<br/>
        /// Example: 2026-04-01T16:34:25.223Z
        /// </param>
        /// <param name="updatedTime">
        /// The time of the last update to the style profile in the ISO 8601-1:2019 format (e.g.: `2021-08-03T14:16:18.329Z`).<br/>
        /// Example: 2026-08-06T09:12:44.108Z
        /// </param>
        /// <param name="description">
        /// Free-text description of the style profile. At most 1000 characters. Omitted from the response<br/>
        /// when the style profile has no description.<br/>
        /// Example: Contract wording for the German market.
        /// </param>
        /// <param name="industry">
        /// The industry the style profile is written for. At most 255 characters. Omitted from the response<br/>
        /// when the style profile has no industry.<br/>
        /// Example: Legal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StyleProfile(
            global::System.Guid styleProfileId,
            string name,
            global::System.Collections.Generic.IList<global::System.Guid> glossaryIds,
            global::System.Collections.Generic.IList<global::System.Guid> styleRuleIds,
            global::System.Collections.Generic.IList<global::System.Guid> translationMemoryIds,
            bool glossaryPriorityOrderEnabled,
            global::System.DateTime creationTime,
            global::System.DateTime updatedTime,
            string? description,
            string? industry)
        {
            this.StyleProfileId = styleProfileId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Industry = industry;
            this.GlossaryIds = glossaryIds ?? throw new global::System.ArgumentNullException(nameof(glossaryIds));
            this.StyleRuleIds = styleRuleIds ?? throw new global::System.ArgumentNullException(nameof(styleRuleIds));
            this.TranslationMemoryIds = translationMemoryIds ?? throw new global::System.ArgumentNullException(nameof(translationMemoryIds));
            this.GlossaryPriorityOrderEnabled = glossaryPriorityOrderEnabled;
            this.CreationTime = creationTime;
            this.UpdatedTime = updatedTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleProfile" /> class.
        /// </summary>
        public StyleProfile()
        {
        }

    }
}