
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetLanguageResourcesResponseItem
    {
        /// <summary>
        /// The resource identifier.<br/>
        /// Example: translate_text
        /// </summary>
        /// <example>translate_text</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.GetLanguageResourcesResponseItemNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.GetLanguageResourcesResponseItemName Name { get; set; }

        /// <summary>
        /// Features supported by this resource. Each feature indicates which languages<br/>
        /// must support it for the feature to be available — source, target, or both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepL.GetLanguageResourcesResponseItemFeature> Features { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLanguageResourcesResponseItem" /> class.
        /// </summary>
        /// <param name="name">
        /// The resource identifier.<br/>
        /// Example: translate_text
        /// </param>
        /// <param name="features">
        /// Features supported by this resource. Each feature indicates which languages<br/>
        /// must support it for the feature to be available — source, target, or both.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLanguageResourcesResponseItem(
            global::DeepL.GetLanguageResourcesResponseItemName name,
            global::System.Collections.Generic.IList<global::DeepL.GetLanguageResourcesResponseItemFeature> features)
        {
            this.Name = name;
            this.Features = features ?? throw new global::System.ArgumentNullException(nameof(features));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLanguageResourcesResponseItem" /> class.
        /// </summary>
        public GetLanguageResourcesResponseItem()
        {
        }

    }
}