
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualityEvaluationSegment
    {
        /// <summary>
        /// Zero-based index of this segment within the document, in reading order.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SegmentIndex { get; set; }

        /// <summary>
        /// Quality score for this segment, where 0 is lowest and 100 is highest.<br/>
        /// Example: 38.5
        /// </summary>
        /// <example>38.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float SegmentScore { get; set; }

        /// <summary>
        /// The segment's source text as the evaluation read it. `source_spans` are offsets into this text. Omitted when the text is unavailable. See [Segment text](/api-reference/quality-evaluations/poll#segment-text).<br/>
        /// Example: Our Q3 revenue came in 5% above forecast.
        /// </summary>
        /// <example>Our Q3 revenue came in 5% above forecast.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// The segment's translated text as the evaluation read it. `target_spans` are offsets into this text. Omitted when the text is unavailable. See [Segment text](/api-reference/quality-evaluations/poll#segment-text).<br/>
        /// Example: Unser Q3-Umsatz lag 5 % unter der Prognose.
        /// </summary>
        /// <example>Unser Q3-Umsatz lag 5 % unter der Prognose.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public string? Target { get; set; }

        /// <summary>
        /// Glossary term pairs applied to this segment when the document was translated, so you can tell which customizations were in play where an issue was reported. Omitted when no term pair was applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applied_glossary_term_pairs")]
        public global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationAppliedGlossaryTermPair>? AppliedGlossaryTermPairs { get; set; }

        /// <summary>
        /// Quality issues identified in this segment. Empty if no issues were found.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationIssue> Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationSegment" /> class.
        /// </summary>
        /// <param name="segmentIndex">
        /// Zero-based index of this segment within the document, in reading order.<br/>
        /// Example: 0
        /// </param>
        /// <param name="segmentScore">
        /// Quality score for this segment, where 0 is lowest and 100 is highest.<br/>
        /// Example: 38.5
        /// </param>
        /// <param name="errors">
        /// Quality issues identified in this segment. Empty if no issues were found.
        /// </param>
        /// <param name="source">
        /// The segment's source text as the evaluation read it. `source_spans` are offsets into this text. Omitted when the text is unavailable. See [Segment text](/api-reference/quality-evaluations/poll#segment-text).<br/>
        /// Example: Our Q3 revenue came in 5% above forecast.
        /// </param>
        /// <param name="target">
        /// The segment's translated text as the evaluation read it. `target_spans` are offsets into this text. Omitted when the text is unavailable. See [Segment text](/api-reference/quality-evaluations/poll#segment-text).<br/>
        /// Example: Unser Q3-Umsatz lag 5 % unter der Prognose.
        /// </param>
        /// <param name="appliedGlossaryTermPairs">
        /// Glossary term pairs applied to this segment when the document was translated, so you can tell which customizations were in play where an issue was reported. Omitted when no term pair was applied.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEvaluationSegment(
            int segmentIndex,
            float segmentScore,
            global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationIssue> errors,
            string? source,
            string? target,
            global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationAppliedGlossaryTermPair>? appliedGlossaryTermPairs)
        {
            this.SegmentIndex = segmentIndex;
            this.SegmentScore = segmentScore;
            this.Source = source;
            this.Target = target;
            this.AppliedGlossaryTermPairs = appliedGlossaryTermPairs;
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationSegment" /> class.
        /// </summary>
        public QualityEvaluationSegment()
        {
        }

    }
}