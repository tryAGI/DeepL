
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTranslationMemoryImportRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.CreateTranslationMemoryImportRequestSourceFile SourceFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::DeepL.CreateTranslationMemoryImportRequestParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationMemoryImportRequest" /> class.
        /// </summary>
        /// <param name="sourceFile"></param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTranslationMemoryImportRequest(
            global::DeepL.CreateTranslationMemoryImportRequestSourceFile sourceFile,
            global::DeepL.CreateTranslationMemoryImportRequestParameters? parameters)
        {
            this.SourceFile = sourceFile ?? throw new global::System.ArgumentNullException(nameof(sourceFile));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationMemoryImportRequest" /> class.
        /// </summary>
        public CreateTranslationMemoryImportRequest()
        {
        }

    }
}