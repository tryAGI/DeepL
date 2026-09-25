
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualityEvaluationProcessing
    {
        /// <summary>
        /// Example: 04DE5AD98A02647D83285A36021911C6
        /// </summary>
        /// <example>04DE5AD98A02647D83285A36021911C6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

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
        /// Example: 04DE5AD98A02647D83285A36021911C6
        /// </param>
        /// <param name="status">
        /// Example: processing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEvaluationProcessing(
            string jobId,
            global::DeepL.QualityEvaluationProcessingStatus status)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
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