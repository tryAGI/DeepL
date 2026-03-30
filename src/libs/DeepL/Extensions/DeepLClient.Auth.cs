#nullable enable

namespace DeepL;

public partial class DeepLClient
{
    partial void Authorized(
        global::System.Net.Http.HttpClient client)
    {
        // DeepL uses "Authorization: DeepL-Auth-Key <key>" instead of "Bearer".
        // Rewrite the scheme in the shared Authorizations list so all sub-clients
        // (TranslateText, RephraseText, etc.) send the correct header.
        for (var i = 0; i < Authorizations.Count; i++)
        {
            var auth = Authorizations[i];
            if (auth is { Type: "Http", Name: "Bearer" })
            {
                Authorizations[i] = new EndPointAuthorization
                {
                    Type = auth.Type,
                    Location = auth.Location,
                    Name = "DeepL-Auth-Key",
                    Value = auth.Value,
                };
            }
        }
    }
}
