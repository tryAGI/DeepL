#nullable enable

namespace DeepL
{
    public partial interface IQualityEvaluationClient
    {
        /// <summary>
        /// Poll for the evaluation result<br/>
        /// Returns the current state of a quality evaluation. While the evaluation is in progress the response carries only status information; once it completes, the response carries the full report.<br/>
        /// Evaluations are requested with `enable_quality_evaluation` on [`POST /v2/document`](/api-reference/document/upload-and-translate-a-document). There is no public endpoint for starting one.
        /// </summary>
        /// <param name="jobId">
        /// Example: 04DE5AD98A02647D83285A36021911C6
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.OneOf<global::DeepL.QualityEvaluationDone, global::DeepL.QualityEvaluationFailed>> PollQualityEvaluationAsync(
            string jobId,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Poll for the evaluation result<br/>
        /// Returns the current state of a quality evaluation. While the evaluation is in progress the response carries only status information; once it completes, the response carries the full report.<br/>
        /// Evaluations are requested with `enable_quality_evaluation` on [`POST /v2/document`](/api-reference/document/upload-and-translate-a-document). There is no public endpoint for starting one.
        /// </summary>
        /// <param name="jobId">
        /// Example: 04DE5AD98A02647D83285A36021911C6
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.OneOf<global::DeepL.QualityEvaluationDone, global::DeepL.QualityEvaluationFailed>>> PollQualityEvaluationAsResponseAsync(
            string jobId,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}