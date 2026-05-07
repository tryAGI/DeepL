#nullable enable

namespace DeepL
{
    public partial interface IMetaInformationClient
    {
        /// <summary>
        /// Retrieve Languages<br/>
        /// Returns languages supported by the specified DeepL API resource. Each language indicates whether it can<br/>
        /// be used as a source language, a target language, or both, along with the features it supports for that<br/>
        /// resource.
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "DEEPL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::DeepL.GetLanguagesResponseItem2>> GetLanguages2Async(
            global::DeepL.GetLanguagesResource resource,
            global::System.Collections.Generic.IList<global::DeepL.GetLanguagesIncludeItem>? include = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Languages<br/>
        /// Returns languages supported by the specified DeepL API resource. Each language indicates whether it can<br/>
        /// be used as a source language, a target language, or both, along with the features it supports for that<br/>
        /// resource.
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "DEEPL_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::DeepL.GetLanguagesResponseItem2>>> GetLanguages2AsResponseAsync(
            global::DeepL.GetLanguagesResource resource,
            global::System.Collections.Generic.IList<global::DeepL.GetLanguagesIncludeItem>? include = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}