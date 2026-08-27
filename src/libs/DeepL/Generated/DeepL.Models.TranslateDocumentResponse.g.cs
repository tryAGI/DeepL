
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TranslateDocumentResponse
    {
        /// <summary>
        /// A unique ID assigned to the uploaded document and the translation process. Must be used when referring to this particular document in subsequent API requests.<br/>
        /// Example: 04DE5AD98A02647D83285A36021911C6
        /// </summary>
        /// <example>04DE5AD98A02647D83285A36021911C6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// A unique key that is used to encrypt the uploaded document as well as the resulting translation on the server side. Must be provided with every subsequent API request regarding this particular document.<br/>
        /// Example: 0CB0054F1C132C1625B392EADDA41CB754A742822F6877173029A6C487E7F60A
        /// </summary>
        /// <example>0CB0054F1C132C1625B392EADDA41CB754A742822F6877173029A6C487E7F60A</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_key")]
        public string? DocumentKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateDocumentResponse" /> class.
        /// </summary>
        /// <param name="documentId">
        /// A unique ID assigned to the uploaded document and the translation process. Must be used when referring to this particular document in subsequent API requests.<br/>
        /// Example: 04DE5AD98A02647D83285A36021911C6
        /// </param>
        /// <param name="documentKey">
        /// A unique key that is used to encrypt the uploaded document as well as the resulting translation on the server side. Must be provided with every subsequent API request regarding this particular document.<br/>
        /// Example: 0CB0054F1C132C1625B392EADDA41CB754A742822F6877173029A6C487E7F60A
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslateDocumentResponse(
            string? documentId,
            string? documentKey)
        {
            this.DocumentId = documentId;
            this.DocumentKey = documentKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateDocumentResponse" /> class.
        /// </summary>
        public TranslateDocumentResponse()
        {
        }

    }
}