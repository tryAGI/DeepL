#nullable enable

namespace DeepL
{
    public partial interface IStyleRulesClient
    {
        /// <summary>
        /// Retrieve a style rule list
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.StyleRuleList> GetStyleRuleListAsync(
            string styleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}