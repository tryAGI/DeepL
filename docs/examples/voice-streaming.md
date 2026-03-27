# Voice Streaming

Shows how to initiate a voice streaming session for real-time translation.

This example assumes `using DeepL;` is in scope and `apiKey` contains your DeepL API key.

```csharp
using var client = new DeepLClient(apiKey);

// The DeepL Voice API provides real-time speech translation via WebSocket.
// Step 1: Call the REST endpoint to get an ephemeral WebSocket URL and token.
var response = await client.VoiceAPI.GetVoiceStreamingUrlAsync(
    request: new GetVoiceStreamingUrlRequest
    {
        SourceMediaContentType = VoiceMediaContentType.AudioPcm_Encoding_s16le_Rate_16000,
        SourceLanguage = VoiceSourceLanguage.En,
        TargetLanguages = ["de"],
    });

// Step 2: Connect to the WebSocket URL (`response.StreamingUrl`)
// and stream audio bytes for real-time transcription and translation.
// This example only verifies the REST setup endpoint;
// actual WebSocket streaming requires a separate WebSocket client.
```