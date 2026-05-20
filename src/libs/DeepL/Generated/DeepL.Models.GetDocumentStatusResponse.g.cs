
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDocumentStatusResponse
    {
        /// <summary>
        /// A unique ID assigned to the uploaded document and the requested translation process. The same ID that was used when requesting the translation status.<br/>
        /// Example: 04DE5AD98A02647D83285A36021911C6
        /// </summary>
        /// <example>04DE5AD98A02647D83285A36021911C6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentId { get; set; }

        /// <summary>
        /// A short description of the state the document translation process is currently in. Possible values are:<br/>
        ///  * `queued` - the translation job is waiting in line to be processed<br/>
        ///  * `translating` - the translation is currently ongoing<br/>
        ///  * `done` - the translation is done and the translated document is ready for download<br/>
        ///  * `error` - an irrecoverable error occurred while translating the document<br/>
        /// Example: done
        /// </summary>
        /// <example>done</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.GetDocumentStatusResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.GetDocumentStatusResponseStatus Status { get; set; }

        /// <summary>
        /// Estimated number of seconds until the translation is done.<br/>
        /// This parameter is only included while `status` is `"translating"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds_remaining")]
        public int? SecondsRemaining { get; set; }

        /// <summary>
        /// The number of characters billed to your account. The characters will only be billed after a successful download request.<br/>
        /// Example: 1337
        /// </summary>
        /// <example>1337</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("billed_characters")]
        public int? BilledCharacters { get; set; }

        /// <summary>
        /// A short description of the error, if available.<br/>
        /// Note that the content is subject to change.<br/>
        /// This parameter may be included if an error occurred during translation.<br/>
        /// Example: Only available if document status is error
        /// </summary>
        /// <example>Only available if document status is error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentStatusResponse" /> class.
        /// </summary>
        /// <param name="documentId">
        /// A unique ID assigned to the uploaded document and the requested translation process. The same ID that was used when requesting the translation status.<br/>
        /// Example: 04DE5AD98A02647D83285A36021911C6
        /// </param>
        /// <param name="status">
        /// A short description of the state the document translation process is currently in. Possible values are:<br/>
        ///  * `queued` - the translation job is waiting in line to be processed<br/>
        ///  * `translating` - the translation is currently ongoing<br/>
        ///  * `done` - the translation is done and the translated document is ready for download<br/>
        ///  * `error` - an irrecoverable error occurred while translating the document<br/>
        /// Example: done
        /// </param>
        /// <param name="secondsRemaining">
        /// Estimated number of seconds until the translation is done.<br/>
        /// This parameter is only included while `status` is `"translating"`.
        /// </param>
        /// <param name="billedCharacters">
        /// The number of characters billed to your account. The characters will only be billed after a successful download request.<br/>
        /// Example: 1337
        /// </param>
        /// <param name="errorMessage">
        /// A short description of the error, if available.<br/>
        /// Note that the content is subject to change.<br/>
        /// This parameter may be included if an error occurred during translation.<br/>
        /// Example: Only available if document status is error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDocumentStatusResponse(
            string documentId,
            global::DeepL.GetDocumentStatusResponseStatus status,
            int? secondsRemaining,
            int? billedCharacters,
            string? errorMessage)
        {
            this.DocumentId = documentId ?? throw new global::System.ArgumentNullException(nameof(documentId));
            this.Status = status;
            this.SecondsRemaining = secondsRemaining;
            this.BilledCharacters = billedCharacters;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentStatusResponse" /> class.
        /// </summary>
        public GetDocumentStatusResponse()
        {
        }

    }
}