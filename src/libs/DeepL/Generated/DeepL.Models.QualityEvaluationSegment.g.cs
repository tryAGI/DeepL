
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QualityEvaluationSegment
    {
        /// <summary>
        /// Zero-based index matching the position of this segment in the request.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SegmentIndex { get; set; }

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
        /// Zero-based index matching the position of this segment in the request.<br/>
        /// Example: 0
        /// </param>
        /// <param name="errors">
        /// Quality issues identified in this segment. Empty if no issues were found.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEvaluationSegment(
            int segmentIndex,
            global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationIssue> errors)
        {
            this.SegmentIndex = segmentIndex;
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