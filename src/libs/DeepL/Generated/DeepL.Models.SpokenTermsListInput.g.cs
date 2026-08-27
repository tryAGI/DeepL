
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpokenTermsListInput
    {
        /// <summary>
        /// Language code (ISO 639-1) for this term list.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lang")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lang { get; set; }

        /// <summary>
        /// Newline-separated list of terms, one term per line. Maximum 300 characters total.<br/>
        /// Terms are case-sensitive. Each term must be non-empty, must not contain C0 or C1 control characters (such as tabs or newlines within a term), and must not have leading or trailing whitespace. Duplicate terms within a list are not allowed (comparison is case-sensitive).<br/>
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Entries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpokenTermsListInput" /> class.
        /// </summary>
        /// <param name="lang">
        /// Language code (ISO 639-1) for this term list.<br/>
        /// Example: en
        /// </param>
        /// <param name="entries">
        /// Newline-separated list of terms, one term per line. Maximum 300 characters total.<br/>
        /// Terms are case-sensitive. Each term must be non-empty, must not contain C0 or C1 control characters (such as tabs or newlines within a term), and must not have leading or trailing whitespace. Duplicate terms within a list are not allowed (comparison is case-sensitive).<br/>
        /// Example: DeepL<br/>
        /// API<br/>
        /// webhook
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpokenTermsListInput(
            string lang,
            string entries)
        {
            this.Lang = lang ?? throw new global::System.ArgumentNullException(nameof(lang));
            this.Entries = entries ?? throw new global::System.ArgumentNullException(nameof(entries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpokenTermsListInput" /> class.
        /// </summary>
        public SpokenTermsListInput()
        {
        }

    }
}