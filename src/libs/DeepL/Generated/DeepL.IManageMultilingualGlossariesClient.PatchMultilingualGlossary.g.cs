#nullable enable

namespace DeepL
{
    public partial interface IManageMultilingualGlossariesClient
    {
        /// <summary>
        /// Edit glossary details<br/>
        /// Edit glossary details, such as name or a dictionary for a source and target language.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.MultilingualGlossary> PatchMultilingualGlossaryAsync(
            string glossaryId,

            global::DeepL.PatchMultilingualGlossaryParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit glossary details<br/>
        /// Edit glossary details, such as name or a dictionary for a source and target language.
        /// </summary>
        /// <param name="glossaryId"></param>
        /// <param name="name">
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="dictionaries">
        /// Dictionaries to edit the glossary with. Currently only supports 0 or 1 dictionaries in the array.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.MultilingualGlossary> PatchMultilingualGlossaryAsync(
            string glossaryId,
            string? name = default,
            global::System.Collections.Generic.IList<global::DeepL.GlossaryDictionary>? dictionaries = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}