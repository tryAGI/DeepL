
#nullable enable

namespace DeepL
{
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
    ///   * `jpeg` / `jpg` / `png` - Image (currently in beta)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ITranslateDocumentsClient : global::System.IDisposable
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


    }
}