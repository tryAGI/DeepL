
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace DeepL
{
    public partial class TranslateDocumentsClient
    {

        private static readonly global::DeepL.AutoSDKServer[] s_TranslateDocumentServers = new global::DeepL.AutoSDKServer[]
        {            new global::DeepL.AutoSDKServer(
                id: "https-api-deepl-com",
                name: "DeepL API Pro",
                url: "https://api.deepl.com/",
                description: "DeepL API Pro"),
            new global::DeepL.AutoSDKServer(
                id: "https-api-free-deepl-com",
                name: "DeepL API Free",
                url: "https://api-free.deepl.com/",
                description: "DeepL API Free"),
        };


        private static readonly global::DeepL.EndPointSecurityRequirement s_TranslateDocumentSecurityRequirement0 =
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
        private static readonly global::DeepL.EndPointSecurityRequirement[] s_TranslateDocumentSecurityRequirements =
            new global::DeepL.EndPointSecurityRequirement[]
            {                s_TranslateDocumentSecurityRequirement0,
            };
        partial void PrepareTranslateDocumentArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::DeepL.TranslateDocumentRequest request);
        partial void PrepareTranslateDocumentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::DeepL.TranslateDocumentRequest request);
        partial void ProcessTranslateDocumentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTranslateDocumentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload and Translate a Document
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepL.TranslateDocumentResponse> TranslateDocumentAsync(

            global::DeepL.TranslateDocumentRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await TranslateDocumentAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Upload and Translate a Document
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.TranslateDocumentResponse>> TranslateDocumentAsResponseAsync(

            global::DeepL.TranslateDocumentRequest request,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTranslateDocumentArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::DeepL.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TranslateDocumentSecurityRequirements,
                operationName: "TranslateDocumentAsync");

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
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::DeepL.PathBuilder(
                                path: "/v2/document",
                                baseUri: ResolveBaseUri(
                                servers: s_TranslateDocumentServers,
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

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (request.SourceLang != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.SourceLang ?? string.Empty),
                                    name: "\"source_lang\"");

                            }
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(request.TargetLang ?? string.Empty),
                                name: "\"target_lang\"");

                            var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
                            __contentFile.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                request.Filename is null
                                    ? "application/octet-stream"
                                    : (global::System.IO.Path.GetExtension(request.Filename) ?? string.Empty).ToLowerInvariant() switch
                                    {
                                        ".aac" => "audio/aac",
                                        ".flac" => "audio/flac",
                                        ".gif" => "image/gif",
                                        ".jpeg" => "image/jpeg",
                                        ".jpg" => "image/jpeg",
                                        ".json" => "application/json",
                                        ".m4a" => "audio/mp4",
                                        ".mp3" => "audio/mpeg",
                                        ".mp4" => "video/mp4",
                                        ".mpeg" => "audio/mpeg",
                                        ".mpga" => "audio/mpeg",
                                        ".oga" => "audio/ogg",
                                        ".ogg" => "audio/ogg",
                                        ".opus" => "audio/ogg",
                                        ".pdf" => "application/pdf",
                                        ".png" => "image/png",
                                        ".txt" => "text/plain",
                                        ".wav" => "audio/wav",
                                        ".weba" => "audio/webm",
                                        ".webm" => "video/webm",
                                        ".webp" => "image/webp",
                                        _ => "application/octet-stream",
                                    });
                            __httpRequestContent.Add(
                                content: __contentFile,
                                name: "\"file\"",
                                fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
                            if (__contentFile.Headers.ContentDisposition != null)
                            {
                                __contentFile.Headers.ContentDisposition.FileNameStar = null;
                            }

                            if (request.Filename != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Filename ?? string.Empty),
                                    name: "\"filename\"");

                            }
                            if (request.OutputFormat != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.OutputFormat ?? string.Empty),
                                    name: "\"output_format\"");

                            }
                            if (request.Formality != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Formality).HasValue ? (request.Formality).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"formality\"");

                            }
                            if (request.GlossaryId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.GlossaryId ?? string.Empty),
                                    name: "\"glossary_id\"");

                            }
                            if (request.EnableBetaLanguages != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.EnableBetaLanguages, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"enable_beta_languages\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::DeepL.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareTranslateDocumentRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
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
                                operationId: "TranslateDocument",
                                methodName: "TranslateDocumentAsync",
                                pathTemplate: "\"/v2/document\"",
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
                                operationId: "TranslateDocument",
                                methodName: "TranslateDocumentAsync",
                                pathTemplate: "\"/v2/document\"",
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
                                operationId: "TranslateDocument",
                                methodName: "TranslateDocumentAsync",
                                pathTemplate: "\"/v2/document\"",
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
                ProcessTranslateDocumentResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::DeepL.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::DeepL.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "TranslateDocument",
                                methodName: "TranslateDocumentAsync",
                                pathTemplate: "\"/v2/document\"",
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
                                operationId: "TranslateDocument",
                                methodName: "TranslateDocumentAsync",
                                pathTemplate: "\"/v2/document\"",
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
                            // The requested resource could not be found.
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::DeepL.ErrorResponse? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::DeepL.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::DeepL.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::DeepL.ApiException<global::DeepL.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The request size exceeds the limit.
                            if ((int)__response.StatusCode == 413)
                            {
                                string? __content_413 = null;
                                global::System.Exception? __exception_413 = null;
                                global::DeepL.ErrorResponse? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::DeepL.ErrorResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::DeepL.ErrorResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }


                                throw global::DeepL.ApiException<global::DeepL.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_413,
                                    responseBody: __content_413,
                                    responseObject: __value_413,
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
                            if ((int)__response.StatusCode == 504)
                            {
                                string? __content_504 = null;
                                global::System.Exception? __exception_504 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_504 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_504 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_504 = __ex;
                                }


                                throw global::DeepL.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_504 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_504,
                                    responseBody: __content_504,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Too many requests. Please wait and resend your request.
                            if ((int)__response.StatusCode == 529)
                            {
                                string? __content_529 = null;
                                global::System.Exception? __exception_529 = null;
                                global::DeepL.ErrorResponse? __value_529 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_529 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_529 = global::DeepL.ErrorResponse.FromJson(__content_529, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_529 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_529 = global::DeepL.ErrorResponse.FromJson(__content_529, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_529 = __ex;
                                }


                                throw global::DeepL.ApiException<global::DeepL.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_529 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_529,
                                    responseBody: __content_529,
                                    responseObject: __value_529,
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
                                ProcessTranslateDocumentResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::DeepL.TranslateDocumentResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::DeepL.AutoSDKHttpResponse<global::DeepL.TranslateDocumentResponse>(
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

                                    var __value = await global::DeepL.TranslateDocumentResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::DeepL.AutoSDKHttpResponse<global::DeepL.TranslateDocumentResponse>(
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
        /// Upload and Translate a Document
        /// </summary>
        /// <param name="sourceLang">
        /// Language of the text to be translated. If this parameter is omitted, the API will attempt to<br/>
        /// detect the language of the text and translate it.<br/>
        /// For the full list of supported source languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource).<br/>
        /// Example: EN
        /// </param>
        /// <param name="targetLang">
        /// The language into which the text should be translated.<br/>
        /// For the full list of supported target languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource).<br/>
        /// Example: DE
        /// </param>
        /// <param name="file">
        /// The document file to be translated. The file name should be included in this part's content disposition. As an alternative, the filename parameter can be used. The following file types and extensions are supported:<br/>
        ///   * `docx` - Microsoft Word Document<br/>
        ///   * `pptx` - Microsoft PowerPoint Document<br/>
        ///   * `xlsx` - Microsoft Excel Document<br/>
        ///   * `pdf` - Portable Document Format<br/>
        ///   * `htm / html` - HTML Document<br/>
        ///   * `txt` - Plain Text Document<br/>
        ///   * `xlf / xliff` - XLIFF Document, version 2.1<br/>
        ///   * `srt` - SRT Document<br/>
        ///   * `jpeg` / `jpg` / `png` - Image (currently in beta)
        /// </param>
        /// <param name="filename">
        /// The name of the uploaded file. Can be used as an alternative to including the file name in the file part's content disposition.
        /// </param>
        /// <param name="outputFormat">
        /// File extension of desired format of translated file, for example: `docx`. If unspecified, by default the translated file will be in the same format as the input file.
        /// </param>
        /// <param name="formality">
        /// Sets whether the translated text should lean towards formal or informal language.<br/>
        /// This feature is only available for certain target languages. Setting this parameter<br/>
        /// with a target language that does not support formality will fail, unless one of the<br/>
        /// `prefer_...` options are used.<br/>
        /// Possible options are:<br/>
        ///   * `default` (default)<br/>
        ///   * `more` - for a more formal language<br/>
        ///   * `less` - for a more informal language<br/>
        ///   * `prefer_more` - for a more formal language if available, otherwise fallback to default formality<br/>
        ///   * `prefer_less` - for a more informal language if available, otherwise fallback to default formality<br/>
        /// Default Value: default<br/>
        /// Example: prefer_more
        /// </param>
        /// <param name="glossaryId">
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepL.TranslateDocumentResponse> TranslateDocumentAsync(
            string targetLang,
            byte[] file,
            string? sourceLang = default,
            string? filename = default,
            string? outputFormat = default,
            global::DeepL.Formality? formality = default,
            string? glossaryId = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::DeepL.TranslateDocumentRequest
            {
                SourceLang = sourceLang,
                TargetLang = targetLang,
                File = file,
                Filename = filename,
                OutputFormat = outputFormat,
                Formality = formality,
                GlossaryId = glossaryId,
            };

            return await TranslateDocumentAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Upload and Translate a Document
        /// </summary>
        /// <param name="sourceLang">
        /// Language of the text to be translated. If this parameter is omitted, the API will attempt to<br/>
        /// detect the language of the text and translate it.<br/>
        /// For the full list of supported source languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource).<br/>
        /// Example: EN
        /// </param>
        /// <param name="targetLang">
        /// The language into which the text should be translated.<br/>
        /// For the full list of supported target languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource).<br/>
        /// Example: DE
        /// </param>
        /// <param name="file">
        /// The document file to be translated. The file name should be included in this part's content disposition. As an alternative, the filename parameter can be used. The following file types and extensions are supported:<br/>
        /// * `docx` - Microsoft Word Document<br/>
        /// * `pptx` - Microsoft PowerPoint Document<br/>
        /// * `xlsx` - Microsoft Excel Document<br/>
        /// * `pdf` - Portable Document Format<br/>
        /// * `htm / html` - HTML Document<br/>
        /// * `txt` - Plain Text Document<br/>
        /// * `xlf / xliff` - XLIFF Document, version 2.1<br/>
        /// * `srt` - SRT Document<br/>
        /// * `jpeg` / `jpg` / `png` - Image (currently in beta)
        /// </param>
        /// <param name="filename">
        /// The name of the uploaded file. Can be used as an alternative to including the file name in the file part's content disposition.
        /// </param>
        /// <param name="outputFormat">
        /// File extension of desired format of translated file, for example: `docx`. If unspecified, by default the translated file will be in the same format as the input file.
        /// </param>
        /// <param name="formality">
        /// Sets whether the translated text should lean towards formal or informal language.<br/>
        /// This feature is only available for certain target languages. Setting this parameter<br/>
        /// with a target language that does not support formality will fail, unless one of the<br/>
        /// `prefer_...` options are used.<br/>
        /// Possible options are:<br/>
        /// * `default` (default)<br/>
        /// * `more` - for a more formal language<br/>
        /// * `less` - for a more informal language<br/>
        /// * `prefer_more` - for a more formal language if available, otherwise fallback to default formality<br/>
        /// * `prefer_less` - for a more informal language if available, otherwise fallback to default formality<br/>
        /// Default Value: default<br/>
        /// Example: prefer_more
        /// </param>
        /// <param name="glossaryId">
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepL.TranslateDocumentResponse> TranslateDocumentAsync(
            string targetLang,
            global::System.IO.Stream file,
            string? sourceLang = default,
            string? filename = default,
            string? outputFormat = default,
            global::DeepL.Formality? formality = default,
            string? glossaryId = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            file = file ?? throw new global::System.ArgumentNullException(nameof(file));
            var request = new global::DeepL.TranslateDocumentRequest
            {
                SourceLang = sourceLang,
                TargetLang = targetLang,
                File = global::System.Array.Empty<byte>(),
                Filename = filename,
                OutputFormat = outputFormat,
                Formality = formality,
                GlossaryId = glossaryId,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareTranslateDocumentArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::DeepL.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TranslateDocumentSecurityRequirements,
                operationName: "TranslateDocumentAsync");

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
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::DeepL.PathBuilder(
                                path: "/v2/document",
                                baseUri: ResolveBaseUri(
                                servers: s_TranslateDocumentServers,
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

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (request.SourceLang != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.SourceLang ?? string.Empty),
                                    name: "\"source_lang\"");

                            }
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(request.TargetLang ?? string.Empty),
                                name: "\"target_lang\"");

                            var __contentFile = new global::System.Net.Http.StreamContent(file);
                            __contentFile.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                request.Filename is null
                                    ? "application/octet-stream"
                                    : (global::System.IO.Path.GetExtension(request.Filename) ?? string.Empty).ToLowerInvariant() switch
                                    {
                                        ".aac" => "audio/aac",
                                        ".flac" => "audio/flac",
                                        ".gif" => "image/gif",
                                        ".jpeg" => "image/jpeg",
                                        ".jpg" => "image/jpeg",
                                        ".json" => "application/json",
                                        ".m4a" => "audio/mp4",
                                        ".mp3" => "audio/mpeg",
                                        ".mp4" => "video/mp4",
                                        ".mpeg" => "audio/mpeg",
                                        ".mpga" => "audio/mpeg",
                                        ".oga" => "audio/ogg",
                                        ".ogg" => "audio/ogg",
                                        ".opus" => "audio/ogg",
                                        ".pdf" => "application/pdf",
                                        ".png" => "image/png",
                                        ".txt" => "text/plain",
                                        ".wav" => "audio/wav",
                                        ".weba" => "audio/webm",
                                        ".webm" => "video/webm",
                                        ".webp" => "image/webp",
                                        _ => "application/octet-stream",
                                    });
                            __httpRequestContent.Add(
                                content: __contentFile,
                                name: "\"file\"",
                                fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
                            if (__contentFile.Headers.ContentDisposition != null)
                            {
                                __contentFile.Headers.ContentDisposition.FileNameStar = null;
                            }

                            if (request.Filename != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Filename ?? string.Empty),
                                    name: "\"filename\"");

                            }
                            if (request.OutputFormat != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.OutputFormat ?? string.Empty),
                                    name: "\"output_format\"");

                            }
                            if (request.Formality != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Formality).HasValue ? (request.Formality).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"formality\"");

                            }
                            if (request.GlossaryId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.GlossaryId ?? string.Empty),
                                    name: "\"glossary_id\"");

                            }
                            if (request.EnableBetaLanguages != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.EnableBetaLanguages, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"enable_beta_languages\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::DeepL.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareTranslateDocumentRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
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
                                operationId: "TranslateDocument",
                                methodName: "TranslateDocumentAsync",
                                pathTemplate: "\"/v2/document\"",
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
                                operationId: "TranslateDocument",
                                methodName: "TranslateDocumentAsync",
                                pathTemplate: "\"/v2/document\"",
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
                                operationId: "TranslateDocument",
                                methodName: "TranslateDocumentAsync",
                                pathTemplate: "\"/v2/document\"",
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
                ProcessTranslateDocumentResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::DeepL.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::DeepL.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "TranslateDocument",
                                methodName: "TranslateDocumentAsync",
                                pathTemplate: "\"/v2/document\"",
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
                                operationId: "TranslateDocument",
                                methodName: "TranslateDocumentAsync",
                                pathTemplate: "\"/v2/document\"",
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
                            // The requested resource could not be found.
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::DeepL.ErrorResponse? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::DeepL.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::DeepL.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::DeepL.ApiException<global::DeepL.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The request size exceeds the limit.
                            if ((int)__response.StatusCode == 413)
                            {
                                string? __content_413 = null;
                                global::System.Exception? __exception_413 = null;
                                global::DeepL.ErrorResponse? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::DeepL.ErrorResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::DeepL.ErrorResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }


                                throw global::DeepL.ApiException<global::DeepL.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_413,
                                    responseBody: __content_413,
                                    responseObject: __value_413,
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
                            if ((int)__response.StatusCode == 504)
                            {
                                string? __content_504 = null;
                                global::System.Exception? __exception_504 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_504 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_504 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_504 = __ex;
                                }


                                throw global::DeepL.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_504 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_504,
                                    responseBody: __content_504,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Too many requests. Please wait and resend your request.
                            if ((int)__response.StatusCode == 529)
                            {
                                string? __content_529 = null;
                                global::System.Exception? __exception_529 = null;
                                global::DeepL.ErrorResponse? __value_529 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_529 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_529 = global::DeepL.ErrorResponse.FromJson(__content_529, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_529 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_529 = global::DeepL.ErrorResponse.FromJson(__content_529, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_529 = __ex;
                                }


                                throw global::DeepL.ApiException<global::DeepL.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_529 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_529,
                                    responseBody: __content_529,
                                    responseObject: __value_529,
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
                                ProcessTranslateDocumentResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::DeepL.TranslateDocumentResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                                    return
                                        await global::DeepL.TranslateDocumentResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// Upload and Translate a Document
        /// </summary>
        /// <param name="sourceLang">
        /// Language of the text to be translated. If this parameter is omitted, the API will attempt to<br/>
        /// detect the language of the text and translate it.<br/>
        /// For the full list of supported source languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource).<br/>
        /// Example: EN
        /// </param>
        /// <param name="targetLang">
        /// The language into which the text should be translated.<br/>
        /// For the full list of supported target languages, see [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) or query the [`GET /v3/languages` endpoint](https://developers.deepl.com/api-reference/languages/retrieve-supported-languages-by-resource).<br/>
        /// Example: DE
        /// </param>
        /// <param name="file">
        /// The document file to be translated. The file name should be included in this part's content disposition. As an alternative, the filename parameter can be used. The following file types and extensions are supported:<br/>
        /// * `docx` - Microsoft Word Document<br/>
        /// * `pptx` - Microsoft PowerPoint Document<br/>
        /// * `xlsx` - Microsoft Excel Document<br/>
        /// * `pdf` - Portable Document Format<br/>
        /// * `htm / html` - HTML Document<br/>
        /// * `txt` - Plain Text Document<br/>
        /// * `xlf / xliff` - XLIFF Document, version 2.1<br/>
        /// * `srt` - SRT Document<br/>
        /// * `jpeg` / `jpg` / `png` - Image (currently in beta)
        /// </param>
        /// <param name="filename">
        /// The name of the uploaded file. Can be used as an alternative to including the file name in the file part's content disposition.
        /// </param>
        /// <param name="outputFormat">
        /// File extension of desired format of translated file, for example: `docx`. If unspecified, by default the translated file will be in the same format as the input file.
        /// </param>
        /// <param name="formality">
        /// Sets whether the translated text should lean towards formal or informal language.<br/>
        /// This feature is only available for certain target languages. Setting this parameter<br/>
        /// with a target language that does not support formality will fail, unless one of the<br/>
        /// `prefer_...` options are used.<br/>
        /// Possible options are:<br/>
        /// * `default` (default)<br/>
        /// * `more` - for a more formal language<br/>
        /// * `less` - for a more informal language<br/>
        /// * `prefer_more` - for a more formal language if available, otherwise fallback to default formality<br/>
        /// * `prefer_less` - for a more informal language if available, otherwise fallback to default formality<br/>
        /// Default Value: default<br/>
        /// Example: prefer_more
        /// </param>
        /// <param name="glossaryId">
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.TranslateDocumentResponse>> TranslateDocumentAsResponseAsync(
            string targetLang,
            global::System.IO.Stream file,
            string? sourceLang = default,
            string? filename = default,
            string? outputFormat = default,
            global::DeepL.Formality? formality = default,
            string? glossaryId = default,
            global::DeepL.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            file = file ?? throw new global::System.ArgumentNullException(nameof(file));
            var request = new global::DeepL.TranslateDocumentRequest
            {
                SourceLang = sourceLang,
                TargetLang = targetLang,
                File = global::System.Array.Empty<byte>(),
                Filename = filename,
                OutputFormat = outputFormat,
                Formality = formality,
                GlossaryId = glossaryId,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareTranslateDocumentArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::DeepL.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TranslateDocumentSecurityRequirements,
                operationName: "TranslateDocumentAsync");

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
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::DeepL.PathBuilder(
                                path: "/v2/document",
                                baseUri: ResolveBaseUri(
                                servers: s_TranslateDocumentServers,
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

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (request.SourceLang != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.SourceLang ?? string.Empty),
                                    name: "\"source_lang\"");

                            }
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(request.TargetLang ?? string.Empty),
                                name: "\"target_lang\"");

                            var __contentFile = new global::System.Net.Http.StreamContent(file);
                            __contentFile.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                request.Filename is null
                                    ? "application/octet-stream"
                                    : (global::System.IO.Path.GetExtension(request.Filename) ?? string.Empty).ToLowerInvariant() switch
                                    {
                                        ".aac" => "audio/aac",
                                        ".flac" => "audio/flac",
                                        ".gif" => "image/gif",
                                        ".jpeg" => "image/jpeg",
                                        ".jpg" => "image/jpeg",
                                        ".json" => "application/json",
                                        ".m4a" => "audio/mp4",
                                        ".mp3" => "audio/mpeg",
                                        ".mp4" => "video/mp4",
                                        ".mpeg" => "audio/mpeg",
                                        ".mpga" => "audio/mpeg",
                                        ".oga" => "audio/ogg",
                                        ".ogg" => "audio/ogg",
                                        ".opus" => "audio/ogg",
                                        ".pdf" => "application/pdf",
                                        ".png" => "image/png",
                                        ".txt" => "text/plain",
                                        ".wav" => "audio/wav",
                                        ".weba" => "audio/webm",
                                        ".webm" => "video/webm",
                                        ".webp" => "image/webp",
                                        _ => "application/octet-stream",
                                    });
                            __httpRequestContent.Add(
                                content: __contentFile,
                                name: "\"file\"",
                                fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
                            if (__contentFile.Headers.ContentDisposition != null)
                            {
                                __contentFile.Headers.ContentDisposition.FileNameStar = null;
                            }

                            if (request.Filename != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Filename ?? string.Empty),
                                    name: "\"filename\"");

                            }
                            if (request.OutputFormat != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.OutputFormat ?? string.Empty),
                                    name: "\"output_format\"");

                            }
                            if (request.Formality != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Formality).HasValue ? (request.Formality).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"formality\"");

                            }
                            if (request.GlossaryId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.GlossaryId ?? string.Empty),
                                    name: "\"glossary_id\"");

                            }
                            if (request.EnableBetaLanguages != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.EnableBetaLanguages, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"enable_beta_languages\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::DeepL.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareTranslateDocumentRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
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
                                operationId: "TranslateDocument",
                                methodName: "TranslateDocumentAsync",
                                pathTemplate: "\"/v2/document\"",
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
                                operationId: "TranslateDocument",
                                methodName: "TranslateDocumentAsync",
                                pathTemplate: "\"/v2/document\"",
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
                                operationId: "TranslateDocument",
                                methodName: "TranslateDocumentAsync",
                                pathTemplate: "\"/v2/document\"",
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
                ProcessTranslateDocumentResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::DeepL.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::DeepL.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "TranslateDocument",
                                methodName: "TranslateDocumentAsync",
                                pathTemplate: "\"/v2/document\"",
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
                                operationId: "TranslateDocument",
                                methodName: "TranslateDocumentAsync",
                                pathTemplate: "\"/v2/document\"",
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
                            // The requested resource could not be found.
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::DeepL.ErrorResponse? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::DeepL.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::DeepL.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::DeepL.ApiException<global::DeepL.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The request size exceeds the limit.
                            if ((int)__response.StatusCode == 413)
                            {
                                string? __content_413 = null;
                                global::System.Exception? __exception_413 = null;
                                global::DeepL.ErrorResponse? __value_413 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_413 = global::DeepL.ErrorResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_413 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_413 = global::DeepL.ErrorResponse.FromJson(__content_413, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_413 = __ex;
                                }


                                throw global::DeepL.ApiException<global::DeepL.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_413,
                                    responseBody: __content_413,
                                    responseObject: __value_413,
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
                            if ((int)__response.StatusCode == 504)
                            {
                                string? __content_504 = null;
                                global::System.Exception? __exception_504 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_504 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_504 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_504 = __ex;
                                }


                                throw global::DeepL.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_504 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_504,
                                    responseBody: __content_504,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Too many requests. Please wait and resend your request.
                            if ((int)__response.StatusCode == 529)
                            {
                                string? __content_529 = null;
                                global::System.Exception? __exception_529 = null;
                                global::DeepL.ErrorResponse? __value_529 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_529 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_529 = global::DeepL.ErrorResponse.FromJson(__content_529, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_529 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_529 = global::DeepL.ErrorResponse.FromJson(__content_529, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_529 = __ex;
                                }


                                throw global::DeepL.ApiException<global::DeepL.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_529 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_529,
                                    responseBody: __content_529,
                                    responseObject: __value_529,
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
                                ProcessTranslateDocumentResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::DeepL.TranslateDocumentResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::DeepL.AutoSDKHttpResponse<global::DeepL.TranslateDocumentResponse>(
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

                                    var __value = await global::DeepL.TranslateDocumentResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::DeepL.AutoSDKHttpResponse<global::DeepL.TranslateDocumentResponse>(
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
    }
}