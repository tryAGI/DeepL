
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpokenTermsEntries
    {
        /// <summary>
        /// Language code (ISO 639-1).<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lang")]
        public string? Lang { get; set; }

        /// <summary>
        /// Newline-separated list of terms.<br/>
        /// Example: DeepL<br/>
        /// API<br/>
        /// webhook
        /// </summary>
        /// <example>
        /// DeepL<br/>
        /// API<br/>
        /// webhook
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        public string? Entries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpokenTermsEntries" /> class.
        /// </summary>
        /// <param name="lang">
        /// Language code (ISO 639-1).<br/>
        /// Example: en
        /// </param>
        /// <param name="entries">
        /// Newline-separated list of terms.<br/>
        /// Example: DeepL<br/>
        /// API<br/>
        /// webhook
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpokenTermsEntries(
            string? lang,
            string? entries)
        {
            this.Lang = lang;
            this.Entries = entries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpokenTermsEntries" /> class.
        /// </summary>
        public SpokenTermsEntries()
        {
        }

    }
}