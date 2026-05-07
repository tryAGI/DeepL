
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Metadata about the source audio file to be uploaded.
    /// </summary>
    public sealed partial class JobSourceFileRequest
    {
        /// <summary>
        /// The file name of the source audio file.<br/>
        /// Example: podcast-episode-42.mp3
        /// </summary>
        /// <example>podcast-episode-42.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The MIME type of the source audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.VoiceTranslateJobSourceContentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.VoiceTranslateJobSourceContentType ContentType { get; set; }

        /// <summary>
        /// The size of the source audio file in bytes. Maximum 1 GB (1,073,741,824 bytes).<br/>
        /// Example: 15728640
        /// </summary>
        /// <example>15728640</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ContentLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobSourceFileRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The file name of the source audio file.<br/>
        /// Example: podcast-episode-42.mp3
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the source audio file.
        /// </param>
        /// <param name="contentLength">
        /// The size of the source audio file in bytes. Maximum 1 GB (1,073,741,824 bytes).<br/>
        /// Example: 15728640
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobSourceFileRequest(
            string name,
            global::DeepL.VoiceTranslateJobSourceContentType contentType,
            long contentLength)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ContentType = contentType;
            this.ContentLength = contentLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobSourceFileRequest" /> class.
        /// </summary>
        public JobSourceFileRequest()
        {
        }
    }
}