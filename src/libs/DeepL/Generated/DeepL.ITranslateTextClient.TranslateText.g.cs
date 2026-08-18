#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace DeepL
{
    public partial interface ITranslateTextClient
    {
        /// <summary>
        /// Request Translation
        /// </summary>
        /// <param name="xDeepLReportingTag"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.TranslateTextResponse> TranslateTextAsync(

            global::DeepL.TranslateTextRequest request,
            string? xDeepLReportingTag = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request Translation
        /// </summary>
        /// <param name="xDeepLReportingTag"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.TranslateTextResponse>> TranslateTextAsResponseAsync(

            global::DeepL.TranslateTextRequest request,
            string? xDeepLReportingTag = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request Translation
        /// </summary>
        /// <param name="xDeepLReportingTag"></param>
        /// <param name="text">
        /// Text to be translated. Only UTF-8-encoded plain text is supported. The parameter may be specified<br/>
        /// many times in a single request, within the request size limit (128KiB). Translations are returned<br/>
        /// in the same order as they are requested. Each text in the array is translated independently — texts<br/>
        /// do not share context with each other.
        /// </param>
        /// <param name="sourceLang">
        /// Language of the text to be translated. If this parameter is omitted, the API will attempt to<br/>
        /// detect the language of the text and translate it.<br/>
        /// For the full list of supported source languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/docs/languages/using-the-languages-api).<br/>
        /// Example: EN
        /// </param>
        /// <param name="targetLang">
        /// The language into which the text should be translated.<br/>
        /// For the full list of supported target languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/docs/languages/using-the-languages-api).<br/>
        /// Example: DE
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
        /// Default Value: false
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
        /// Specify up to 5 glossaries to use for the translation, as an array of glossary IDs. Each glossary's matching terms are applied to the translation.<br/>
        /// **Important:** This requires the `source_lang` parameter to be set. Every listed glossary must contain a dictionary for the requested language pair.<br/>
        /// Cannot be used together with `glossary_id`.
        /// </param>
        /// <param name="styleId">
        /// Specify the [style rule list](/docs/customize/using-style-rules) to use for the translation.<br/>
        /// **Important:**  The target language has to match the language of the style rule list.<br/>
        /// All `model_type` values are supported.<br/>
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
        /// <param name="customInstructions">
        /// Specify a list of instructions to customize the translation behavior. Up to 10 custom instructions can be specified, each with a maximum of 300 characters.<br/>
        /// **Important:**  The target language must be `de`, `en`, `es`, `fr`, `it`, `ja`, `ko`, `zh` or any variants of these languages.
        /// </param>
        /// <param name="tagHandling">
        /// Sets which kind of tags should be handled. Options currently available:<br/>
        ///  * `xml`<br/>
        ///  * `html`<br/>
        /// Example: html
        /// </param>
        /// <param name="tagHandlingVersion">
        /// Sets which version of the tag handling algorithm should be used. Options currently available:<br/>
        /// * `v1`: Traditional algorithm (currently the default, will become deprecated in the future).<br/>
        /// * `v2`: Improved algorithm released in October 2025 (will become the default in the future).
        /// </param>
        /// <param name="outlineDetection">
        /// Disable the automatic detection of XML structure by setting the `outline_detection` parameter<br/>
        /// to `false` and selecting the tags that should be considered structure tags. This will split sentences<br/>
        /// using the `splitting_tags` parameter.<br/>
        /// Default Value: true
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.TranslateTextResponse> TranslateTextAsync(
            global::System.Collections.Generic.IList<string> text,
            string targetLang,
            string? xDeepLReportingTag = default,
            string? sourceLang = default,
            string? context = default,
            bool? showBilledCharacters = default,
            global::DeepL.SplitSentencesOption? splitSentences = default,
            bool? preserveFormatting = default,
            global::DeepL.Formality? formality = default,
            global::DeepL.ModelType? modelType = default,
            string? glossaryId = default,
            global::System.Collections.Generic.IList<string>? glossaryIds = default,
            string? styleId = default,
            global::System.Guid? translationMemoryId = default,
            int? translationMemoryThreshold = default,
            global::System.Collections.Generic.IList<string>? customInstructions = default,
            global::DeepL.TagHandlingOption? tagHandling = default,
            global::DeepL.TagHandlingVersionOption? tagHandlingVersion = default,
            bool? outlineDetection = default,
            global::System.Collections.Generic.IList<string>? nonSplittingTags = default,
            global::System.Collections.Generic.IList<string>? splittingTags = default,
            global::System.Collections.Generic.IList<string>? ignoreTags = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}