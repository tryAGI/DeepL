#nullable enable

namespace DeepL
{
    public partial interface IRephraseTextClient
    {
        /// <summary>
        /// Request text improvement
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.RephraseTextResponse> RephraseTextAsync(

            global::DeepL.RephraseTextRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request text improvement
        /// </summary>
        /// <param name="text">
        /// Text to be improved. Only UTF-8-encoded plain text is supported. Improvements are returned in the same order as they are requested.
        /// </param>
        /// <param name="targetLang">
        /// The language for the text improvement. Options currently available:<br/>
        ///  * `de` - German<br/>
        ///  * `en` - English (unspecified variant, defaults to `en-US`)<br/>
        ///  * `en-GB` - English (British)<br/>
        ///  * `en-US` - English (American)<br/>
        ///  * `es` - Spanish<br/>
        ///  * `fr` - French<br/>
        ///  * `it` - Italian<br/>
        ///  * `ja` - Japanese<br/>
        ///  * `ko` - Korean<br/>
        ///  * `pt` - Portuguese (unspecified variant, defaults to `pt-PT`)<br/>
        ///  * `pt-BR` - Portuguese (Brazilian)<br/>
        ///  * `pt-PT` - Portuguese (all Portuguese variants excluding Brazilian Portuguese)<br/>
        ///  * `zh` - Chinese (unspecified variant, defaults to `zh-Hans`)<br/>
        ///  * `zh-Hans` - Chinese (simplified)<br/>
        /// Example: de
        /// </param>
        /// <param name="writingStyle">
        /// Specify a style to rephrase your text in a way that fits your audience and goals.<br/>
        /// The `prefer_` prefix allows falling back to the default style if the language does not yet support styles.
        /// </param>
        /// <param name="tone">
        /// Specify the desired tone for your text.<br/>
        /// The `prefer_` prefix allows falling back to the default tone if the language does not yet support tones.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.RephraseTextResponse> RephraseTextAsync(
            global::System.Collections.Generic.IList<string> text,
            global::DeepL.TargetLanguageWrite? targetLang = default,
            global::DeepL.WritingStyle? writingStyle = default,
            global::DeepL.WritingTone? tone = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}