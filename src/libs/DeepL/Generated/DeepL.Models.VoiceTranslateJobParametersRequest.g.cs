
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Processing parameters for the voice translation job.
    /// </summary>
    public sealed partial class VoiceTranslateJobParametersRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.AllOfJsonConverter<string, object>))]
        public global::DeepL.AllOf<string, object>? SourceLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceTranslateJobParametersRequest" /> class.
        /// </summary>
        /// <param name="sourceLanguage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceTranslateJobParametersRequest(
            global::DeepL.AllOf<string, object>? sourceLanguage)
        {
            this.SourceLanguage = sourceLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceTranslateJobParametersRequest" /> class.
        /// </summary>
        public VoiceTranslateJobParametersRequest()
        {
        }
    }
}