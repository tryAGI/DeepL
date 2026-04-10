#nullable enable

namespace DeepL
{
    public partial interface IMetaInformationClient
    {
        /// <summary>
        /// Retrieve Supported Languages<br/>
        /// Retrieve the list of languages that are currently supported for translation, either as source or target language, respectively.
        /// </summary>
        /// <param name="type">
        /// Default Value: source
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::DeepL.GetLanguagesResponseItem>> GetLanguagesAsync(
            global::DeepL.GetLanguagesType? type = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Supported Languages<br/>
        /// Retrieve the list of languages that are currently supported for translation, either as source or target language, respectively.
        /// </summary>
        /// <param name="type">
        /// Default Value: source
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::DeepL.GetLanguagesResponseItem>>> GetLanguagesAsResponseAsync(
            global::DeepL.GetLanguagesType? type = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}