#nullable enable

namespace DeepL;

public partial class DeepLClient
{
    partial void PrepareRequest(
        global::System.Net.Http.HttpClient client,
        global::System.Net.Http.HttpRequestMessage request)
    {
        if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { } apiKey })
        {
            request.Headers.Authorization =
                new global::System.Net.Http.Headers.AuthenticationHeaderValue("DeepL-Auth-Key", apiKey);
        }
    }
}
