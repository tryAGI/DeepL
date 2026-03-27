#nullable enable

namespace DeepL
{
    public partial interface IManageMultilingualGlossariesClient
    {
        /// <summary>
        /// Create a Glossary
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.MultilingualGlossary> CreateMultilingualGlossaryAsync(

            global::DeepL.CreateMultilingualGlossaryParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Glossary
        /// </summary>
        /// <param name="name">
        /// Name to be associated with the glossary.<br/>
        /// Example: My Glossary
        /// </param>
        /// <param name="dictionaries">
        /// Dictionaries to populate the glossary with.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.MultilingualGlossary> CreateMultilingualGlossaryAsync(
            string name,
            global::System.Collections.Generic.IList<global::DeepL.GlossaryDictionary> dictionaries,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}