#nullable enable

namespace DeepL
{
    public partial interface IQualityEvaluationClient
    {
        /// <summary>
        /// Submit an evaluation job<br/>
        /// Starts an evaluation job for the given segments. Returns a `poll_url` that can be used to retrieve the result.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.QualityEvaluationJobCreated> SubmitQualityEvaluationAsync(

            global::DeepL.QualityEvaluationRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit an evaluation job<br/>
        /// Starts an evaluation job for the given segments. Returns a `poll_url` that can be used to retrieve the result.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.QualityEvaluationJobCreated>> SubmitQualityEvaluationAsResponseAsync(

            global::DeepL.QualityEvaluationRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit an evaluation job<br/>
        /// Starts an evaluation job for the given segments. Returns a `poll_url` that can be used to retrieve the result.
        /// </summary>
        /// <param name="metadata">
        /// Job-level metadata.
        /// </param>
        /// <param name="segments">
        /// The segment pairs to evaluate. Up to 500 segments per request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.QualityEvaluationJobCreated> SubmitQualityEvaluationAsync(
            global::DeepL.QualityEvaluationRequestMetadata metadata,
            global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationRequestSegment> segments,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}