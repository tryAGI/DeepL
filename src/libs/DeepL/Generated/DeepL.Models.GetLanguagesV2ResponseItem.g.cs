
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetLanguagesV2ResponseItem
    {
        /// <summary>
        /// The language code of the given language.<br/>
        /// Example: DE
        /// </summary>
        /// <example>DE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Name of the language in English.<br/>
        /// Example: German
        /// </summary>
        /// <example>German</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Denotes formality support in case of a target language listing.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_formality")]
        public bool? SupportsFormality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLanguagesV2ResponseItem" /> class.
        /// </summary>
        /// <param name="language">
        /// The language code of the given language.<br/>
        /// Example: DE
        /// </param>
        /// <param name="name">
        /// Name of the language in English.<br/>
        /// Example: German
        /// </param>
        /// <param name="supportsFormality">
        /// Denotes formality support in case of a target language listing.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLanguagesV2ResponseItem(
            string language,
            string name,
            bool? supportsFormality)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SupportsFormality = supportsFormality;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLanguagesV2ResponseItem" /> class.
        /// </summary>
        public GetLanguagesV2ResponseItem()
        {
        }

    }
}