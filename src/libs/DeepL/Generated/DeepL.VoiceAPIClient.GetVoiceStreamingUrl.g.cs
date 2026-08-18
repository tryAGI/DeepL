
#nullable enable

namespace DeepL
{
    public partial class VoiceAPIClient
    {

        private static readonly global::DeepL.AutoSDKServer[] s_GetVoiceStreamingUrlServers = new global::DeepL.AutoSDKServer[]
        {            new global::DeepL.AutoSDKServer(
                id: "https-api-deepl-com",
                name: "Override base path for all operations with the /v3/voice path",
                url: "https://api.deepl.com/",
                description: "Override base path for all operations with the /v3/voice path"),
        };


        private static readonly global::DeepL.EndPointSecurityRequirement s_GetVoiceStreamingUrlSecurityRequirement0 =
            new global::DeepL.EndPointSecurityRequirement
            {
                Authorizations = new global::DeepL.EndPointAuthorizationRequirement[]
                {                    new global::DeepL.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::DeepL.EndPointSecurityRequirement[] s_GetVoiceStreamingUrlSecurityRequirements =
            new global::DeepL.EndPointSecurityRequirement[]
            {                s_GetVoiceStreamingUrlSecurityRequirement0,
            };
        partial void PrepareGetVoiceStreamingUrlArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xDeepLReportingTag,
            global::DeepL.GetVoiceStreamingUrlRequest request);
        partial void PrepareGetVoiceStreamingUrlRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xDeepLReportingTag,
            global::DeepL.GetVoiceStreamingUrlRequest request);
        partial void ProcessGetVoiceStreamingUrlResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetVoiceStreamingUrlResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Streaming URL
        /// </summary>
        /// <param name="xDeepLReportingTag"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepL.VoiceStreamingResponse> GetVoiceStreamingUrlAsync(

            global::DeepL.GetVoiceStreamingUrlRequest request,
            string? xDeepLReportingTag = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetVoiceStreamingUrlAsResponseAsync(

                request: request,
                xDeepLReportingTag: xDeepLReportingTag,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get Streaming URL
        /// </summary>
        /// <param name="xDeepLReportingTag"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.VoiceStreamingResponse>> GetVoiceStreamingUrlAsResponseAsync(

            global::DeepL.GetVoiceStreamingUrlRequest request,
            string? xDeepLReportingTag = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGetVoiceStreamingUrlArguments(
                httpClient: HttpClient,
                xDeepLReportingTag: ref xDeepLReportingTag,
                request: request);


            var __authorizations = global::DeepL.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetVoiceStreamingUrlSecurityRequirements,
                operationName: "GetVoiceStreamingUrlAsync");

            using var __timeoutCancellationTokenSource = global::DeepL.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::DeepL.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::DeepL.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::DeepL.PathBuilder(
                                path: "/v3/voice/realtime",
                                baseUri: ResolveBaseUri(
                                servers: s_GetVoiceStreamingUrlServers,
                                defaultBaseUrl: "https://api.deepl.com/"));
                            var __path = __pathBuilder.ToString();
                __path = global::DeepL.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }

