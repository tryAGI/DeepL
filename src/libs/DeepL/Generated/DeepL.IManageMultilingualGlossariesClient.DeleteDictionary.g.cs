#nullable enable

namespace DeepL
{
    public partial interface IManageMultilingualGlossariesClient
    {
        /// <summary>
        /// Deletes the dictionary associated with the given language pair with the given glossary ID.<br/>
        /// Delete the dictionary for a single source and target language pair from a glossary,<br/>
        /// leaving the glossary and its other dictionaries in place.
        /// </summary>
        /// <param name="glossaryId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDictionaryAsync(
            string glossaryId,
            global::DeepL.GlossarySourceLanguage sourceLang,
            global::DeepL.MultilingualGlossaryTargetLanguage targetLang,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes the dictionary associated with the given language pair with the given glossary ID.<br/>
        /// Delete the dictionary for a single source and target language pair from a glossary,<br/>
        /// leaving the glossary and its other dictionaries in place.
        /// </summary>
        /// <param name="glossaryId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse> DeleteDictionaryAsResponseAsync(
            string glossaryId,
            global::DeepL.GlossarySourceLanguage sourceLang,
            global::DeepL.MultilingualGlossaryTargetLanguage targetLang,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}