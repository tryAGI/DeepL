
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CorrectTextRequest
    {
        /// <summary>
        /// Text to be corrected. Only UTF-8-encoded plain text is supported. Corrections are returned in the same order as they are requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Text { get; set; }

        /// <summary>
        /// The language for the text improvement.<br/>
        /// Example: de
        /// </summary>
        /// <example>de</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_lang")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.TargetLanguageWriteJsonConverter))]
        public global::DeepL.TargetLanguageWrite? TargetLang { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CorrectTextRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// Text to be corrected. Only UTF-8-encoded plain text is supported. Corrections are returned in the same order as they are requested.
        /// </param>
        /// <param name="targetLang">
        /// The language for the text improvement.<br/>
        /// Example: de
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CorrectTextRequest(
            global::System.Collections.Generic.IList<string> text,
            global::DeepL.TargetLanguageWrite? targetLang)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.TargetLang = targetLang;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorrectTextRequest" /> class.
        /// </summary>
        public CorrectTextRequest()
        {
        }

    }
}