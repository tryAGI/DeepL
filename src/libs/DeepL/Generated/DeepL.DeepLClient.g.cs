
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The DeepL API provides programmatic access to DeepL’s language AI technology.<br/>
    /// Note: this OpenAPI spec is embedded into our API documentation and has shortened descriptions.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class DeepLClient : global::DeepL.IDeepLClient, global::System.IDisposable
    {
        /// <summary>
        /// DeepL API Pro
        /// </summary>
        public const string DefaultBaseUrl = "https://api.deepl.com/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => ResolveDisplayedBaseUri();

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::DeepL.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::DeepL.AutoSDKClientOptions Options { get; }


        internal global::DeepL.AutoSDKServerConfiguration AutoSDKServerConfiguration { get; set; } = new global::DeepL.AutoSDKServerConfiguration();
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::DeepL.SourceGenerationContext.Default;


        /// <summary>
        /// Endpoints for organization administrators to manage API keys and retrieve usage analytics.
        /// </summary>
        public AdminApiClient AdminApi => new AdminApiClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// The `correct` endpoint fixes spelling and grammar errors without broader rephrasing. Use it when you want<br/>
        /// a minimal-change correction pass rather than the broader rewriting performed by `rephrase`.
        /// </summary>
        public CorrectTextClient CorrectText => new CorrectTextClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Please note that this is the spec for the (old) v2 glossary endpoint.<br/>
        /// We recommend users switch to the newer v3 glossary endpoints, which support editability and multilinguality.<br/>
        /// The *glossary* functions allow you to create, inspect, and delete glossaries.<br/>
        /// Glossaries created with the glossary function can be used in translate requests by specifying the<br/>
        /// `glossary_id` parameter.<br/>
        /// If you encounter issues, please let us know at support@DeepL.com.<br/>
        /// Currently you can create glossaries with any of the languages DeepL supports (with the exception of Thai).
        /// </summary>
        public ManageGlossariesClient ManageGlossaries => new ManageGlossariesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// The *glossary* functions allow you to create, inspect, edit and delete glossaries.<br/>
        /// Glossaries created with the glossary function can be used in translate requests by specifying the<br/>
        /// `glossary_id` parameter. A glossary contains (several) dictionaries.<br/>
        /// A dictionary is a mapping of source phrases to target phrases for a single language pair.<br/>
        /// If you encounter issues, please let us know at support@DeepL.com.<br/>
        /// Currently you can create glossaries with any of the languages DeepL supports (with the exception of Thai).<br/>
        /// The maximum size limit for a glossary is 10 MiB = 10485760 bytes and each source/target text,<br/>
        /// as well as the name of the glossary, is limited to 1024 UTF-8 bytes.<br/>
        /// A total of 1000 glossaries are allowed per account.<br/>
        /// When creating a dictionary with target language `EN`, `PT`, or `ZH`, it's not necessary to specify a variant<br/>
        /// (e.g. `EN-US`, `EN-GB`, `PT-PT`, `PT-BR`, or `ZH-HANS`).<br/>
        /// Dictionaries with target language `EN` can be used in translations with either English variant.<br/>
        /// Similarly `PT`, and `ZH` dictionaries can be used in translations with their corresponding variants.<br/>
        /// (When you provide the ID of a glossary to a translation, the appropriate dictionary is automatically applied. Currently glossaries can not yet be used with source language detection.)<br/>
        /// Glossaries created via the DeepL API are now unified with glossaries created via the DeepL website and DeepL apps.<br/>
        /// Please only use the v3 glossary API in conjunction with multilingual or edited glossaries from the website.
        /// </summary>
        public ManageMultilingualGlossariesClient ManageMultilingualGlossaries => new ManageMultilingualGlossariesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// The *Spoken Terms* functions allow you to create, inspect, edit and delete Spoken Terms collections.<br/>
        /// Spoken Terms improve speech recognition in the Voice API: they ensure specific words and phrases,<br/>
        /// such as company names, acronyms, and product names, are transcribed correctly. A collection contains<br/>
        /// one or more term lists, each holding terms for a single language, and is applied to a voice session<br/>
        /// via the `spoken_terms_id` parameter.
        /// </summary>
        public ManageSpokenTermsClient ManageSpokenTerms => new ManageSpokenTermsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// Information about API usage and value ranges.
        /// </summary>
        public MetaInformationClient MetaInformation => new MetaInformationClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// **Closed alpha.** Evaluate translation quality. Submit source/target segment pairs and retrieve per-segment quality issues categorized by error type and severity, with character spans pointing to where each issue occurs.
        /// </summary>
        public QualityEvaluationClient QualityEvaluation => new QualityEvaluationClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// The `rephrase` endpoint  is used to make corrections and adjustments to texts based on style or tone.
        /// </summary>
        public RephraseTextClient RephraseText => new RephraseTextClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// The document translation API allows you to translate whole documents and supports the following file types and extensions:<br/>
        ///   * `docx` - Microsoft Word Document<br/>
        ///   * `pptx` - Microsoft PowerPoint Document<br/>
        ///   * `xlsx` - Microsoft Excel Document<br/>
        ///   * `pdf` - Portable Document Format<br/>
        ///   * `htm / html` - HTML Document<br/>
        ///   * `txt` - Plain Text Document<br/>
        ///   * `xlf / xliff` - XLIFF Document (versions 1.2, 2.0, and 2.1)<br/>
        ///   * `srt` - SRT Document<br/>
        ///   * `idml` - Adobe InDesign Markup Language<br/>
        ///   * `xml` - XML Document<br/>
        ///   * `json` - JSON Document<br/>
        ///   * `dita` - DITA topic (Darwin Information Typing Architecture)<br/>
        ///   * `mif` - Adobe FrameMaker Interchange Format<br/>
        ///   * `jpeg` / `jpg` / `png` - Image (currently in beta).
        /// </summary>
        public TranslateDocumentsClient TranslateDocuments => new TranslateDocumentsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// The text-translation API currently consists of a single endpoint, `translate`, which is described below.
        /// </summary>
        public TranslateTextClient TranslateText => new TranslateTextClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// The translation memory endpoints allow you to manage your account's translation memories, used to store<br/>
        /// and reuse previously created translations. You can list and retrieve translation memories, page through<br/>
        /// their stored segments, create one by importing a TMX file, export one back to TMX, and delete one.<br/>
        /// Editing the contents of an existing translation memory is not supported; import a new one instead.<br/>
        /// Importing and exporting run as background jobs. Create the job, then poll<br/>
        /// `GET /v3/translation_memories/jobs/{job_id}` until it reports `completed`.<br/>
        /// Translation memories can be used in text translation requests by<br/>
        /// specifying the `translation_memory_id` parameter to denote a specific translation memory and the<br/>
        /// `translation_memory_threshold` which defines the minimum matching percentage required for a translation memory<br/>
        /// segment to be applied (recommended to be 75% or higher). A translation request fails with `404` if the<br/>
        /// translation memory does not exist or does not cover the requested language pair.
        /// </summary>
        public TranslationMemoriesClient TranslationMemories => new TranslationMemoriesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// The Voice API provides real-time voice transcription and translation services.<br/>
        /// Use a two-step flow: first request a streaming URL via REST, then establish a WebSocket connection for streaming audio and receiving transcriptions.
        /// </summary>
        public VoiceAPIClient VoiceAPI => new VoiceAPIClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// **Alpha.** Async voice translation jobs. This API may change without notice.
        /// </summary>
        public VoiceTranslateJobClient VoiceTranslateJob => new VoiceTranslateJobClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };


        private static readonly global::DeepL.AutoSDKServer[] s_availableServers = new global::DeepL.AutoSDKServer[]
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

        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::DeepL.AutoSDKServer> AvailableServers => s_availableServers;

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::DeepL.AutoSDKServer? SelectedServer
        {
            get => ResolveSelectedServer();
            set => SelectServer(value);
        }

        /// <summary>
        /// Creates a new instance of the DeepLClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public DeepLClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::DeepL.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the DeepLClient with explicit options but no base URL override.
        /// Skips passing <c>baseUri</c> so the default base URL from the OpenAPI spec applies.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public DeepLClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Collections.Generic.List<global::DeepL.EndPointAuthorization>? authorizations,
            global::DeepL.AutoSDKClientOptions? options,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri: null,
                authorizations,
                options,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the DeepLClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public DeepLClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Uri? baseUri,
            global::System.Collections.Generic.List<global::DeepL.EndPointAuthorization>? authorizations,
            global::DeepL.AutoSDKClientOptions? options,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            if (baseUri is not null)
            {
                HttpClient.BaseAddress ??= baseUri;
            }
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::DeepL.EndPointAuthorization>();
            Options = options ?? new global::DeepL.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            AutoSDKServerConfiguration.ExplicitBaseUri = baseUri ?? httpClient?.BaseAddress;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);


        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId)
        {
            if (string.IsNullOrWhiteSpace(serverId))
            {
                return false;
            }

            foreach (var server in s_availableServers)
            {
                if (string.Equals(server.Id, serverId, global::System.StringComparison.OrdinalIgnoreCase))
                {
                    AutoSDKServerConfiguration.SelectedServer = server;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer()
        {
            AutoSDKServerConfiguration.SelectedServer = null;
        }

        private global::DeepL.AutoSDKServer? ResolveSelectedServer()
        {
            var selectedServer = AutoSDKServerConfiguration.SelectedServer;
            if (selectedServer is null)
            {
                return null;
            }

            foreach (var server in s_availableServers)
            {
                if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                {
                    return server;
                }
            }

            return null;
        }

        private void SelectServer(global::DeepL.AutoSDKServer? server)
        {
            if (server is null)
            {
                AutoSDKServerConfiguration.SelectedServer = null;
                return;
            }

            foreach (var candidate in s_availableServers)
            {
                if (string.Equals(candidate.Id, server.Id, global::System.StringComparison.Ordinal))
                {
                    AutoSDKServerConfiguration.SelectedServer = candidate;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return;
                }
            }

            throw new global::System.ArgumentException("The provided server is not available for this client.", nameof(server));
        }

        private global::System.Uri? ResolveDisplayedBaseUri()
        {
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {
                return explicitBaseUri;
            }

            return ResolveSelectedServer()?.Uri ?? (s_availableServers.Length > 0 ? s_availableServers[0].Uri : HttpClient.BaseAddress);
        }

        private global::System.Uri? ResolveBaseUri(
            global::DeepL.AutoSDKServer[] servers,
            string defaultBaseUrl)
        {
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {
                return explicitBaseUri;
            }

            if (AutoSDKServerConfiguration.SelectedServer is global::DeepL.AutoSDKServer selectedServer)
            {
                foreach (var server in servers)
                {
                    if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                    {
                        return server.Uri;
                    }
                }
            }

            if (servers.Length > 0)
            {
                return servers[0].Uri;
            }

            return string.IsNullOrWhiteSpace(defaultBaseUrl)
                ? HttpClient.BaseAddress
                : new global::System.Uri(defaultBaseUrl, global::System.UriKind.RelativeOrAbsolute);
        }
    }
}