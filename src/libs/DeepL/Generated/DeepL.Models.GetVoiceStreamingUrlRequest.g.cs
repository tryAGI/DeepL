
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVoiceStreamingUrlRequest
    {
        /// <summary>
        /// Message encoding format for WebSocket communication. Determines how messages are serialized and transmitted.<br/>
        /// Using `json`,  messages are JSON-encoded and sent as TEXT WebSocket frames. All binary fields (such as audio data) are base64-encoded strings.<br/>
        /// Using `msgpack`, messages are MessagePack-encoded and sent as BINARY WebSocket frames. All binary fields (such as audio data) contain raw binary data.<br/>
        /// For more details, see [Message Encoding](/api-reference/voice#message-encoding).<br/>
        /// Default Value: json<br/>
        /// Example: json
        /// </summary>
        /// <example>json</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.VoiceMessageFormatJsonConverter))]
        public global::DeepL.VoiceMessageFormat? MessageFormat { get; set; }

        /// <summary>
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
        /// </summary>
        /// <example>audio/ogg;codecs=opus</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_media_content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.VoiceSourceMediaContentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::DeepL.VoiceSourceMediaContentType SourceMediaContentType { get; set; }

        /// <summary>
        /// The source language of the audio stream. It can be left empty or must be one of the supported Voice API source languages and comply with IETF BCP 47 language tags.<br/>
        /// Note: Some source transcription languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.VoiceSourceLanguageJsonConverter))]
        public global::DeepL.VoiceSourceLanguage? SourceLanguage { get; set; }

        /// <summary>
        /// Controls how the source_language value is used.<br/>
        /// - `auto`: Treats source language as a hint; server can override<br/>
        /// - `fixed`: Treats source language as mandatory; server must use this language<br/>
        /// Default Value: auto<br/>
        /// Example: fixed
        /// </summary>
        /// <example>fixed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.VoiceSourceLanguageModeJsonConverter))]
        public global::DeepL.VoiceSourceLanguageMode? SourceLanguageMode { get; set; }

        /// <summary>
        /// List of target languages for translation. The stream will emit translations for each language. The maximum allowed target languages per stream is 5. Language identifiers must comply with IETF BCP 47. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.<br/>
        /// Default Value: []<br/>
        /// Example: [de, fr, es]
        /// </summary>
        /// <example>[de, fr, es]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_languages")]
        public global::System.Collections.Generic.IList<global::DeepL.VoiceTargetLanguage>? TargetLanguages { get; set; }

        /// <summary>
        /// (closed beta) List of target languages for which to generate synthesized audio. Languages specified here will automatically be added to target_languages if not already present, ensuring you receive both text translation and audio synthesis for these languages. If omitted, only text transcription and translation will be provided (no audio synthesis). The maximum allowed target media languages per stream is 5. Language identifiers must comply with IETF BCP 47.<br/>
        /// Note: Some translated audio languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.<br/>
        /// Default Value: []<br/>
        /// Example: [de, en-GB]
        /// </summary>
        /// <example>[de, en-GB]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_media_languages")]
        public global::System.Collections.Generic.IList<global::DeepL.VoiceTargetMediaLanguage>? TargetMediaLanguages { get; set; }

        /// <summary>
        ///  (closed beta) The audio format for synthesized target media streaming.<br/>
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
        /// </summary>
        /// <example>audio/webm;codecs=opus</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_media_content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.VoiceTargetMediaContentTypeJsonConverter))]
        public global::DeepL.VoiceTargetMediaContentType? TargetMediaContentType { get; set; }

        /// <summary>
        /// (closed beta) Target audio voice selection for synthesized speech. The default voice is language dependent.<br/>
        /// Example: female
        /// </summary>
        /// <example>female</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_media_voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.VoiceTargetMediaVoiceJsonConverter))]
        public global::DeepL.VoiceTargetMediaVoice? TargetMediaVoice { get; set; }

        /// <summary>
        /// (beta) The ID of a spoken terms list used to inform transcription.<br/>
        /// Example: 7c4f1080-cfe2-41d4-8269-0e6ec15a0354
        /// </summary>
        /// <example>7c4f1080-cfe2-41d4-8269-0e6ec15a0354</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("spoken_terms_id")]
        public global::System.Guid? SpokenTermsId { get; set; }

        /// <summary>
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </summary>
        /// <example>def3a26b-3e84-45b3-84ae-0c0aaf3525f7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("glossary_id")]
        public string? GlossaryId { get; set; }

        /// <summary>
        /// Sets whether the translated text should lean towards formal or informal language.<br/>
        /// Possible options are:<br/>
        ///   * `default` - use the default formality for the target language<br/>
        ///   * `formal`/`more` - for a more formal language<br/>
        ///   * `informal`/`less` - for a more informal language<br/>
        /// Default Value: default<br/>
        /// Example: formal
        /// </summary>
        /// <example>formal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("formality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.VoiceFormalityJsonConverter))]
        public global::DeepL.VoiceFormality? Formality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoiceStreamingUrlRequest" /> class.
        /// </summary>
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
        /// <param name="messageFormat">
        /// Message encoding format for WebSocket communication. Determines how messages are serialized and transmitted.<br/>
        /// Using `json`,  messages are JSON-encoded and sent as TEXT WebSocket frames. All binary fields (such as audio data) are base64-encoded strings.<br/>
        /// Using `msgpack`, messages are MessagePack-encoded and sent as BINARY WebSocket frames. All binary fields (such as audio data) contain raw binary data.<br/>
        /// For more details, see [Message Encoding](/api-reference/voice#message-encoding).<br/>
        /// Default Value: json<br/>
        /// Example: json
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
        /// List of target languages for translation. The stream will emit translations for each language. The maximum allowed target languages per stream is 5. Language identifiers must comply with IETF BCP 47. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.<br/>
        /// Default Value: []<br/>
        /// Example: [de, fr, es]
        /// </param>
        /// <param name="targetMediaLanguages">
        /// (closed beta) List of target languages for which to generate synthesized audio. Languages specified here will automatically be added to target_languages if not already present, ensuring you receive both text translation and audio synthesis for these languages. If omitted, only text transcription and translation will be provided (no audio synthesis). The maximum allowed target media languages per stream is 5. Language identifiers must comply with IETF BCP 47.<br/>
        /// Note: Some translated audio languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.<br/>
        /// Default Value: []<br/>
        /// Example: [de, en-GB]
        /// </param>
        /// <param name="targetMediaContentType">
        ///  (closed beta) The audio format for synthesized target media streaming.<br/>
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
        /// (closed beta) Target audio voice selection for synthesized speech. The default voice is language dependent.<br/>
        /// Example: female
        /// </param>
        /// <param name="spokenTermsId">
        /// (beta) The ID of a spoken terms list used to inform transcription.<br/>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVoiceStreamingUrlRequest(
            global::DeepL.VoiceSourceMediaContentType sourceMediaContentType,
            global::DeepL.VoiceMessageFormat? messageFormat,
            global::DeepL.VoiceSourceLanguage? sourceLanguage,
            global::DeepL.VoiceSourceLanguageMode? sourceLanguageMode,
            global::System.Collections.Generic.IList<global::DeepL.VoiceTargetLanguage>? targetLanguages,
            global::System.Collections.Generic.IList<global::DeepL.VoiceTargetMediaLanguage>? targetMediaLanguages,
            global::DeepL.VoiceTargetMediaContentType? targetMediaContentType,
            global::DeepL.VoiceTargetMediaVoice? targetMediaVoice,
            global::System.Guid? spokenTermsId,
            string? glossaryId,
            global::DeepL.VoiceFormality? formality)
        {
            this.MessageFormat = messageFormat;
            this.SourceMediaContentType = sourceMediaContentType;
            this.SourceLanguage = sourceLanguage;
            this.SourceLanguageMode = sourceLanguageMode;
            this.TargetLanguages = targetLanguages;
            this.TargetMediaLanguages = targetMediaLanguages;
            this.TargetMediaContentType = targetMediaContentType;
            this.TargetMediaVoice = targetMediaVoice;
            this.SpokenTermsId = spokenTermsId;
            this.GlossaryId = glossaryId;
            this.Formality = formality;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoiceStreamingUrlRequest" /> class.
        /// </summary>
        public GetVoiceStreamingUrlRequest()
        {
        }

    }
}