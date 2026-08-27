
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TranslationMemory
    {
        /// <summary>
        /// A unique ID assigned to a translation memory.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </summary>
        /// <example>a74d88fb-ed2a-4943-a664-a4512398b994</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation_memory_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TranslationMemoryId { get; set; }

        /// <summary>
        /// Name associated with the translation memory.<br/>
        /// Example: Legal
        /// </summary>
        /// <example>Legal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The source language of the translation memory.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.TranslationMemorySourceLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.TranslationMemorySourceLanguage SourceLanguage { get; set; }

        /// <summary>
        /// The list of target languages available in the translation memory.<br/>
        /// Example: [es, de]
        /// </summary>
        /// <example>[es, de]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepL.TranslationMemoryTargetLanguage> TargetLanguages { get; set; }

        /// <summary>
        /// The number of segments stored in the translation memory.<br/>
        /// Example: 34
        /// </summary>
        /// <example>34</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SegmentCount { get; set; }

        /// <summary>
        /// The creation time of the translation memory in the ISO 8601-1:2019 format (e.g.: `2021-08-03T14:16:18.329Z`).<br/>
        /// Example: 2026-04-01T16:34:25.223Z
        /// </summary>
        /// <example>2026-04-01T16:34:25.223Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        public global::System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// The time of the last update to the translation memory in the ISO 8601-1:2019 format (e.g.: `2021-08-03T14:16:18.329Z`).<br/>
        /// Example: 2026-04-01T16:34:25.264Z
        /// </summary>
        /// <example>2026-04-01T16:34:25.264Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_time")]
        public global::System.DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemory" /> class.
        /// </summary>
        /// <param name="translationMemoryId">
        /// A unique ID assigned to a translation memory.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </param>
        /// <param name="name">
        /// Name associated with the translation memory.<br/>
        /// Example: Legal
        /// </param>
        /// <param name="sourceLanguage">
        /// The source language of the translation memory.<br/>
        /// Example: en
        /// </param>
        /// <param name="targetLanguages">
        /// The list of target languages available in the translation memory.<br/>
        /// Example: [es, de]
        /// </param>
        /// <param name="segmentCount">
        /// The number of segments stored in the translation memory.<br/>
        /// Example: 34
        /// </param>
        /// <param name="creationTime">
        /// The creation time of the translation memory in the ISO 8601-1:2019 format (e.g.: `2021-08-03T14:16:18.329Z`).<br/>
        /// Example: 2026-04-01T16:34:25.223Z
        /// </param>
        /// <param name="updatedTime">
        /// The time of the last update to the translation memory in the ISO 8601-1:2019 format (e.g.: `2021-08-03T14:16:18.329Z`).<br/>
        /// Example: 2026-04-01T16:34:25.264Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationMemory(
            global::System.Guid translationMemoryId,
            string name,
            global::DeepL.TranslationMemorySourceLanguage sourceLanguage,
            global::System.Collections.Generic.IList<global::DeepL.TranslationMemoryTargetLanguage> targetLanguages,
            int segmentCount,
            global::System.DateTime? creationTime,
            global::System.DateTime? updatedTime)
        {
            this.TranslationMemoryId = translationMemoryId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SourceLanguage = sourceLanguage;
            this.TargetLanguages = targetLanguages ?? throw new global::System.ArgumentNullException(nameof(targetLanguages));
            this.SegmentCount = segmentCount;
            this.CreationTime = creationTime;
            this.UpdatedTime = updatedTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemory" /> class.
        /// </summary>
        public TranslationMemory()
        {
        }

    }
}