
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The status of a translation memory job and, once it finishes, its output.
    /// </summary>
    public sealed partial class TranslationMemoryJobResult
    {
        /// <summary>
        /// The job's current state:<br/>
        ///  * `awaiting_input` - the job exists but the file has not been uploaded yet (import only)<br/>
        ///  * `processing` - the file was received and is being processed<br/>
        ///  * `completed` - the job finished successfully<br/>
        ///  * `failed` - the job did not finish; see `error`<br/>
        ///  * `expired` - the job is too old to act on; create a new one<br/>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.TranslationMemoryJobResultStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.TranslationMemoryJobResultStatus Status { get; set; }

        /// <summary>
        /// Extra context for states that need you to act. Present only when there is something to do.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_metadata")]
        public global::DeepL.TranslationMemoryJobResultStatusMetadata? StatusMetadata { get; set; }

        /// <summary>
        /// A short-lived URL to download the exported TMX file from. Present on completed export jobs<br/>
        /// only. Download the file rather than storing this URL.<br/>
        /// Example: https://assets.deepl.com/download/7c2e5a91-3b8d-4f16-8e0a-6d4c2b7f9a13
        /// </summary>
        /// <example>https://assets.deepl.com/download/7c2e5a91-3b8d-4f16-8e0a-6d4c2b7f9a13</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// The time `download_url` stops working, in the ISO 8601-1:2019 format. Present on completed<br/>
        /// export jobs only.<br/>
        /// Example: 2026-08-06T16:05:02.771Z
        /// </summary>
        /// <example>2026-08-06T16:05:02.771Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Why the job failed. Present only when `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::DeepL.TranslationMemoryJobResultError? Error { get; set; }

        /// <summary>
        /// A unique ID assigned to a translation memory.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </summary>
        /// <example>a74d88fb-ed2a-4943-a664-a4512398b994</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation_memory_id")]
        public global::System.Guid? TranslationMemoryId { get; set; }

        /// <summary>
        /// How many segments in the uploaded file were not imported, for example because they were<br/>
        /// malformed or duplicated an existing segment. Present on completed import jobs only. A non-zero<br/>
        /// value does not mean the import failed.<br/>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped_segment_count")]
        public long? SkippedSegmentCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemoryJobResult" /> class.
        /// </summary>
        /// <param name="status">
        /// The job's current state:<br/>
        ///  * `awaiting_input` - the job exists but the file has not been uploaded yet (import only)<br/>
        ///  * `processing` - the file was received and is being processed<br/>
        ///  * `completed` - the job finished successfully<br/>
        ///  * `failed` - the job did not finish; see `error`<br/>
        ///  * `expired` - the job is too old to act on; create a new one<br/>
        /// Example: completed
        /// </param>
        /// <param name="statusMetadata">
        /// Extra context for states that need you to act. Present only when there is something to do.
        /// </param>
        /// <param name="downloadUrl">
        /// A short-lived URL to download the exported TMX file from. Present on completed export jobs<br/>
        /// only. Download the file rather than storing this URL.<br/>
        /// Example: https://assets.deepl.com/download/7c2e5a91-3b8d-4f16-8e0a-6d4c2b7f9a13
        /// </param>
        /// <param name="expiresAt">
        /// The time `download_url` stops working, in the ISO 8601-1:2019 format. Present on completed<br/>
        /// export jobs only.<br/>
        /// Example: 2026-08-06T16:05:02.771Z
        /// </param>
        /// <param name="error">
        /// Why the job failed. Present only when `status` is `failed`.
        /// </param>
        /// <param name="translationMemoryId">
        /// A unique ID assigned to a translation memory.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </param>
        /// <param name="skippedSegmentCount">
        /// How many segments in the uploaded file were not imported, for example because they were<br/>
        /// malformed or duplicated an existing segment. Present on completed import jobs only. A non-zero<br/>
        /// value does not mean the import failed.<br/>
        /// Example: 12
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationMemoryJobResult(
            global::DeepL.TranslationMemoryJobResultStatus status,
            global::DeepL.TranslationMemoryJobResultStatusMetadata? statusMetadata,
            string? downloadUrl,
            global::System.DateTime? expiresAt,
            global::DeepL.TranslationMemoryJobResultError? error,
            global::System.Guid? translationMemoryId,
            long? skippedSegmentCount)
        {
            this.Status = status;
            this.StatusMetadata = statusMetadata;
            this.DownloadUrl = downloadUrl;
            this.ExpiresAt = expiresAt;
            this.Error = error;
            this.TranslationMemoryId = translationMemoryId;
            this.SkippedSegmentCount = skippedSegmentCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemoryJobResult" /> class.
        /// </summary>
        public TranslationMemoryJobResult()
        {
        }

    }
}