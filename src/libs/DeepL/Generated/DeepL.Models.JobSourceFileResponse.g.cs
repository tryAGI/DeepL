
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Metadata about the uploaded source audio file.
    /// </summary>
    public sealed partial class JobSourceFileResponse
    {
        /// <summary>
        /// The file name of the source audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The MIME type of the source audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// The size of the source audio file in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ContentLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobSourceFileResponse" /> class.
        /// </summary>
        /// <param name="name">
        /// The file name of the source audio file.
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the source audio file.
        /// </param>
        /// <param name="contentLength">
        /// The size of the source audio file in bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobSourceFileResponse(
            string name,
            string contentType,
            long contentLength)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.ContentLength = contentLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobSourceFileResponse" /> class.
        /// </summary>
        public JobSourceFileResponse()
        {
        }
    }
}