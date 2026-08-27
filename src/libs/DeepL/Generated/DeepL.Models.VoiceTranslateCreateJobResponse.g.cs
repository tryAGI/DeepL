
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceTranslateCreateJobResponse
    {
        /// <summary>
        /// The unique identifier of the created job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid JobId { get; set; }

        /// <summary>
        /// The URL to upload the source audio file to via `PUT` with `Content-Type: application/octet-stream`.<br/>
        /// Requires the `Authorization: DeepL-Signature {signature}` header.<br/>
        /// See [Upload File](/api-reference/jobs-voice-translate#upload-file) for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadUrl { get; set; }

        /// <summary>
        /// A short-lived token used to authorize the file upload. Pass it via the `Authorization` header as `DeepL-Signature {signature}` when uploading to the `upload_url`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        /// A pre-signed upload URL that does not require an authorization header. Only present when `?include=signed_url` is specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_upload_url")]
        public string? SignedUploadUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceTranslateCreateJobResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// The unique identifier of the created job.
        /// </param>
        /// <param name="uploadUrl">
        /// The URL to upload the source audio file to via `PUT` with `Content-Type: application/octet-stream`.<br/>
        /// Requires the `Authorization: DeepL-Signature {signature}` header.<br/>
        /// See [Upload File](/api-reference/jobs-voice-translate#upload-file) for details.
        /// </param>
        /// <param name="signature">
        /// A short-lived token used to authorize the file upload. Pass it via the `Authorization` header as `DeepL-Signature {signature}` when uploading to the `upload_url`.
        /// </param>
        /// <param name="signedUploadUrl">
        /// A pre-signed upload URL that does not require an authorization header. Only present when `?include=signed_url` is specified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceTranslateCreateJobResponse(
            global::System.Guid jobId,
            string uploadUrl,
            string signature,
            string? signedUploadUrl)
        {
            this.JobId = jobId;
            this.UploadUrl = uploadUrl ?? throw new global::System.ArgumentNullException(nameof(uploadUrl));
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.SignedUploadUrl = signedUploadUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceTranslateCreateJobResponse" /> class.
        /// </summary>
        public VoiceTranslateCreateJobResponse()
        {
        }

    }
}