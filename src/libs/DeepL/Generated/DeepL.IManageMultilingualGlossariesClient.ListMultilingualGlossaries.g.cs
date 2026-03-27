#nullable enable

namespace DeepL
{
    public partial interface IManageMultilingualGlossariesClient
    {
        /// <summary>
        /// List all Glossaries<br/>
        /// List all glossaries and their meta-information, but not the glossary entries.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.ListMultilingualGlossariesResponse> ListMultilingualGlossariesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}