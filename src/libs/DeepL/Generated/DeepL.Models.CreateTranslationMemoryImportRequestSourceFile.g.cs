
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTranslationMemoryImportRequestSourceFile
    {
        /// <summary>
        /// The name of the TMX file you intend to upload, including its extension. At most 100<br/>
        /// characters.<br/>
        /// Example: legal.tmx
        /// </summary>
        /// <example>legal.tmx</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// The MIME type of the file. Defaults to `application/xml`, which is correct for TMX.<br/>
        /// TMX is currently the only supported import format. At most 127 characters.<br/>
        /// Default Value: application/xml<br/>
        /// Example: application/xml
        /// </summary>
        /// <example>application/xml</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// The size of the file in bytes. Must be greater than 0 and at most 1 GB. An oversize<br/>
        /// value is rejected with `400 Bad Request`.<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ContentLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationMemoryImportRequestSourceFile" /> class.
        /// </summary>
        /// <param name="fileName">
        /// The name of the TMX file you intend to upload, including its extension. At most 100<br/>
        /// characters.<br/>
        /// Example: legal.tmx
        /// </param>
        /// <param name="contentLength">
        /// The size of the file in bytes. Must be greater than 0 and at most 1 GB. An oversize<br/>
        /// value is rejected with `400 Bad Request`.<br/>
        /// Example: 1024
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the file. Defaults to `application/xml`, which is correct for TMX.<br/>
        /// TMX is currently the only supported import format. At most 127 characters.<br/>
        /// Default Value: application/xml<br/>
        /// Example: application/xml
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTranslationMemoryImportRequestSourceFile(
            string fileName,
            long contentLength,
            string? contentType)
        {
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.ContentType = contentType;
            this.ContentLength = contentLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationMemoryImportRequestSourceFile" /> class.
        /// </summary>
        public CreateTranslationMemoryImportRequestSourceFile()
        {
        }

    }
}