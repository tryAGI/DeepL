
#nullable enable

namespace DeepL
{
    /// <summary>
    /// A dictionary contained in a multilingual glossary. Each dictionary contains the mapping of source terms to target language terms.
    /// </summary>
    public sealed partial class GlossaryDictionary
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
        /// The entries of the glossary. The entries have to be specified in the format provided by the `entries_format` parameter.<br/>
        /// Example: Hello	Guten Tag
        /// </summary>
        /// <example>Hello	Guten Tag</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        public string? Entries { get; set; }

        /// <summary>
        /// The format in which the glossary entries are provided. Formats currently available:<br/>
        /// - `tsv` (default) - tab-separated values<br/>
        /// - `csv` - comma-separated values<br/>
        /// See [Supported Glossary Formats](/docs/customize/managing-glossaries#entry-formats) for details about each format.<br/>
        /// Default Value: tsv<br/>
        /// Example: tsv
        /// </summary>
        /// <example>tsv</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.GlossaryEntriesFormatJsonConverter))]
        public global::DeepL.GlossaryEntriesFormat? EntriesFormat { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entry_count")]
        public int? EntryCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlossaryDictionary" /> class.
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
        /// <param name="entries">
        /// The entries of the glossary. The entries have to be specified in the format provided by the `entries_format` parameter.<br/>
        /// Example: Hello	Guten Tag
        /// </param>
        /// <param name="entriesFormat">
        /// The format in which the glossary entries are provided. Formats currently available:<br/>
        /// - `tsv` (default) - tab-separated values<br/>
        /// - `csv` - comma-separated values<br/>
        /// See [Supported Glossary Formats](/docs/customize/managing-glossaries#entry-formats) for details about each format.<br/>
        /// Default Value: tsv<br/>
        /// Example: tsv
        /// </param>
        /// <param name="entryCount">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GlossaryDictionary(
            global::DeepL.GlossarySourceLanguage? sourceLang,
            global::DeepL.MultilingualGlossaryTargetLanguage? targetLang,
            string? entries,
            global::DeepL.GlossaryEntriesFormat? entriesFormat,
            int? entryCount)
        {
            this.SourceLang = sourceLang;
            this.TargetLang = targetLang;
            this.Entries = entries;
            this.EntriesFormat = entriesFormat;
            this.EntryCount = entryCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlossaryDictionary" /> class.
        /// </summary>
        public GlossaryDictionary()
        {
        }

    }
}