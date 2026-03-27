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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::DeepL.GetLanguagesResponseItem>> GetLanguagesAsync(
            global::DeepL.GetLanguagesType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}