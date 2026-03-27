#nullable enable

namespace DeepL
{
    public partial interface IStyleRulesClient
    {
        /// <summary>
        /// Delete a style rule list
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteStyleRuleListAsync(
            string styleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}