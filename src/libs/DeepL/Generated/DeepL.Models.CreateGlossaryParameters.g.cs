
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGlossaryParameters
    {
        /// <summary>
        /// Name to be associated with the glossary.<br/>
        /// Example: My Glossary
        /// </summary>
        /// <example>My Glossary</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The language in which the source texts in the glossary are specified.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_lang")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.GlossarySourceLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.GlossarySourceLanguage SourceLang { get; set; }

        /// <summary>
        /// The language in which the target texts in the glossary are specified.<br/>
        /// Example: de
        /// </summary>
        /// <example>de</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_lang")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.GlossaryTargetLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.GlossaryTargetLanguage TargetLang { get; set; }

        /// <summary>
        /// The entries of the glossary. The entries have to be specified in the format provided by the `entries_format` parameter.<br/>
        /// Example: Hello	Guten Tag
        /// </summary>
        /// <example>Hello	Guten Tag</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Entries { get; set; }

        /// <summary>
        /// The format in which the glossary entries are provided. Formats currently available:<br/>
        /// - `tsv` (default) - tab-separated values<br/>
        /// - `csv` - comma-separated values<br/>
        /// See [Supported Glossary Formats](https://www.deepl.com/docs-api/glossaries/formats) for details about each format.<br/>
        /// Default Value: tsv<br/>
        /// Example: tsv
        /// </summary>
        /// <default>global::DeepL.CreateGlossaryParametersEntriesFormat.Tsv</default>
        /// <example>tsv</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.CreateGlossaryParametersEntriesFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.CreateGlossaryParametersEntriesFormat EntriesFormat { get; set; } = global::DeepL.CreateGlossaryParametersEntriesFormat.Tsv;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGlossaryParameters" /> class.
        /// </summary>
        /// <param name="name">
        /// Name to be associated with the glossary.<br/>
        /// Example: My Glossary
        /// </param>
        /// <param name="sourceLang">
        /// The language in which the source texts in the glossary are specified.<br/>
        /// Example: en
        /// </param>
        /// <param name="targetLang">
        /// The language in which the target texts in the glossary are specified.<br/>
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
        /// See [Supported Glossary Formats](https://www.deepl.com/docs-api/glossaries/formats) for details about each format.<br/>
        /// Default Value: tsv<br/>
        /// Example: tsv
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGlossaryParameters(
            string name,
            global::DeepL.GlossarySourceLanguage sourceLang,
            global::DeepL.GlossaryTargetLanguage targetLang,
            string entries,
            global::DeepL.CreateGlossaryParametersEntriesFormat entriesFormat)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SourceLang = sourceLang;
            this.TargetLang = targetLang;
            this.Entries = entries ?? throw new global::System.ArgumentNullException(nameof(entries));
            this.EntriesFormat = entriesFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGlossaryParameters" /> class.
        /// </summary>
        public CreateGlossaryParameters()
        {
        }
    }
}