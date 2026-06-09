
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Aggregate counts of issues across all segments.
    /// </summary>
    public sealed partial class QualityEvaluationDoneSummary
    {
        /// <summary>
        /// Nested counts keyed by `type`, then `sub_type`, then `severity`. Leaf values are integer counts.<br/>
        /// Example: {"Accuracy":{"Mistranslation":{"Critical":1,"Minor":1},"Omission":{"Major":1}}}
        /// </summary>
        /// <example>{"Accuracy":{"Mistranslation":{"Critical":1,"Minor":1},"Omission":{"Major":1}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("granular_counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object GranularCounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationDoneSummary" /> class.
        /// </summary>
        /// <param name="granularCounts">
        /// Nested counts keyed by `type`, then `sub_type`, then `severity`. Leaf values are integer counts.<br/>
        /// Example: {"Accuracy":{"Mistranslation":{"Critical":1,"Minor":1},"Omission":{"Major":1}}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEvaluationDoneSummary(
            object granularCounts)
        {
            this.GranularCounts = granularCounts ?? throw new global::System.ArgumentNullException(nameof(granularCounts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationDoneSummary" /> class.
        /// </summary>
        public QualityEvaluationDoneSummary()
        {
        }

    }
}