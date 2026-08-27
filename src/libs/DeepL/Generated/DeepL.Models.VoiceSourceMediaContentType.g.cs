
#nullable enable

namespace DeepL
{
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
    public enum VoiceSourceMediaContentType
    {
        /// <summary>
        /// FLAC / Matroska / MPEG / Ogg / WebM  | Auto-detect AAC / FLAC / MP3 / OPUS       |
        /// </summary>
        AudioAuto,
        /// <summary>
        ///
        /// </summary>
        AudioFlac,
        /// <summary>
        ///
        /// </summary>
        AudioMpeg,
        /// <summary>
        ///
        /// </summary>
        AudioOgg,
        /// <summary>
        ///
        /// </summary>
        AudioOgg_codecs_flac,
        /// <summary>
        ///
        /// </summary>
        AudioOgg_codecs_opus,
        /// <summary>
        ///
        /// </summary>
        AudioPcm_encoding_alaw_rate_8000,
        /// <summary>
        ///
        /// </summary>
        AudioPcm_encoding_s16le_rate_16000,
        /// <summary>
        ///
        /// </summary>
        AudioPcm_encoding_s16le_rate_44100,
        /// <summary>
        ///
        /// </summary>
        AudioPcm_encoding_s16le_rate_48000,
        /// <summary>
        ///
        /// </summary>
        AudioPcm_encoding_s16le_rate_8000,
        /// <summary>
        ///
        /// </summary>
        AudioPcm_encoding_ulaw_rate_8000,
        /// <summary>
        ///
        /// </summary>
        AudioWebm,
        /// <summary>
        ///
        /// </summary>
        AudioWebm_codecs_opus,
        /// <summary>
        /// AAC / FLAC / MP3 / OPUS      |
        /// </summary>
        AudioXMatroska,
        /// <summary>
        ///
        /// </summary>
        AudioXMatroska_codecs_aac,
        /// <summary>
        ///
        /// </summary>
        AudioXMatroska_codecs_flac,
        /// <summary>
        ///
        /// </summary>
        AudioXMatroska_codecs_mp3,
        /// <summary>
        ///
        /// </summary>
        AudioXMatroska_codecs_opus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceSourceMediaContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceSourceMediaContentType value)
        {
            return value switch
            {
                VoiceSourceMediaContentType.AudioAuto => "audio/auto",
                VoiceSourceMediaContentType.AudioFlac => "audio/flac",
                VoiceSourceMediaContentType.AudioMpeg => "audio/mpeg",
                VoiceSourceMediaContentType.AudioOgg => "audio/ogg",
                VoiceSourceMediaContentType.AudioOgg_codecs_flac => "audio/ogg;codecs=flac",
                VoiceSourceMediaContentType.AudioOgg_codecs_opus => "audio/ogg;codecs=opus",
                VoiceSourceMediaContentType.AudioPcm_encoding_alaw_rate_8000 => "audio/pcm;encoding=alaw;rate=8000",
                VoiceSourceMediaContentType.AudioPcm_encoding_s16le_rate_16000 => "audio/pcm;encoding=s16le;rate=16000",
                VoiceSourceMediaContentType.AudioPcm_encoding_s16le_rate_44100 => "audio/pcm;encoding=s16le;rate=44100",
                VoiceSourceMediaContentType.AudioPcm_encoding_s16le_rate_48000 => "audio/pcm;encoding=s16le;rate=48000",
                VoiceSourceMediaContentType.AudioPcm_encoding_s16le_rate_8000 => "audio/pcm;encoding=s16le;rate=8000",
                VoiceSourceMediaContentType.AudioPcm_encoding_ulaw_rate_8000 => "audio/pcm;encoding=ulaw;rate=8000",
                VoiceSourceMediaContentType.AudioWebm => "audio/webm",
                VoiceSourceMediaContentType.AudioWebm_codecs_opus => "audio/webm;codecs=opus",
                VoiceSourceMediaContentType.AudioXMatroska => "audio/x-matroska",
                VoiceSourceMediaContentType.AudioXMatroska_codecs_aac => "audio/x-matroska;codecs=aac",
                VoiceSourceMediaContentType.AudioXMatroska_codecs_flac => "audio/x-matroska;codecs=flac",
                VoiceSourceMediaContentType.AudioXMatroska_codecs_mp3 => "audio/x-matroska;codecs=mp3",
                VoiceSourceMediaContentType.AudioXMatroska_codecs_opus => "audio/x-matroska;codecs=opus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceSourceMediaContentType? ToEnum(string value)
        {
            return value switch
            {
                "audio/auto" => VoiceSourceMediaContentType.AudioAuto,
                "audio/flac" => VoiceSourceMediaContentType.AudioFlac,
                "audio/mpeg" => VoiceSourceMediaContentType.AudioMpeg,
                "audio/ogg" => VoiceSourceMediaContentType.AudioOgg,
                "audio/ogg;codecs=flac" => VoiceSourceMediaContentType.AudioOgg_codecs_flac,
                "audio/ogg;codecs=opus" => VoiceSourceMediaContentType.AudioOgg_codecs_opus,
                "audio/pcm;encoding=alaw;rate=8000" => VoiceSourceMediaContentType.AudioPcm_encoding_alaw_rate_8000,
                "audio/pcm;encoding=s16le;rate=16000" => VoiceSourceMediaContentType.AudioPcm_encoding_s16le_rate_16000,
                "audio/pcm;encoding=s16le;rate=44100" => VoiceSourceMediaContentType.AudioPcm_encoding_s16le_rate_44100,
                "audio/pcm;encoding=s16le;rate=48000" => VoiceSourceMediaContentType.AudioPcm_encoding_s16le_rate_48000,
                "audio/pcm;encoding=s16le;rate=8000" => VoiceSourceMediaContentType.AudioPcm_encoding_s16le_rate_8000,
                "audio/pcm;encoding=ulaw;rate=8000" => VoiceSourceMediaContentType.AudioPcm_encoding_ulaw_rate_8000,
                "audio/webm" => VoiceSourceMediaContentType.AudioWebm,
                "audio/webm;codecs=opus" => VoiceSourceMediaContentType.AudioWebm_codecs_opus,
                "audio/x-matroska" => VoiceSourceMediaContentType.AudioXMatroska,
                "audio/x-matroska;codecs=aac" => VoiceSourceMediaContentType.AudioXMatroska_codecs_aac,
                "audio/x-matroska;codecs=flac" => VoiceSourceMediaContentType.AudioXMatroska_codecs_flac,
                "audio/x-matroska;codecs=mp3" => VoiceSourceMediaContentType.AudioXMatroska_codecs_mp3,
                "audio/x-matroska;codecs=opus" => VoiceSourceMediaContentType.AudioXMatroska_codecs_opus,
                _ => null,
            };
        }
    }
}