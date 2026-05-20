
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The processing result for a single translation target.
    /// </summary>
    public sealed partial class VoiceTranslateJobTargetResult
    {
        /// <summary>
        /// The processing status of a target result.<br/>
        /// - `pending`: Job created, awaiting file upload.<br/>
        /// - `uploaded`: File uploaded, awaiting processing.<br/>
        /// - `processing`: Translation in progress.<br/>
        /// - `complete`: Translation complete, result available for download.<br/>
        /// - `downloaded`: Result has been downloaded. Assets are marked for deletion.<br/>
        /// - `failed`: Processing failed. See the `error` field for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ResultStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.ResultStatus Status { get; set; }

        /// <summary>
        /// The URL to download the translated result via `GET`.<br/>
        /// Requires the `Authorization: DeepL-Signature {signature}` header.<br/>
        /// Only present when `status` is `complete`.<br/>
        /// See [Download Result](/api-reference/jobs-voice-translate#download-result) for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// A short-lived token used to authorize the result download. Only present when `status` is `complete`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// A pre-signed download URL that does not require an authorization header. Only present when `status` is `complete` and `?include=signed_url` is specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_download_url")]
        public string? SignedDownloadUrl { get; set; }

        /// <summary>
        /// Details about the processing failure. Only present when `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::DeepL.ErrorResponse? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceTranslateJobTargetResult" /> class.
        /// </summary>
        /// <param name="status">
        /// The processing status of a target result.<br/>
        /// - `pending`: Job created, awaiting file upload.<br/>
        /// - `uploaded`: File uploaded, awaiting processing.<br/>
        /// - `processing`: Translation in progress.<br/>
        /// - `complete`: Translation complete, result available for download.<br/>
        /// - `downloaded`: Result has been downloaded. Assets are marked for deletion.<br/>
        /// - `failed`: Processing failed. See the `error` field for details.
        /// </param>
        /// <param name="downloadUrl">
        /// The URL to download the translated result via `GET`.<br/>
        /// Requires the `Authorization: DeepL-Signature {signature}` header.<br/>
        /// Only present when `status` is `complete`.<br/>
        /// See [Download Result](/api-reference/jobs-voice-translate#download-result) for details.
        /// </param>
        /// <param name="signature">
        /// A short-lived token used to authorize the result download. Only present when `status` is `complete`.
        /// </param>
        /// <param name="signedDownloadUrl">
        /// A pre-signed download URL that does not require an authorization header. Only present when `status` is `complete` and `?include=signed_url` is specified.
        /// </param>
        /// <param name="error">
        /// Details about the processing failure. Only present when `status` is `failed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceTranslateJobTargetResult(
            global::DeepL.ResultStatus status,
            string? downloadUrl,
            string? signature,
            string? signedDownloadUrl,
            global::DeepL.ErrorResponse? error)
        {
            this.Status = status;
            this.DownloadUrl = downloadUrl;
            this.Signature = signature;
            this.SignedDownloadUrl = signedDownloadUrl;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceTranslateJobTargetResult" /> class.
        /// </summary>
        public VoiceTranslateJobTargetResult()
        {
        }

    }
}