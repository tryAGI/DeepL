
#nullable enable

namespace DeepL
{
    /// <summary>
    /// A glossary term pair that was applied to the segment's translation.
    /// </summary>
    public sealed partial class QualityEvaluationAppliedGlossaryTermPair
    {
        /// <summary>
        /// The source term, as defined in the glossary.<br/>
        /// Example: forecast
        /// </summary>
        /// <example>forecast</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_term")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceTerm { get; set; }

        /// <summary>
        /// The target term, as applied to the translation.<br/>
        /// Example: Prognose
        /// </summary>
        /// <example>Prognose</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_term")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetTerm { get; set; }

        /// <summary>
        /// Spans in `target` where the target term was applied, using the same convention as `source_spans` and `target_spans`. See [Span ranges](/api-reference/quality-evaluations/poll#span-ranges).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationSpan> Ranges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationAppliedGlossaryTermPair" /> class.
        /// </summary>
        /// <param name="sourceTerm">
        /// The source term, as defined in the glossary.<br/>
        /// Example: forecast
        /// </param>
        /// <param name="targetTerm">
        /// The target term, as applied to the translation.<br/>
        /// Example: Prognose
        /// </param>
        /// <param name="ranges">
        /// Spans in `target` where the target term was applied, using the same convention as `source_spans` and `target_spans`. See [Span ranges](/api-reference/quality-evaluations/poll#span-ranges).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEvaluationAppliedGlossaryTermPair(
            string sourceTerm,
            string targetTerm,
            global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationSpan> ranges)
        {
            this.SourceTerm = sourceTerm ?? throw new global::System.ArgumentNullException(nameof(sourceTerm));
            this.TargetTerm = targetTerm ?? throw new global::System.ArgumentNullException(nameof(targetTerm));
            this.Ranges = ranges ?? throw new global::System.ArgumentNullException(nameof(ranges));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationAppliedGlossaryTermPair" /> class.
        /// </summary>
        public QualityEvaluationAppliedGlossaryTermPair()
        {
        }

    }
}