
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTranslationMemoryImportResponse
    {
        /// <summary>
        /// The identifier of the import job. Use it to poll the job's status.<br/>
        /// Example: 0f8b6c1e-4d2a-4c77-9a3e-1b5d8c9e2f40
        /// </summary>
        /// <example>0f8b6c1e-4d2a-4c77-9a3e-1b5d8c9e2f40</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid JobId { get; set; }

        /// <summary>
        /// A signed URL to `PUT` the TMX file to. Do not send your `Authorization` header with the<br/>
        /// upload request.<br/>
        /// Example: https://assets.deepl.com/upload/0f8b6c1e-4d2a-4c77-9a3e-1b5d8c9e2f40
        /// </summary>
        /// <example>https://assets.deepl.com/upload/0f8b6c1e-4d2a-4c77-9a3e-1b5d8c9e2f40</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadUrl { get; set; }

        /// <summary>
        /// The time the `upload_url` stops accepting uploads, in the ISO 8601-1:2019 format. After<br/>
        /// this time, create a new import job.<br/>
        /// Example: 2026-08-06T15:34:25.223Z
        /// </summary>
        /// <example>2026-08-06T15:34:25.223Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationMemoryImportResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// The identifier of the import job. Use it to poll the job's status.<br/>
        /// Example: 0f8b6c1e-4d2a-4c77-9a3e-1b5d8c9e2f40
        /// </param>
        /// <param name="uploadUrl">
        /// A signed URL to `PUT` the TMX file to. Do not send your `Authorization` header with the<br/>
        /// upload request.<br/>
        /// Example: https://assets.deepl.com/upload/0f8b6c1e-4d2a-4c77-9a3e-1b5d8c9e2f40
        /// </param>
        /// <param name="expiresAt">
        /// The time the `upload_url` stops accepting uploads, in the ISO 8601-1:2019 format. After<br/>
        /// this time, create a new import job.<br/>
        /// Example: 2026-08-06T15:34:25.223Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTranslationMemoryImportResponse(
            global::System.Guid jobId,
            string uploadUrl,
            global::System.DateTime expiresAt)
        {
            this.JobId = jobId;
            this.UploadUrl = uploadUrl ?? throw new global::System.ArgumentNullException(nameof(uploadUrl));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationMemoryImportResponse" /> class.
        /// </summary>
        public CreateTranslationMemoryImportResponse()
        {
        }

    }
}