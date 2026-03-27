#nullable enable

namespace DeepL
{
    public partial interface IManageMultilingualGlossariesClient
    {
        /// <summary>
        /// Delete a Glossary<br/>
        /// Deletes the specified glossary.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteMultilingualGlossaryAsync(
            string glossaryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}