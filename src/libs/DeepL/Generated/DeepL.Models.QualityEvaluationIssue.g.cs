
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QualityEvaluationIssue
    {
        /// <summary>
        /// Top-level category of the issue. See [Type and sub-type values](/api-reference/quality-evaluation/poll#type-and-sub-type-values).<br/>
        /// Example: Accuracy
        /// </summary>
        /// <example>Accuracy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.QualityEvaluationIssueTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.QualityEvaluationIssueType Type { get; set; }

        /// <summary>
        /// Finer-grained category within `type`. See [Type and sub-type values](/api-reference/quality-evaluation/poll#type-and-sub-type-values).<br/>
        /// Example: Mistranslation
        /// </summary>
        /// <example>Mistranslation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.QualityEvaluationIssueSubTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.QualityEvaluationIssueSubType SubType { get; set; }

        /// <summary>
        /// How serious the issue is. See [Severity values](/api-reference/quality-evaluation/poll#severity-values).<br/>
        /// Example: Critical
        /// </summary>
        /// <example>Critical</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.QualityEvaluationIssueSeverityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.QualityEvaluationIssueSeverity Severity { get; set; }

        /// <summary>
        /// Description of the issue. May span multiple sentences.<br/>
        /// Example: The source says revenue was '5% above forecast' but the translation says '5 % unter der Prognose' (5% below forecast). This completely reverses the meaning and has financial implications.
        /// </summary>
        /// <example>The source says revenue was '5% above forecast' but the translation says '5 % unter der Prognose' (5% below forecast). This completely reverses the meaning and has financial implications.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("explanation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Explanation { get; set; }

        /// <summary>
        /// Spans on the segment's source text where this issue applies. Empty if no source-side highlight. See [About span ranges](/api-reference/quality-evaluation/poll#about-span-ranges).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_spans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationSpan> SourceSpans { get; set; }

        /// <summary>
        /// Spans on the segment's target text where this issue applies. Empty if no target-side highlight. See [About span ranges](/api-reference/quality-evaluation/poll#about-span-ranges).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_spans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationSpan> TargetSpans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationIssue" /> class.
        /// </summary>
        /// <param name="type">
        /// Top-level category of the issue. See [Type and sub-type values](/api-reference/quality-evaluation/poll#type-and-sub-type-values).<br/>
        /// Example: Accuracy
        /// </param>
        /// <param name="subType">
        /// Finer-grained category within `type`. See [Type and sub-type values](/api-reference/quality-evaluation/poll#type-and-sub-type-values).<br/>
        /// Example: Mistranslation
        /// </param>
        /// <param name="severity">
        /// How serious the issue is. See [Severity values](/api-reference/quality-evaluation/poll#severity-values).<br/>
        /// Example: Critical
        /// </param>
        /// <param name="explanation">
        /// Description of the issue. May span multiple sentences.<br/>
        /// Example: The source says revenue was '5% above forecast' but the translation says '5 % unter der Prognose' (5% below forecast). This completely reverses the meaning and has financial implications.
        /// </param>
        /// <param name="sourceSpans">
        /// Spans on the segment's source text where this issue applies. Empty if no source-side highlight. See [About span ranges](/api-reference/quality-evaluation/poll#about-span-ranges).
        /// </param>
        /// <param name="targetSpans">
        /// Spans on the segment's target text where this issue applies. Empty if no target-side highlight. See [About span ranges](/api-reference/quality-evaluation/poll#about-span-ranges).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEvaluationIssue(
            global::DeepL.QualityEvaluationIssueType type,
            global::DeepL.QualityEvaluationIssueSubType subType,
            global::DeepL.QualityEvaluationIssueSeverity severity,
            string explanation,
            global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationSpan> sourceSpans,
            global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationSpan> targetSpans)
        {
            this.Type = type;
            this.SubType = subType;
            this.Severity = severity;
            this.Explanation = explanation ?? throw new global::System.ArgumentNullException(nameof(explanation));
            this.SourceSpans = sourceSpans ?? throw new global::System.ArgumentNullException(nameof(sourceSpans));
            this.TargetSpans = targetSpans ?? throw new global::System.ArgumentNullException(nameof(targetSpans));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationIssue" /> class.
        /// </summary>
        public QualityEvaluationIssue()
        {
        }

    }
}