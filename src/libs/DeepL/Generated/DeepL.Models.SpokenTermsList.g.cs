
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpokenTermsList
    {
        /// <summary>
        /// Language code (ISO 639-1).<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lang")]
        public string? Lang { get; set; }

        /// <summary>
        /// Number of terms in this list.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entry_count")]
        public int? EntryCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpokenTermsList" /> class.
        /// </summary>
        /// <param name="lang">
        /// Language code (ISO 639-1).<br/>
        /// Example: en
        /// </param>
        /// <param name="entryCount">
        /// Number of terms in this list.<br/>
        /// Example: 3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpokenTermsList(
            string? lang,
            int? entryCount)
        {
            this.Lang = lang;
            this.EntryCount = entryCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpokenTermsList" /> class.
        /// </summary>
        public SpokenTermsList()
        {
        }

    }
}