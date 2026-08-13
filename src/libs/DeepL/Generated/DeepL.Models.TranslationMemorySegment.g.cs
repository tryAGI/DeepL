
#nullable enable

namespace DeepL
{
    /// <summary>
    /// A source segment stored in a translation memory, with its translations.
    /// </summary>
    public sealed partial class TranslationMemorySegment
    {
        /// <summary>
        /// A unique ID assigned to the source segment.<br/>
        /// Example: 4f1c2d3e-8a9b-4c5d-9e6f-7a8b9c0d1e2f
        /// </summary>
        /// <example>4f1c2d3e-8a9b-4c5d-9e6f-7a8b9c0d1e2f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_segment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceSegmentId { get; set; }

        /// <summary>
        /// The source text of the segment.<br/>
        /// Example: This agreement is governed by the laws of Germany.
        /// </summary>
        /// <example>This agreement is governed by the laws of Germany.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceText { get; set; }

        /// <summary>
        /// The time the segment was added, in the ISO 8601-1:2019 format.<br/>
        /// Example: 2026-04-01T16:34:25.223Z
        /// </summary>
        /// <example>2026-04-01T16:34:25.223Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        public global::System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// The time the segment was last changed, in the ISO 8601-1:2019 format.<br/>
        /// Example: 2026-04-01T16:34:25.223Z
        /// </summary>
        /// <example>2026-04-01T16:34:25.223Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_time")]
        public global::System.DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// The time the segment was last applied to a translation, in the ISO 8601-1:2019 format. Absent<br/>
        /// if the segment has never been used.<br/>
        /// Example: 2026-08-05T11:02:18.771Z
        /// </summary>
        /// <example>2026-08-05T11:02:18.771Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_time")]
        public global::System.DateTime? LastUsedTime { get; set; }

        /// <summary>
        /// The translations of this source segment, one per target language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepL.TranslationMemoryTargetSegment> Targets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemorySegment" /> class.
        /// </summary>
        /// <param name="sourceSegmentId">
        /// A unique ID assigned to the source segment.<br/>
        /// Example: 4f1c2d3e-8a9b-4c5d-9e6f-7a8b9c0d1e2f
        /// </param>
        /// <param name="sourceText">
        /// The source text of the segment.<br/>
        /// Example: This agreement is governed by the laws of Germany.
        /// </param>
        /// <param name="targets">
        /// The translations of this source segment, one per target language.
        /// </param>
        /// <param name="creationTime">
        /// The time the segment was added, in the ISO 8601-1:2019 format.<br/>
        /// Example: 2026-04-01T16:34:25.223Z
        /// </param>
        /// <param name="updatedTime">
        /// The time the segment was last changed, in the ISO 8601-1:2019 format.<br/>
        /// Example: 2026-04-01T16:34:25.223Z
        /// </param>
        /// <param name="lastUsedTime">
        /// The time the segment was last applied to a translation, in the ISO 8601-1:2019 format. Absent<br/>
        /// if the segment has never been used.<br/>
        /// Example: 2026-08-05T11:02:18.771Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationMemorySegment(
            string sourceSegmentId,
            string sourceText,
            global::System.Collections.Generic.IList<global::DeepL.TranslationMemoryTargetSegment> targets,
            global::System.DateTime? creationTime,
            global::System.DateTime? updatedTime,
            global::System.DateTime? lastUsedTime)
        {
            this.SourceSegmentId = sourceSegmentId ?? throw new global::System.ArgumentNullException(nameof(sourceSegmentId));
            this.SourceText = sourceText ?? throw new global::System.ArgumentNullException(nameof(sourceText));
            this.CreationTime = creationTime;
            this.UpdatedTime = updatedTime;
            this.LastUsedTime = lastUsedTime;
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemorySegment" /> class.
        /// </summary>
        public TranslationMemorySegment()
        {
        }

    }
}