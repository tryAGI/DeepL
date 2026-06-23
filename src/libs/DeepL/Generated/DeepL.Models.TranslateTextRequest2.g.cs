
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslateTextRequest2
    {
        /// <summary>
        /// Text to be translated. Only UTF-8-encoded plain text is supported. The parameter may be specified many times in a single request, within the request size limit (128KiB). Translations are returned in the same order as they are requested. Each text in the array is translated independently — texts do not share context with each other.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Text { get; set; }

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
        /// Additional context that can influence a translation but is not translated itself.<br/>
        /// Characters included in the `context` parameter will not be counted toward billing.<br/>
        /// Example: This is context.
        /// </summary>
        /// <example>This is context.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// When true, the response will include the billed_characters parameter, giving the<br/>
        /// number of characters from the request that will be counted by DeepL for billing purposes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_billed_characters")]
        public bool? ShowBilledCharacters { get; set; }

        /// <summary>
        /// Sets whether the translation engine should first split the input into sentences.<br/>
        /// Possible values are:<br/>
        ///   * 0 - no splitting at all, whole input is treated as one sentence<br/>
        ///   * 1 (default when tag_handling is not set to html) - splits on punctuation and on newlines<br/>
        ///   * nonewlines (default when tag_handling=html) - splits on punctuation only, ignoring newlines<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("split_sentences")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.SplitSentencesOptionJsonConverter))]
        public global::DeepL.SplitSentencesOption? SplitSentences { get; set; }

        /// <summary>
        /// Sets whether the translation engine should respect the original formatting, even if it would usually<br/>
        /// correct some aspects.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_formatting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.PreserveFormattingOptionStrJsonConverter))]
        public global::DeepL.PreserveFormattingOptionStr? PreserveFormatting { get; set; }

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
        /// Specifies which DeepL model should be used for translation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ModelTypeJsonConverter))]
        public global::DeepL.ModelType? ModelType { get; set; }

        /// <summary>
        /// Specify the glossary to use for the translation. **Important:** This requires the `source_lang`<br/>
        /// parameter to be set. The language pair of the glossary has to match the language pair of the<br/>
        /// request.<br/>
        /// Cannot be used together with `glossary_ids`.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </summary>
        /// <example>def3a26b-3e84-45b3-84ae-0c0aaf3525f7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("glossary_id")]
        public string? GlossaryId { get; set; }

        /// <summary>
        /// Comma-separated list of up to 5 glossary IDs to use for the translation. Each glossary's matching terms are applied to the translation. May also be sent as a repeated parameter.<br/>
        /// **Important:** This requires the `source_lang` parameter to be set. Every listed glossary must contain a dictionary for the requested language pair.<br/>
        /// Cannot be used together with `glossary_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("glossary_ids")]
        public global::System.Collections.Generic.IList<string>? GlossaryIds { get; set; }

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
        /// Sets which kind of tags should be handled. Options currently available:<br/>
        ///  * `xml`<br/>
        ///  * `html`<br/>
        /// Example: html
        /// </summary>
        /// <example>html</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_handling")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.TagHandlingOptionJsonConverter))]
        public global::DeepL.TagHandlingOption? TagHandling { get; set; }

        /// <summary>
        /// Disable the automatic detection of XML structure by setting the `outline_detection` parameter<br/>
        /// to `false` and selecting the tags that should be considered structure tags. This will split sentences<br/>
        /// using the `splitting_tags` parameter.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outline_detection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.OutlineDetectionOptionStrJsonConverter))]
        public global::DeepL.OutlineDetectionOptionStr? OutlineDetection { get; set; }

        /// <summary>
        /// This parameter is maintained for backward compatibility and has no effect.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_beta_languages")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? EnableBetaLanguages { get; set; }

        /// <summary>
        /// Comma-separated list of XML tags which never split sentences.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("non_splitting_tags")]
        public global::System.Collections.Generic.IList<string>? NonSplittingTags { get; set; }

        /// <summary>
        /// Comma-separated list of XML tags which always cause splits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splitting_tags")]
        public global::System.Collections.Generic.IList<string>? SplittingTags { get; set; }

        /// <summary>
        /// Comma-separated list of XML tags that indicate text not to be translated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_tags")]
        public global::System.Collections.Generic.IList<string>? IgnoreTags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateTextRequest2" /> class.
        /// </summary>
        /// <param name="text">
        /// Text to be translated. Only UTF-8-encoded plain text is supported. The parameter may be specified many times in a single request, within the request size limit (128KiB). Translations are returned in the same order as they are requested. Each text in the array is translated independently — texts do not share context with each other.
        /// </param>
        /// <param name="targetLang">
        /// The language into which the text should be translated.<br/>
        /// For the full list of supported target languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource).<br/>
        /// Example: DE
        /// </param>
        /// <param name="sourceLang">
        /// Language of the text to be translated. If this parameter is omitted, the API will attempt to<br/>
        /// detect the language of the text and translate it.<br/>
        /// For the full list of supported source languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource).<br/>
        /// Example: EN
        /// </param>
        /// <param name="context">
        /// Additional context that can influence a translation but is not translated itself.<br/>
        /// Characters included in the `context` parameter will not be counted toward billing.<br/>
        /// Example: This is context.
        /// </param>
        /// <param name="showBilledCharacters">
        /// When true, the response will include the billed_characters parameter, giving the<br/>
        /// number of characters from the request that will be counted by DeepL for billing purposes.
        /// </param>
        /// <param name="splitSentences">
        /// Sets whether the translation engine should first split the input into sentences.<br/>
        /// Possible values are:<br/>
        ///   * 0 - no splitting at all, whole input is treated as one sentence<br/>
        ///   * 1 (default when tag_handling is not set to html) - splits on punctuation and on newlines<br/>
        ///   * nonewlines (default when tag_handling=html) - splits on punctuation only, ignoring newlines<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="preserveFormatting">
        /// Sets whether the translation engine should respect the original formatting, even if it would usually<br/>
        /// correct some aspects.<br/>
        /// Default Value: 0
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
        /// <param name="modelType">
        /// Specifies which DeepL model should be used for translation.
        /// </param>
        /// <param name="glossaryId">
        /// Specify the glossary to use for the translation. **Important:** This requires the `source_lang`<br/>
        /// parameter to be set. The language pair of the glossary has to match the language pair of the<br/>
        /// request.<br/>
        /// Cannot be used together with `glossary_ids`.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="glossaryIds">
        /// Comma-separated list of up to 5 glossary IDs to use for the translation. Each glossary's matching terms are applied to the translation. May also be sent as a repeated parameter.<br/>
        /// **Important:** This requires the `source_lang` parameter to be set. Every listed glossary must contain a dictionary for the requested language pair.<br/>
        /// Cannot be used together with `glossary_id`.
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
        /// <param name="tagHandling">
        /// Sets which kind of tags should be handled. Options currently available:<br/>
        ///  * `xml`<br/>
        ///  * `html`<br/>
        /// Example: html
        /// </param>
        /// <param name="outlineDetection">
        /// Disable the automatic detection of XML structure by setting the `outline_detection` parameter<br/>
        /// to `false` and selecting the tags that should be considered structure tags. This will split sentences<br/>
        /// using the `splitting_tags` parameter.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="nonSplittingTags">
        /// Comma-separated list of XML tags which never split sentences.
        /// </param>
        /// <param name="splittingTags">
        /// Comma-separated list of XML tags which always cause splits.
        /// </param>
        /// <param name="ignoreTags">
        /// Comma-separated list of XML tags that indicate text not to be translated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslateTextRequest2(
            global::System.Collections.Generic.IList<string> text,
            string targetLang,
            string? sourceLang,
            string? context,
            bool? showBilledCharacters,
            global::DeepL.SplitSentencesOption? splitSentences,
            global::DeepL.PreserveFormattingOptionStr? preserveFormatting,
            global::DeepL.Formality? formality,
            global::DeepL.ModelType? modelType,
            string? glossaryId,
            global::System.Collections.Generic.IList<string>? glossaryIds,
            global::System.Guid? translationMemoryId,
            int? translationMemoryThreshold,
            global::DeepL.TagHandlingOption? tagHandling,
            global::DeepL.OutlineDetectionOptionStr? outlineDetection,
            global::System.Collections.Generic.IList<string>? nonSplittingTags,
            global::System.Collections.Generic.IList<string>? splittingTags,
            global::System.Collections.Generic.IList<string>? ignoreTags)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.SourceLang = sourceLang;
            this.TargetLang = targetLang ?? throw new global::System.ArgumentNullException(nameof(targetLang));
            this.Context = context;
            this.ShowBilledCharacters = showBilledCharacters;
            this.SplitSentences = splitSentences;
            this.PreserveFormatting = preserveFormatting;
            this.Formality = formality;
            this.ModelType = modelType;
            this.GlossaryId = glossaryId;
            this.GlossaryIds = glossaryIds;
            this.TranslationMemoryId = translationMemoryId;
            this.TranslationMemoryThreshold = translationMemoryThreshold;
            this.TagHandling = tagHandling;
            this.OutlineDetection = outlineDetection;
            this.NonSplittingTags = nonSplittingTags;
            this.SplittingTags = splittingTags;
            this.IgnoreTags = ignoreTags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateTextRequest2" /> class.
        /// </summary>
        public TranslateTextRequest2()
        {
        }

    }
}