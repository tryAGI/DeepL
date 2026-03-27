#nullable enable

namespace DeepL
{
    public partial interface IStyleRulesClient
    {
        /// <summary>
        /// Retrieve style rule lists
        /// </summary>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="detailed">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.GetStyleRuleListsResponse> GetStyleRuleListsAsync(
            int? page = default,
            int? pageSize = default,
            bool? detailed = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}