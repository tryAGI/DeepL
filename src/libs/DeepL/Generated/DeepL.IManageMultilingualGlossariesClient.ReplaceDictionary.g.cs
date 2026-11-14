#nullable enable

namespace DeepL
{
    public partial interface IManageMultilingualGlossariesClient
    {
        /// <summary>
        /// Replaces or creates a dictionary in the glossary with the specified entries.<br/>
        /// Replace all entries in the dictionary for a source and target language pair, or create<br/>
        /// the dictionary if it does not exist yet. Entries not included in the request are removed.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.MultilingualGlossaryEntriesInformation> ReplaceDictionaryAsync(
            string glossaryId,

            global::DeepL.MultilingualGlossaryEntries request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replaces or creates a dictionary in the glossary with the specified entries.<br/>
        /// Replace all entries in the dictionary for a source and target language pair, or create<br/>
        /// the dictionary if it does not exist yet. Entries not included in the request are removed.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.MultilingualGlossaryEntriesInformation>> ReplaceDictionaryAsResponseAsync(
            string glossaryId,

            global::DeepL.MultilingualGlossaryEntries request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replaces or creates a dictionary in the glossary with the specified entries.<br/>
        /// Replace all entries in the dictionary for a source and target language pair, or create<br/>
        /// the dictionary if it does not exist yet. Entries not included in the request are removed.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.MultilingualGlossaryEntriesInformation> ReplaceDictionaryAsync(
            string glossaryId,
            global::DeepL.GlossarySourceLanguage? sourceLang = default,
            global::DeepL.MultilingualGlossaryTargetLanguage? targetLang = default,
            string? entries = default,
            global::DeepL.GlossaryEntriesFormat? entriesFormat = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}