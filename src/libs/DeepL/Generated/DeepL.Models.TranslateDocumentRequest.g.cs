
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslateDocumentRequest
    {
        /// <summary>
        /// Language of the text to be translated. If this parameter is omitted, the API will attempt to<br/>
        /// detect the language of the text and translate it.<br/>
        /// For the full list of supported source languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource).<br/>
        /// Example: EN
        /// </summary>
        /// <example>EN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_lang")]
        public string? SourceLang { get; set; }

        /// <summary>
        /// The language into which the text should be translated.<br/>
        /// For the full list of supported target languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource).<br/>
        /// Example: DE
        /// </summary>
        /// <example>DE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_lang")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetLang { get; set; }

        /// <summary>
        /// The document file to be translated. The file name should be included in this part's content disposition. As an alternative, the filename parameter can be used. The following file types and extensions are supported:<br/>
        ///   * `docx` - Microsoft Word Document<br/>
        ///   * `pptx` - Microsoft PowerPoint Document<br/>
        ///   * `xlsx` - Microsoft Excel Document<br/>
        ///   * `pdf` - Portable Document Format<br/>
        ///   * `htm / html` - HTML Document<br/>
        ///   * `txt` - Plain Text Document<br/>
        ///   * `xlf / xliff` - XLIFF Document (versions 1.2, 2.0, and 2.1)<br/>
        ///   * `srt` - SRT Document<br/>
        ///   * `idml` - Adobe InDesign Markup Language<br/>
        ///   * `xml` - XML Document<br/>
        ///   * `json` - JSON Document<br/>
        ///   * `dita` - DITA topic (Darwin Information Typing Architecture)<br/>
        ///   * `mif` - Adobe FrameMaker Interchange Format<br/>
        ///   * `jpeg` / `jpg` / `png` - Image (currently in beta)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The name of the uploaded file. Can be used as an alternative to including the file name in the file part's content disposition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// File extension of desired format of translated file, for example: `docx`. If unspecified, by default the translated file will be in the same format as the input file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public string? OutputFormat { get; set; }

        /// <summary>
        /// Sets whether the translated text should lean towards formal or informal language.<br/>
        /// This feature is only available for certain target languages. Setting this parameter<br/>
        /// with a target language that does not support formality will fail, unless one of the<br/>
        /// `prefer_...` options are used.<br/>
        /// Possible options are:<br/>
        ///   * `default` (default)<br/>
        ///   * `more` - for a more formal language<br/>
        ///   * `less` - for a more informal language<br/>
        ///   * `prefer_more` - for a more formal language if available, otherwise fallback to default formality<br/>
        ///   * `prefer_less` - for a more informal language if available, otherwise fallback to default formality<br/>
        /// Default Value: default<br/>
        /// Example: prefer_more
        /// </summary>
        /// <example>prefer_more</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("formality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.FormalityJsonConverter))]
        public global::DeepL.Formality? Formality { get; set; }

        /// <summary>
        /// A unique ID assigned to a glossary. To check glossary support for a language pair, call `GET /v3/languages?resource=translate_document` and verify the `glossary` feature key is present on both the source and target language.<br/>
        /// Cannot be used together with `glossary_ids`.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </summary>
        /// <example>def3a26b-3e84-45b3-84ae-0c0aaf3525f7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("glossary_id")]
        public string? GlossaryId { get; set; }

        /// <summary>
        /// Comma-separated list of up to 5 glossary IDs to use for the translation. Each glossary's matching terms are applied to the translated document. May also be sent as a repeated parameter.<br/>
        /// **Important:** This requires the `source_lang` parameter to be set. Every listed glossary must contain a dictionary for the requested language pair.<br/>
        /// Cannot be used together with `glossary_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("glossary_ids")]
        public global::System.Collections.Generic.IList<string>? GlossaryIds { get; set; }

        /// <summary>
        /// Specify the [style rule list](/api-reference/style-rules) to use for the translation.<br/>
        /// **Important:** The target language has to match the language of the style rule list.<br/>
        /// Example: 7ff9bfd6-cd85-4190-8503-d6215a321519
        /// </summary>
        /// <example>7ff9bfd6-cd85-4190-8503-d6215a321519</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_id")]
        public string? StyleId { get; set; }

        /// <summary>
        /// A unique ID assigned to a translation memory.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </summary>
        /// <example>a74d88fb-ed2a-4943-a664-a4512398b994</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation_memory_id")]
        public global::System.Guid? TranslationMemoryId { get; set; }

        /// <summary>
        /// The minimum matching percentage required for a translation memory segment to be applied (recommended to be 75% or higher).<br/>
        /// Default Value: 75<br/>
        /// Example: 75
        /// </summary>
        /// <example>75</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation_memory_threshold")]
        public int? TranslationMemoryThreshold { get; set; }

        /// <summary>
        /// This parameter is maintained for backward compatibility and has no effect.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_beta_languages")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? EnableBetaLanguages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateDocumentRequest" /> class.
        /// </summary>
        /// <param name="targetLang">
        /// The language into which the text should be translated.<br/>
        /// For the full list of supported target languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource).<br/>
        /// Example: DE
        /// </param>
        /// <param name="file">
        /// The document file to be translated. The file name should be included in this part's content disposition. As an alternative, the filename parameter can be used. The following file types and extensions are supported:<br/>
        ///   * `docx` - Microsoft Word Document<br/>
        ///   * `pptx` - Microsoft PowerPoint Document<br/>
        ///   * `xlsx` - Microsoft Excel Document<br/>
        ///   * `pdf` - Portable Document Format<br/>
        ///   * `htm / html` - HTML Document<br/>
        ///   * `txt` - Plain Text Document<br/>
        ///   * `xlf / xliff` - XLIFF Document (versions 1.2, 2.0, and 2.1)<br/>
        ///   * `srt` - SRT Document<br/>
        ///   * `idml` - Adobe InDesign Markup Language<br/>
        ///   * `xml` - XML Document<br/>
        ///   * `json` - JSON Document<br/>
        ///   * `dita` - DITA topic (Darwin Information Typing Architecture)<br/>
        ///   * `mif` - Adobe FrameMaker Interchange Format<br/>
        ///   * `jpeg` / `jpg` / `png` - Image (currently in beta)
        /// </param>
        /// <param name="sourceLang">
        /// Language of the text to be translated. If this parameter is omitted, the API will attempt to<br/>
        /// detect the language of the text and translate it.<br/>
        /// For the full list of supported source languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource).<br/>
        /// Example: EN
        /// </param>
        /// <param name="filename">
        /// The name of the uploaded file. Can be used as an alternative to including the file name in the file part's content disposition.
        /// </param>
        /// <param name="outputFormat">
        /// File extension of desired format of translated file, for example: `docx`. If unspecified, by default the translated file will be in the same format as the input file.
        /// </param>
        /// <param name="formality">
        /// Sets whether the translated text should lean towards formal or informal language.<br/>
        /// This feature is only available for certain target languages. Setting this parameter<br/>
        /// with a target language that does not support formality will fail, unless one of the<br/>
        /// `prefer_...` options are used.<br/>
        /// Possible options are:<br/>
        ///   * `default` (default)<br/>
        ///   * `more` - for a more formal language<br/>
        ///   * `less` - for a more informal language<br/>
        ///   * `prefer_more` - for a more formal language if available, otherwise fallback to default formality<br/>
        ///   * `prefer_less` - for a more informal language if available, otherwise fallback to default formality<br/>
        /// Default Value: default<br/>
        /// Example: prefer_more
        /// </param>
        /// <param name="glossaryId">
        /// A unique ID assigned to a glossary. To check glossary support for a language pair, call `GET /v3/languages?resource=translate_document` and verify the `glossary` feature key is present on both the source and target language.<br/>
        /// Cannot be used together with `glossary_ids`.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="glossaryIds">
        /// Comma-separated list of up to 5 glossary IDs to use for the translation. Each glossary's matching terms are applied to the translated document. May also be sent as a repeated parameter.<br/>
        /// **Important:** This requires the `source_lang` parameter to be set. Every listed glossary must contain a dictionary for the requested language pair.<br/>
        /// Cannot be used together with `glossary_id`.
        /// </param>
        /// <param name="styleId">
        /// Specify the [style rule list](/api-reference/style-rules) to use for the translation.<br/>
        /// **Important:** The target language has to match the language of the style rule list.<br/>
        /// Example: 7ff9bfd6-cd85-4190-8503-d6215a321519
        /// </param>
        /// <param name="translationMemoryId">
        /// A unique ID assigned to a translation memory.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </param>
        /// <param name="translationMemoryThreshold">
        /// The minimum matching percentage required for a translation memory segment to be applied (recommended to be 75% or higher).<br/>
        /// Default Value: 75<br/>
        /// Example: 75
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslateDocumentRequest(
            string targetLang,
            byte[] file,
            string? sourceLang,
            string? filename,
            string? outputFormat,
            global::DeepL.Formality? formality,
            string? glossaryId,
            global::System.Collections.Generic.IList<string>? glossaryIds,
            string? styleId,
            global::System.Guid? translationMemoryId,
            int? translationMemoryThreshold)
        {
            this.SourceLang = sourceLang;
            this.TargetLang = targetLang ?? throw new global::System.ArgumentNullException(nameof(targetLang));
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename;
            this.OutputFormat = outputFormat;
            this.Formality = formality;
            this.GlossaryId = glossaryId;
            this.GlossaryIds = glossaryIds;
            this.StyleId = styleId;
            this.TranslationMemoryId = translationMemoryId;
            this.TranslationMemoryThreshold = translationMemoryThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateDocumentRequest" /> class.
        /// </summary>
        public TranslateDocumentRequest()
        {
        }

    }
}