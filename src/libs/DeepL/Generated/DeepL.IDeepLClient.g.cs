
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The DeepL API provides programmatic access to DeepL’s language AI technology.<br/>
    /// Note: this OpenAPI spec is embedded into our API documentation and has shortened descriptions.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IDeepLClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }


        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::DeepL.AutoSDKServer> AvailableServers { get; }

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::DeepL.AutoSDKServer? SelectedServer { get; set; }

        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId);

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer();

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::DeepL.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::DeepL.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Endpoints for organization administrators to manage API keys and retrieve usage analytics.
        /// </summary>
        public AdminApiClient AdminApi { get; }

        /// <summary>
        /// The `correct` endpoint fixes spelling and grammar errors without broader rephrasing. Use it when you want<br/>
        /// a minimal-change correction pass rather than the broader rewriting performed by `rephrase`.
        /// </summary>
        public CorrectTextClient CorrectText { get; }

        /// <summary>
        /// Please note that this is the spec for the (old) v2 glossary endpoint.<br/>
        /// We recommend users switch to the newer v3 glossary endpoints, which support editability and multilinguality.<br/>
        /// The *glossary* functions allow you to create, inspect, and delete glossaries.<br/>
        /// Glossaries created with the glossary function can be used in translate requests by specifying the<br/>
        /// `glossary_id` parameter.<br/>
        /// If you encounter issues, please let us know at support@DeepL.com.<br/>
        /// Currently you can create glossaries with any of the languages DeepL supports (with the exception of Thai).
        /// </summary>
        public ManageGlossariesClient ManageGlossaries { get; }

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
        public ManageMultilingualGlossariesClient ManageMultilingualGlossaries { get; }

        /// <summary>
        /// The *Spoken Terms* functions allow you to create, inspect, edit and delete Spoken Terms collections.<br/>
        /// Spoken Terms improve speech recognition in the Voice API: they ensure specific words and phrases,<br/>
        /// such as company names, acronyms, and product names, are transcribed correctly. A collection contains<br/>
        /// one or more term lists, each holding terms for a single language, and is applied to a voice session<br/>
        /// via the `spoken_terms_id` parameter.
        /// </summary>
        public ManageSpokenTermsClient ManageSpokenTerms { get; }

        /// <summary>
        /// Information about API usage and value ranges.
        /// </summary>
        public MetaInformationClient MetaInformation { get; }

        /// <summary>
        /// **Closed alpha.** Evaluate translation quality. Submit source/target segment pairs and retrieve per-segment quality issues categorized by error type and severity, with character spans pointing to where each issue occurs.
        /// </summary>
        public QualityEvaluationClient QualityEvaluation { get; }

        /// <summary>
        /// The `rephrase` endpoint  is used to make corrections and adjustments to texts based on style or tone.
        /// </summary>
        public RephraseTextClient RephraseText { get; }

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
        public TranslateDocumentsClient TranslateDocuments { get; }

        /// <summary>
        /// The text-translation API currently consists of a single endpoint, `translate`, which is described below.
        /// </summary>
        public TranslateTextClient TranslateText { get; }

        /// <summary>
        /// The translation memory endpoints allow you to interact with your account's translation memories, used to store<br/>
        /// and reuse previously created translations. Translation memories can be used in text translation requests by<br/>
        /// specifying the `translation_memory_id` parameter to denote a specific translation memory and the<br/>
        /// `translation_memory_threshold` which defines the minimum matching percentage required for a translation memory<br/>
        /// segment to be applied (recommended to be 75% or higher).
        /// </summary>
        public TranslationMemoriesClient TranslationMemories { get; }

        /// <summary>
        /// The Voice API provides real-time voice transcription and translation services.<br/>
        /// Use a two-step flow: first request a streaming URL via REST, then establish a WebSocket connection for streaming audio and receiving transcriptions.
        /// </summary>
        public VoiceAPIClient VoiceAPI { get; }

        /// <summary>
        /// **Alpha.** Async voice translation jobs. This API may change without notice.
        /// </summary>
        public VoiceTranslateJobClient VoiceTranslateJob { get; }

    }
}