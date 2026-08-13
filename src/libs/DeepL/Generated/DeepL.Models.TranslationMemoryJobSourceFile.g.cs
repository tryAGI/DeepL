
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The file declared when the import job was created. Omitted for export jobs.
    /// </summary>
    public sealed partial class TranslationMemoryJobSourceFile
    {
        /// <summary>
        /// The MIME type declared for the uploaded file.<br/>
        /// Example: application/xml
        /// </summary>
        /// <example>application/xml</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// The size in bytes declared for the uploaded file.<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_length")]
        public long? ContentLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemoryJobSourceFile" /> class.
        /// </summary>
        /// <param name="contentType">
        /// The MIME type declared for the uploaded file.<br/>
        /// Example: application/xml
        /// </param>
        /// <param name="contentLength">
        /// The size in bytes declared for the uploaded file.<br/>
        /// Example: 1024
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationMemoryJobSourceFile(
            string? contentType,
            long? contentLength)
        {
            this.ContentType = contentType;
            this.ContentLength = contentLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMemoryJobSourceFile" /> class.
        /// </summary>
        public TranslationMemoryJobSourceFile()
        {
        }

    }
}