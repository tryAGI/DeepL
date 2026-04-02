#nullable enable

namespace DeepL
{
    public partial interface IManageMultilingualGlossariesClient
    {
        /// <summary>
        /// Retrieve Glossary Details<br/>
        /// Retrieve meta information for a single glossary, omitting the glossary entries.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.MultilingualGlossary> GetMultilingualGlossaryAsync(
            string glossaryId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Glossary Details<br/>
        /// Retrieve meta information for a single glossary, omitting the glossary entries.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.MultilingualGlossary>> GetMultilingualGlossaryAsResponseAsync(
            string glossaryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}