
#nullable enable

namespace DeepL
{
    /// <summary>
    /// A translation of a source segment in one target language.
    /// </summary>
    public sealed partial class TranslationMemoryTargetSegment
    {
        /// <summary>
        /// A unique ID assigned to the target segment.<br/>
        /// Example: 9b8a7c6d-5e4f-4a3b-8c2d-1e0f9a8b7c6d
        /// </summary>
        /// <example>9b8a7c6d-5e4f-4a3b-8c2d-1e0f9a8b7c6d</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_segment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetSegmentId { get; set; }

        /// <summary>
        /// The list of target languages available in the translation memory. A translation memory's target language must be compatible with the `target_lang` specified in a translation request.<br/>
        /// Example: es
        /// </summary>
        /// <example>es</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.TranslationMemoryTargetLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.TranslationMemoryTargetLanguage TargetLanguage { get; set; }

        /// <summary>
        /// The translated text.<br/>
        /// Example: Dieser Vertrag unterliegt dem Recht der Bundesrepublik Deutschland.
        /// </summary>
        /// <example>Dieser Vertrag unterliegt dem Recht der Bundesrepublik Deutschland.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetText { get; set; }

        /// <summary>
        /// The time the translation was added, in the ISO 8601-1:2019 format.<br/>
        /// Example: 2026-04-01T16:34:25.223Z
        /// </summary>
        /// <example>2026-04-01T16:34:25.223Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        public global::System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// The time the translation was last changed, in the ISO 8601-1:2019 format.<br/>
        /// Example: 2026-04-01T16:34:25.223Z
        /// </summary>
        /// <example>2026-04-01T16:34:25.223Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_time")]
        public global::System.DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// The time the translation was last applied to a translation request, in the ISO 8601-1:2019<br/>
        /// format. Absent if it has never been used.<br/>
        /// Example: 2026-08-05T11:02:18.771Z
        /// </summary>
        /// <example>2026-08-05T11:02:18.771Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_time")]
        public global::System.DateTime? LastUsedTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemoryTargetSegment" /> class.
        /// </summary>
        /// <param name="targetSegmentId">
        /// A unique ID assigned to the target segment.<br/>
        /// Example: 9b8a7c6d-5e4f-4a3b-8c2d-1e0f9a8b7c6d
        /// </param>
        /// <param name="targetLanguage">
        /// The list of target languages available in the translation memory. A translation memory's target language must be compatible with the `target_lang` specified in a translation request.<br/>
        /// Example: es
        /// </param>
        /// <param name="targetText">
        /// The translated text.<br/>
        /// Example: Dieser Vertrag unterliegt dem Recht der Bundesrepublik Deutschland.
        /// </param>
        /// <param name="creationTime">
        /// The time the translation was added, in the ISO 8601-1:2019 format.<br/>
        /// Example: 2026-04-01T16:34:25.223Z
        /// </param>
        /// <param name="updatedTime">
        /// The time the translation was last changed, in the ISO 8601-1:2019 format.<br/>
        /// Example: 2026-04-01T16:34:25.223Z
        /// </param>
        /// <param name="lastUsedTime">
        /// The time the translation was last applied to a translation request, in the ISO 8601-1:2019<br/>
        /// format. Absent if it has never been used.<br/>
        /// Example: 2026-08-05T11:02:18.771Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationMemoryTargetSegment(
            string targetSegmentId,
            global::DeepL.TranslationMemoryTargetLanguage targetLanguage,
            string targetText,
            global::System.DateTime? creationTime,
            global::System.DateTime? updatedTime,
            global::System.DateTime? lastUsedTime)
        {
            this.TargetSegmentId = targetSegmentId ?? throw new global::System.ArgumentNullException(nameof(targetSegmentId));
            this.TargetLanguage = targetLanguage;
            this.TargetText = targetText ?? throw new global::System.ArgumentNullException(nameof(targetText));
            this.CreationTime = creationTime;
            this.UpdatedTime = updatedTime;
            this.LastUsedTime = lastUsedTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemoryTargetSegment" /> class.
        /// </summary>
        public TranslationMemoryTargetSegment()
        {
        }

    }
}