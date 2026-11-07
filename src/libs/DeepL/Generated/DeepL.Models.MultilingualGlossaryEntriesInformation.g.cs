
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MultilingualGlossaryEntriesInformation
    {
        /// <summary>
        /// The language in which the source texts in the glossary are specified.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_lang")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.GlossarySourceLanguageJsonConverter))]
        public global::DeepL.GlossarySourceLanguage? SourceLang { get; set; }

        /// <summary>
        /// The language in which the target texts in the dictionary are specified. Besides the base languages, the<br/>
        /// target can be one of these variants: `de-CH`, `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-CA`,<br/>
        /// `fr-FR`, `pt-BR`, `pt-PT`, `zh-Hans`, or `zh-Hant`. Source languages are always base languages. The current<br/>
        /// list is returned by `GET /v3/languages?resource=glossary`.<br/>
        /// A dictionary with a base target, such as `de`, applies when translating into that language and any of its<br/>
        /// variants. A dictionary with a variant target, such as `de-CH`, applies only when translating into that<br/>
        /// exact variant.<br/>
        /// Within one glossary, each language family uses either the base language or its variants as targets, not<br/>
        /// both. For example, `de-CH` and `de-DE` can be combined, but `de` and `de-DE` cannot. Adding a dictionary<br/>
        /// that breaks this rule returns a 400 error.<br/>
        /// Example: de
        /// </summary>
        /// <example>de</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_lang")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.MultilingualGlossaryTargetLanguageJsonConverter))]
        public global::DeepL.MultilingualGlossaryTargetLanguage? TargetLang { get; set; }

        /// <summary>
        /// The number of entries in the glossary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entry_count")]
        public int? EntryCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualGlossaryEntriesInformation" /> class.
        /// </summary>
        /// <param name="sourceLang">
        /// The language in which the source texts in the glossary are specified.<br/>
        /// Example: en
        /// </param>
        /// <param name="targetLang">
        /// The language in which the target texts in the dictionary are specified. Besides the base languages, the<br/>
        /// target can be one of these variants: `de-CH`, `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-CA`,<br/>
        /// `fr-FR`, `pt-BR`, `pt-PT`, `zh-Hans`, or `zh-Hant`. Source languages are always base languages. The current<br/>
        /// list is returned by `GET /v3/languages?resource=glossary`.<br/>
        /// A dictionary with a base target, such as `de`, applies when translating into that language and any of its<br/>
        /// variants. A dictionary with a variant target, such as `de-CH`, applies only when translating into that<br/>
        /// exact variant.<br/>
        /// Within one glossary, each language family uses either the base language or its variants as targets, not<br/>
        /// both. For example, `de-CH` and `de-DE` can be combined, but `de` and `de-DE` cannot. Adding a dictionary<br/>
        /// that breaks this rule returns a 400 error.<br/>
        /// Example: de
        /// </param>
        /// <param name="entryCount">
        /// The number of entries in the glossary.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultilingualGlossaryEntriesInformation(
            global::DeepL.GlossarySourceLanguage? sourceLang,
            global::DeepL.MultilingualGlossaryTargetLanguage? targetLang,
            int? entryCount)
        {
            this.SourceLang = sourceLang;
            this.TargetLang = targetLang;
            this.EntryCount = entryCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualGlossaryEntriesInformation" /> class.
        /// </summary>
        public MultilingualGlossaryEntriesInformation()
        {
        }

    }
}