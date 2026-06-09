
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QualityEvaluationJobCreated
    {
        /// <summary>
        /// The job identifier. Use it with `GET /v1/quality-evaluation/{job_id}` to poll for the result.<br/>
        /// Example: f3a8c5e1-9b7d-4e62-a1c4-8f5d2b6e3c19
        /// </summary>
        /// <example>f3a8c5e1-9b7d-4e62-a1c4-8f5d2b6e3c19</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid JobId { get; set; }

        /// <summary>
        /// Relative URL you can use to poll for the result.<br/>
        /// Example: /v1/quality-evaluation/f3a8c5e1-9b7d-4e62-a1c4-8f5d2b6e3c19
        /// </summary>
        /// <example>/v1/quality-evaluation/f3a8c5e1-9b7d-4e62-a1c4-8f5d2b6e3c19</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("poll_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PollUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationJobCreated" /> class.
        /// </summary>
        /// <param name="jobId">
        /// The job identifier. Use it with `GET /v1/quality-evaluation/{job_id}` to poll for the result.<br/>
        /// Example: f3a8c5e1-9b7d-4e62-a1c4-8f5d2b6e3c19
        /// </param>
        /// <param name="pollUrl">
        /// Relative URL you can use to poll for the result.<br/>
        /// Example: /v1/quality-evaluation/f3a8c5e1-9b7d-4e62-a1c4-8f5d2b6e3c19
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityEvaluationJobCreated(
            global::System.Guid jobId,
            string pollUrl)
        {
            this.JobId = jobId;
            this.PollUrl = pollUrl ?? throw new global::System.ArgumentNullException(nameof(pollUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityEvaluationJobCreated" /> class.
        /// </summary>
        public QualityEvaluationJobCreated()
        {
        }

    }
}