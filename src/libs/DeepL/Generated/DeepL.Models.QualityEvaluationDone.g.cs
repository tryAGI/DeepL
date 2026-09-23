
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualityEvaluationDone
    {
        /// <summary>
        /// Example: 04DE5AD98A02647D83285A36021911C6
        /// </summary>
        /// <example>04DE5AD98A02647D83285A36021911C6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// Example: done
        /// </summary>
        /// <example>done</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.QualityEvaluationDoneStatusJsonConverter))]
        public global::DeepL.QualityEvaluationDoneStatus Status { get; set; }

        /// <summary>
        /// One entry per evaluated segment of the document, in reading order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationSegment> Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationDone" /> class.
        /// </summary>
        /// <param name="jobId">
        /// Example: 04DE5AD98A02647D83285A36021911C6
        /// </param>
        /// <param name="segments">
        /// One entry per evaluated segment of the document, in reading order.
        /// </param>
        /// <param name="status">
        /// Example: done
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEvaluationDone(
            string jobId,
            global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationSegment> segments,
            global::DeepL.QualityEvaluationDoneStatus status)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.Status = status;
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationDone" /> class.
        /// </summary>
        public QualityEvaluationDone()
        {
        }

    }
}