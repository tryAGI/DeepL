
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The style profile endpoints allow you to create, inspect, edit and delete style profiles. A style<br/>
    /// profile bundles glossaries, style rule lists and translation memories under one ID. Pass its<br/>
    /// `style_profile_id` in a translation request instead of the individual customization parameters.<br/>
    /// Every component list is optional, and you can link components later with an update. A style<br/>
    /// profile can reference at most one style rule list per target language and at most one translation<br/>
    /// memory per source language. With `glossary_priority_order_enabled`, the order of the glossary IDs<br/>
    /// decides which glossary wins when two of them define the same source term.<br/>
    /// Deleting a style profile does not delete the glossaries, style rule lists and translation memories it<br/>
    /// links. Deleting one of those components removes it from every style profile that links it.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IManageStyleProfilesClient : global::System.IDisposable
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