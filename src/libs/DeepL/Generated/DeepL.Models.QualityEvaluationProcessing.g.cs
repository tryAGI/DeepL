
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualityEvaluationProcessing
    {
        /// <summary>
        /// Example: f3a8c5e1-9b7d-4e62-a1c4-8f5d2b6e3c19
        /// </summary>
        /// <example>f3a8c5e1-9b7d-4e62-a1c4-8f5d2b6e3c19</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid JobId { get; set; }

        /// <summary>
        /// Example: processing
        /// </summary>
        /// <example>processing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.QualityEvaluationProcessingStatusJsonConverter))]
        public global::DeepL.QualityEvaluationProcessingStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationProcessing" /> class.
        /// </summary>
        /// <param name="jobId">
        /// Example: f3a8c5e1-9b7d-4e62-a1c4-8f5d2b6e3c19
        /// </param>
        /// <param name="status">
        /// Example: processing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEvaluationProcessing(
            global::System.Guid jobId,
            global::DeepL.QualityEvaluationProcessingStatus status)
        {
            this.JobId = jobId;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationProcessing" /> class.
        /// </summary>
        public QualityEvaluationProcessing()
        {
        }

    }
}