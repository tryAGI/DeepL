#nullable enable

namespace DeepL
{
    public partial interface IManageGlossariesClient
    {
        /// <summary>
        /// List Language Pairs Supported by Glossaries<br/>
        /// Retrieve the list of language pairs supported by the glossary feature.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.ListGlossaryLanguagesResponse> ListGlossaryLanguagesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Language Pairs Supported by Glossaries<br/>
        /// Retrieve the list of language pairs supported by the glossary feature.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.ListGlossaryLanguagesResponse>> ListGlossaryLanguagesAsResponseAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}