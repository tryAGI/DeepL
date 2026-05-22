#nullable enable

namespace DeepL
{
    public partial interface ICorrectTextClient
    {
        /// <summary>
        /// Correct text<br/>
        /// Fix spelling and grammar errors in one or more texts. Unlike `/v2/write/rephrase`, this endpoint applies<br/>
        /// a minimal-change correction pass and does not rewrite the text for style or tone.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.CorrectTextResponse> CorrectTextAsync(

            global::DeepL.CorrectTextRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Correct text<br/>
        /// Fix spelling and grammar errors in one or more texts. Unlike `/v2/write/rephrase`, this endpoint applies<br/>
        /// a minimal-change correction pass and does not rewrite the text for style or tone.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.CorrectTextResponse>> CorrectTextAsResponseAsync(

            global::DeepL.CorrectTextRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Correct text<br/>
        /// Fix spelling and grammar errors in one or more texts. Unlike `/v2/write/rephrase`, this endpoint applies<br/>
        /// a minimal-change correction pass and does not rewrite the text for style or tone.
        /// </summary>
        /// <param name="text">
        /// Text to be corrected. Only UTF-8-encoded plain text is supported. Corrections are returned in the same order as they are requested.
        /// </param>
        /// <param name="targetLang">
        /// The language for the text improvement.<br/>
        /// Example: de
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.CorrectTextResponse> CorrectTextAsync(
            global::System.Collections.Generic.IList<string> text,
            global::DeepL.TargetLanguageWrite? targetLang = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}