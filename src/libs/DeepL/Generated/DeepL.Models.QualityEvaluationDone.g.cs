
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QualityEvaluationDone
    {
        /// <summary>
        /// Example: f3a8c5e1-9b7d-4e62-a1c4-8f5d2b6e3c19
        /// </summary>
        /// <example>f3a8c5e1-9b7d-4e62-a1c4-8f5d2b6e3c19</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid JobId { get; set; }

        /// <summary>
        /// Example: done
        /// </summary>
        /// <example>done</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.QualityEvaluationDoneStatusJsonConverter))]
        public global::DeepL.QualityEvaluationDoneStatus Status { get; set; }

        /// <summary>
        /// One entry per submitted segment, in request order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationSegment> Segments { get; set; }

        /// <summary>
        /// Aggregate quality results across all segments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.QualityEvaluationDoneSummary Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationDone" /> class.
        /// </summary>
        /// <param name="jobId">
        /// Example: f3a8c5e1-9b7d-4e62-a1c4-8f5d2b6e3c19
        /// </param>
        /// <param name="segments">
        /// One entry per submitted segment, in request order.
        /// </param>
        /// <param name="summary">
        /// Aggregate quality results across all segments.
        /// </param>
        /// <param name="status">
        /// Example: done
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEvaluationDone(
            global::System.Guid jobId,
            global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationSegment> segments,
            global::DeepL.QualityEvaluationDoneSummary summary,
            global::DeepL.QualityEvaluationDoneStatus status)
        {
            this.JobId = jobId;
            this.Status = status;
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationDone" /> class.
        /// </summary>
        public QualityEvaluationDone()
        {
        }

    }
}