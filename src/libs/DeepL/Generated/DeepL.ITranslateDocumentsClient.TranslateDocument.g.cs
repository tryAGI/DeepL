#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace DeepL
{
    public partial interface ITranslateDocumentsClient
    {
        /// <summary>
        /// Upload and Translate a Document
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.TranslateDocumentResponse> TranslateDocumentAsync(

            global::DeepL.TranslateDocumentRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload and Translate a Document
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.TranslateDocumentResponse>> TranslateDocumentAsResponseAsync(

            global::DeepL.TranslateDocumentRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload and Translate a Document
        /// </summary>
        /// <param name="sourceLang">
        /// Language of the text to be translated. If this parameter is omitted, the API will attempt to<br/>
        /// detect the language of the text and translate it.<br/>
        /// For the full list of supported source languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource).<br/>
        /// Example: EN
        /// </param>
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
        ///   * `xlf / xliff` - XLIFF Document, version 2.1<br/>
        ///   * `srt` - SRT Document<br/>
        ///   * `jpeg` / `jpg` / `png` - Image (currently in beta)
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
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="styleId">
        /// Specify the [style rule list](/api-reference/style-rules) to use for the translation.<br/>
        /// **Important:** The target language has to match the language of the style rule list.<br/>
        /// Example: 7ff9bfd6-cd85-4190-8503-d6215a321519
        /// </param>
        /// <param name="translationMemoryId">
        /// A unique ID assigned to a translation memory.<br/>
        /// **Note:** Requests with the `translation_memory_id` parameter must use the `quality_optimized` model type. Requests combining `translation_memory_id` and `model_type: latency_optimized` will be rejected.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </param>
        /// <param name="translationMemoryThreshold">
        /// The minimum matching percentage required for a translation memory segment to be applied (recommended to be 75% or higher).<br/>
        /// Default Value: 75<br/>
        /// Example: 75
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.TranslateDocumentResponse> TranslateDocumentAsync(
            string targetLang,
            byte[] file,
            string? sourceLang = default,
            string? filename = default,
            string? outputFormat = default,
            global::DeepL.Formality? formality = default,
            string? glossaryId = default,
            string? styleId = default,
            global::System.Guid? translationMemoryId = default,
            int? translationMemoryThreshold = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload and Translate a Document
        /// </summary>
        /// <param name="sourceLang">
        /// Language of the text to be translated. If this parameter is omitted, the API will attempt to<br/>
        /// detect the language of the text and translate it.<br/>
        /// For the full list of supported source languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource).<br/>
        /// Example: EN
        /// </param>
        /// <param name="targetLang">
        /// The language into which the text should be translated.<br/>
        /// For the full list of supported target languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource).<br/>
        /// Example: DE
        /// </param>
        /// <param name="file">
        /// The document file to be translated. The file name should be included in this part's content disposition. As an alternative, the filename parameter can be used. The following file types and extensions are supported:<br/>
        /// * `docx` - Microsoft Word Document<br/>
        /// * `pptx` - Microsoft PowerPoint Document<br/>
        /// * `xlsx` - Microsoft Excel Document<br/>
        /// * `pdf` - Portable Document Format<br/>
        /// * `htm / html` - HTML Document<br/>
        /// * `txt` - Plain Text Document<br/>
        /// * `xlf / xliff` - XLIFF Document, version 2.1<br/>
        /// * `srt` - SRT Document<br/>
        /// * `jpeg` / `jpg` / `png` - Image (currently in beta)
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
        /// * `default` (default)<br/>
        /// * `more` - for a more formal language<br/>
        /// * `less` - for a more informal language<br/>
        /// * `prefer_more` - for a more formal language if available, otherwise fallback to default formality<br/>
        /// * `prefer_less` - for a more informal language if available, otherwise fallback to default formality<br/>
        /// Default Value: default<br/>
        /// Example: prefer_more
        /// </param>
        /// <param name="glossaryId">
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="styleId">
        /// Specify the [style rule list](/api-reference/style-rules) to use for the translation.<br/>
        /// **Important:** The target language has to match the language of the style rule list.<br/>
        /// Example: 7ff9bfd6-cd85-4190-8503-d6215a321519
        /// </param>
        /// <param name="translationMemoryId">
        /// A unique ID assigned to a translation memory.<br/>
        /// **Note:** Requests with the `translation_memory_id` parameter must use the `quality_optimized` model type. Requests combining `translation_memory_id` and `model_type: latency_optimized` will be rejected.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </param>
        /// <param name="translationMemoryThreshold">
        /// The minimum matching percentage required for a translation memory segment to be applied (recommended to be 75% or higher).<br/>
        /// Default Value: 75<br/>
        /// Example: 75
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.TranslateDocumentResponse> TranslateDocumentAsync(
            string targetLang,
            global::System.IO.Stream file,
            string? sourceLang = default,
            string? filename = default,
            string? outputFormat = default,
            global::DeepL.Formality? formality = default,
            string? glossaryId = default,
            string? styleId = default,
            global::System.Guid? translationMemoryId = default,
            int? translationMemoryThreshold = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload and Translate a Document
        /// </summary>
        /// <param name="sourceLang">
        /// Language of the text to be translated. If this parameter is omitted, the API will attempt to<br/>
        /// detect the language of the text and translate it.<br/>
        /// For the full list of supported source languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource).<br/>
        /// Example: EN
        /// </param>
        /// <param name="targetLang">
        /// The language into which the text should be translated.<br/>
        /// For the full list of supported target languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource).<br/>
        /// Example: DE
        /// </param>
        /// <param name="file">
        /// The document file to be translated. The file name should be included in this part's content disposition. As an alternative, the filename parameter can be used. The following file types and extensions are supported:<br/>
        /// * `docx` - Microsoft Word Document<br/>
        /// * `pptx` - Microsoft PowerPoint Document<br/>
        /// * `xlsx` - Microsoft Excel Document<br/>
        /// * `pdf` - Portable Document Format<br/>
        /// * `htm / html` - HTML Document<br/>
        /// * `txt` - Plain Text Document<br/>
        /// * `xlf / xliff` - XLIFF Document, version 2.1<br/>
        /// * `srt` - SRT Document<br/>
        /// * `jpeg` / `jpg` / `png` - Image (currently in beta)
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
        /// * `default` (default)<br/>
        /// * `more` - for a more formal language<br/>
        /// * `less` - for a more informal language<br/>
        /// * `prefer_more` - for a more formal language if available, otherwise fallback to default formality<br/>
        /// * `prefer_less` - for a more informal language if available, otherwise fallback to default formality<br/>
        /// Default Value: default<br/>
        /// Example: prefer_more
        /// </param>
        /// <param name="glossaryId">
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="styleId">
        /// Specify the [style rule list](/api-reference/style-rules) to use for the translation.<br/>
        /// **Important:** The target language has to match the language of the style rule list.<br/>
        /// Example: 7ff9bfd6-cd85-4190-8503-d6215a321519
        /// </param>
        /// <param name="translationMemoryId">
        /// A unique ID assigned to a translation memory.<br/>
        /// **Note:** Requests with the `translation_memory_id` parameter must use the `quality_optimized` model type. Requests combining `translation_memory_id` and `model_type: latency_optimized` will be rejected.<br/>
        /// Example: a74d88fb-ed2a-4943-a664-a4512398b994
        /// </param>
        /// <param name="translationMemoryThreshold">
        /// The minimum matching percentage required for a translation memory segment to be applied (recommended to be 75% or higher).<br/>
        /// Default Value: 75<br/>
        /// Example: 75
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.TranslateDocumentResponse>> TranslateDocumentAsResponseAsync(
            string targetLang,
            global::System.IO.Stream file,
            string? sourceLang = default,
            string? filename = default,
            string? outputFormat = default,
            global::DeepL.Formality? formality = default,
            string? glossaryId = default,
            string? styleId = default,
            global::System.Guid? translationMemoryId = default,
            int? translationMemoryThreshold = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}