            if (xDeepLReportingTag != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-DeepL-Reporting-Tag", xDeepLReportingTag.ToString());
            }

                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::DeepL.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetVoiceStreamingUrlRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    xDeepLReportingTag: xDeepLReportingTag,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::DeepL.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::DeepL.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetVoiceStreamingUrl",
                                methodName: "GetVoiceStreamingUrlAsync",
                                pathTemplate: "\"/v3/voice/realtime\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::DeepL.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::DeepL.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::DeepL.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetVoiceStreamingUrl",
                                methodName: "GetVoiceStreamingUrlAsync",
                                pathTemplate: "\"/v3/voice/realtime\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::DeepL.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::DeepL.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::DeepL.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::DeepL.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::DeepL.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetVoiceStreamingUrl",
                                methodName: "GetVoiceStreamingUrlAsync",
                                pathTemplate: "\"/v3/voice/realtime\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::DeepL.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGetVoiceStreamingUrlResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::DeepL.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::DeepL.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetVoiceStreamingUrl",
                                methodName: "GetVoiceStreamingUrlAsync",
                                pathTemplate: "\"/v3/voice/realtime\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::DeepL.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::DeepL.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetVoiceStreamingUrl",
                                methodName: "GetVoiceStreamingUrlAsync",
                                pathTemplate: "\"/v3/voice/realtime\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Bad request. Please check error message and your parameters.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::DeepL.ErrorResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::DeepL.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::DeepL.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::DeepL.ApiException<global::DeepL.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Authorization failed. Please supply a valid `DeepL-Auth-Key` via the `Authorization` header.
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::DeepL.ErrorResponse? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::DeepL.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::DeepL.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::DeepL.ApiException<global::DeepL.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Authorization failed. Please supply a valid `DeepL-Auth-Key` via the `Authorization` header.
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::DeepL.ErrorResponse? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::DeepL.ErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::DeepL.ErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::DeepL.ApiException<global::DeepL.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Too many requests. Please wait and resend your request.
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::DeepL.ErrorResponse? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::DeepL.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::DeepL.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::DeepL.ApiException<global::DeepL.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Quota exceeded. The character limit has been reached.
                            if ((int)__response.StatusCode == 456)
                            {
                                string? __content_456 = null;
                                global::System.Exception? __exception_456 = null;
                                global::DeepL.ErrorResponse? __value_456 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_456 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_456 = global::DeepL.ErrorResponse.FromJson(__content_456, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_456 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_456 = global::DeepL.ErrorResponse.FromJson(__content_456, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_456 = __ex;
                                }


                                throw global::DeepL.ApiException<global::DeepL.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_456 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_456,
                                    responseBody: __content_456,
                                    responseObject: __value_456,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // 
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::DeepL.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // 
                            if ((int)__response.StatusCode == 503)
                            {
                                string? __content_503 = null;
                                global::System.Exception? __exception_503 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }


                                throw global::DeepL.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_503,
                                    responseBody: __content_503,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessGetVoiceStreamingUrlResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::DeepL.VoiceStreamingResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::DeepL.AutoSDKHttpResponse<global::DeepL.VoiceStreamingResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::DeepL.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::DeepL.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::DeepL.VoiceStreamingResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::DeepL.AutoSDKHttpResponse<global::DeepL.VoiceStreamingResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::DeepL.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::DeepL.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Get Streaming URL
        /// </summary>
        /// <param name="xDeepLReportingTag"></param>
        /// <param name="messageFormat">
        /// Message encoding format for WebSocket communication. Determines how messages are serialized and transmitted.<br/>
        /// Using `json`,  messages are JSON-encoded and sent as TEXT WebSocket frames. All binary fields (such as audio data) are base64-encoded strings.<br/>
        /// Using `msgpack`, messages are MessagePack-encoded and sent as BINARY WebSocket frames. All binary fields (such as audio data) contain raw binary data.<br/>
        /// For more details, see [Message Encoding](/api-reference/voice#message-encoding).<br/>
        /// Default Value: json<br/>
        /// Example: json
        /// </param>
        /// <param name="sourceMediaContentType">
        ///  The audio format for streaming, which specifies container, codec, and encoding parameters. See the table below for supported formats. If `audio/auto` is specified, the server will auto-detect the container and codec for all supported combinations, except PCM. That requires explicit encoding parameters. All formats need to be single channel audio.<br/>
        ///  <br/>
        ///  | Content Type                          | Container                                         | Codec                                     |<br/>
        ///  | :------------------------------------ | :------------------------------------------------ | :---------------------------------------- |<br/>
        ///  | `audio/auto`                          | Auto-detect: FLAC / Matroska / MPEG / Ogg / WebM  | Auto-detect AAC / FLAC / MP3 / OPUS       |<br/>
        ///  | `audio/flac`                          | FLAC (flac)                                       | FLAC                                      |<br/>
        ///  | `audio/mpeg`                          | MPEG (mp3/m4a)                                    | MP3                                       |<br/>
        ///  | `audio/ogg`                           | Ogg (ogg/oga)                                     | Auto-detect FLAC / OPUS                   |<br/>
        ///  | `audio/webm`                          | WebM (webm)                                       | OPUS                                      |<br/>
        ///  | `audio/x-matroska`                    | Matroska (mkv/mka)                                | Auto-detect: AAC / FLAC / MP3 / OPUS      |<br/>
        ///  | `audio/ogg;codecs=flac`               | Ogg (ogg/oga)                                     | FLAC                                      |<br/>
        ///  | `audio/ogg;codecs=opus`               | Ogg (ogg/oga)                                     | OPUS                                      |<br/>
        ///  | `audio/pcm;encoding=alaw;rate=8000`   | -                                                 | PCM A-Law 8000 Hz (G.711)                 |<br/>
        ///  | `audio/pcm;encoding=ulaw;rate=8000`   | -                                                 | PCM µ-Law 8000 Hz (G.711)                 |<br/>
        ///  | `audio/pcm;encoding=s16le;rate=8000`  | -                                                 | PCM signed 16-bit little-endian 8000 Hz   |<br/>
        ///  | `audio/pcm;encoding=s16le;rate=16000` | -                                                 | PCM signed 16-bit little-endian 16000 Hz  |<br/>
        ///  | `audio/pcm;encoding=s16le;rate=44100` | -                                                 | PCM signed 16-bit little-endian 44100 Hz  |<br/>
        ///  | `audio/pcm;encoding=s16le;rate=48000` | -                                                 | PCM signed 16-bit little-endian 48000 Hz  |<br/>
        ///  | `audio/webm;codecs=opus`              | WebM (webm)                                       | OPUS                                      |<br/>
        ///  | `audio/x-matroska;codecs=aac`         | Matroska (mkv/mka)                                | AAC                                       |<br/>
        ///  | `audio/x-matroska;codecs=flac`        | Matroska (mkv/mka)                                | FLAC                                      |<br/>
        ///  | `audio/x-matroska;codecs=mp3`         | Matroska (mkv/mka)                                | MP3                                       |<br/>
        ///  | `audio/x-matroska;codecs=opus`        | Matroska (mkv/mka)                                | OPUS                                      |<br/>
        ///  <br/>
        /// We recommend the following bitrates as good tradeoff between quality and bandwidth:<br/>
        ///  - AAC: 96 kbps<br/>
        ///  - FLAC: 256 kbps  (16000 Hz)<br/>
        ///  - MP3: 128 kbps<br/>
        ///  - OPUS: 32 kbps (recommendation for low bandwidth scenarios)<br/>
        ///  - PCM: 256 kbps (16000 Hz, default recommendation)<br/>
        ///  <br/>
        /// Example: audio/ogg;codecs=opus
        /// </param>
        /// <param name="sourceLanguage">
        /// The source language of the audio stream. It can be left empty or must be one of the supported Voice API source languages and comply with IETF BCP 47 language tags.<br/>
        /// Note: Some source transcription languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.<br/>
        /// Example: en
        /// </param>
        /// <param name="sourceLanguageMode">
        /// Controls how the source_language value is used.<br/>
        /// - `auto`: Treats source language as a hint; server can override<br/>
        /// - `fixed`: Treats source language as mandatory; server must use this language<br/>
        /// Default Value: auto<br/>
        /// Example: fixed
        /// </param>
        /// <param name="targetLanguages">
        /// List of target languages for translation. The stream will emit translations for each language. Language identifiers must comply with IETF BCP 47. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.<br/>
        /// Default Value: []<br/>
        /// Example: [de, fr, es]
        /// </param>
        /// <param name="targetMediaLanguages">
        /// List of target languages for which to generate synthesized audio. Languages specified here will automatically be added to target_languages if not already present, ensuring you receive both text translation and audio synthesis for these languages. If omitted, only text transcription and translation will be provided (no audio synthesis). Language identifiers must comply with IETF BCP 47.<br/>
        /// Note: Some translated audio languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.<br/>
        /// Default Value: []<br/>
        /// Example: [de]
        /// </param>
        /// <param name="targetMediaContentType">
        ///  The audio format for synthesized target media streaming.<br/>
        ///  Specifies container, codec, and encoding parameters for the audio returned in target_media_chunk messages.<br/>
        ///  If not specified, defaults to audio/webm;codecs=opus.<br/>
        ///  Only applies when target_media_languages is specified.<br/>
        ///  <br/>
        ///  | Content Type | Container | Codec |<br/>
        ///  | :--- | :--- | :--- |<br/>
        ///  | `audio/flac` | FLAC (flac) | FLAC 24000 Hz |<br/>
        ///  | `video/mp2t;codecs=aac` | MPEG Transport Stream (Audio only) | AAC 70 kbit/s |<br/>
        ///  | `video/mp2t;codecs=opus` | MPEG Transport Stream (Audio only) | OPUS 32 kbit/s |<br/>
        ///  | `audio/ogg` | Ogg (ogg/oga) | OPUS 32 kbit/s |<br/>
        ///  | `audio/ogg;codecs=flac` | Ogg (ogg/oga) | FLAC 24000 Hz |<br/>
        ///  | `audio/ogg;codecs=opus` | Ogg (ogg/oga) | OPUS 32 kbit/s |<br/>
        ///  | `audio/opus` | - | OPUS 32 kbit/s |<br/>
        ///  | `audio/pcm;encoding=alaw;rate=8000` | - | PCM A-Law 8000 Hz (G.711) |<br/>
        ///  | `audio/pcm;encoding=ulaw;rate=8000` | - | PCM µ-Law 8000 Hz (G.711) |<br/>
        ///  | `audio/pcm;encoding=s16le;rate=16000` | - | PCM signed 16-bit little-endian 16000 Hz |<br/>
        ///  | `audio/pcm;encoding=s16le;rate=24000` | - | PCM signed 16-bit little-endian 24000 Hz |<br/>
        ///  | `audio/webm` | WebM (webm) | OPUS 32 kbit/s  |<br/>
        ///  | `audio/webm;codecs=opus` | WebM (webm) | OPUS 32 kbit/s |<br/>
        ///  | `audio/x-matroska;codecs=aac` | Matroska (mkv/mka) | AAC 70 kbit/s |<br/>
        ///  | `audio/x-matroska;codecs=flac` | Matroska (mkv/mka) | FLAC 24000 Hz |<br/>
        ///  | `audio/x-matroska;codecs=opus` | Matroska (mkv/mka) | OPUS 32 kbit/s |<br/>
        ///  <br/>
        ///  We recommend the following formats as good tradeoffs between quality and bandwidth:<br/>
        ///  - OPUS (WebM): 32 kbps, recommended for low bandwidth scenarios (default)<br/>
        ///  - PCM 24kHz: 384 kbps, high quality<br/>
        /// Default Value: audio/webm;codecs=opus<br/>
        /// Example: audio/webm;codecs=opus
        /// </param>
        /// <param name="targetMediaVoice">
        /// Target audio voice selection for synthesized speech. The default voice is language dependent.<br/>
        /// Example: female
        /// </param>
        /// <param name="spokenTermsId">
        /// (beta) The ID of a Spoken Terms collection used to inform transcription.<br/>
        /// Example: 7c4f1080-cfe2-41d4-8269-0e6ec15a0354
        /// </param>
        /// <param name="glossaryId">
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="formality">
        /// Sets whether the translated text should lean towards formal or informal language.<br/>
        /// Possible options are:<br/>
        ///   * `default` - use the default formality for the target language<br/>
        ///   * `formal`/`more` - for a more formal language<br/>
        ///   * `informal`/`less` - for a more informal language<br/>
        /// Default Value: default<br/>
        /// Example: formal
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepL.VoiceStreamingResponse> GetVoiceStreamingUrlAsync(
            global::DeepL.VoiceSourceMediaContentType sourceMediaContentType,
            string? xDeepLReportingTag = default,
            global::DeepL.VoiceMessageFormat? messageFormat = default,
            global::DeepL.VoiceSourceLanguage? sourceLanguage = default,
            global::DeepL.VoiceSourceLanguageMode? sourceLanguageMode = default,
            global::System.Collections.Generic.IList<global::DeepL.VoiceTargetLanguage>? targetLanguages = default,
            global::System.Collections.Generic.IList<global::DeepL.VoiceTargetMediaLanguage>? targetMediaLanguages = default,
            global::DeepL.VoiceTargetMediaContentType? targetMediaContentType = default,
            global::DeepL.VoiceTargetMediaVoice? targetMediaVoice = default,
            global::System.Guid? spokenTermsId = default,
            string? glossaryId = default,
            global::DeepL.VoiceFormality? formality = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::DeepL.GetVoiceStreamingUrlRequest
            {
                MessageFormat = messageFormat,
                SourceMediaContentType = sourceMediaContentType,
                SourceLanguage = sourceLanguage,
                SourceLanguageMode = sourceLanguageMode,
                TargetLanguages = targetLanguages,
                TargetMediaLanguages = targetMediaLanguages,
                TargetMediaContentType = targetMediaContentType,
                TargetMediaVoice = targetMediaVoice,
                SpokenTermsId = spokenTermsId,
                GlossaryId = glossaryId,
                Formality = formality,
            };

            return await GetVoiceStreamingUrlAsync(
                xDeepLReportingTag: xDeepLReportingTag,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}