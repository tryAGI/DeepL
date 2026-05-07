
#nullable enable

namespace DeepL
{
    /// <summary>
    ///  (EAP) The audio format for synthesized target media streaming.<br/>
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
    public enum VoiceTargetMediaContentType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioFlac,
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
        AudioOpus,
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
        AudioPcm_encoding_s16le_rate_24000,
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
        AudioXMatroska_codecs_opus,
        /// <summary>
        /// 
        /// </summary>
        VideoMp2t_codecs_aac,
        /// <summary>
        /// 
        /// </summary>
        VideoMp2t_codecs_opus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceTargetMediaContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceTargetMediaContentType value)
        {
            return value switch
            {
                VoiceTargetMediaContentType.AudioFlac => "audio/flac",
                VoiceTargetMediaContentType.AudioOgg => "audio/ogg",
                VoiceTargetMediaContentType.AudioOgg_codecs_flac => "audio/ogg;codecs=flac",
                VoiceTargetMediaContentType.AudioOgg_codecs_opus => "audio/ogg;codecs=opus",
                VoiceTargetMediaContentType.AudioOpus => "audio/opus",
                VoiceTargetMediaContentType.AudioPcm_encoding_alaw_rate_8000 => "audio/pcm;encoding=alaw;rate=8000",
                VoiceTargetMediaContentType.AudioPcm_encoding_s16le_rate_16000 => "audio/pcm;encoding=s16le;rate=16000",
                VoiceTargetMediaContentType.AudioPcm_encoding_s16le_rate_24000 => "audio/pcm;encoding=s16le;rate=24000",
                VoiceTargetMediaContentType.AudioPcm_encoding_ulaw_rate_8000 => "audio/pcm;encoding=ulaw;rate=8000",
                VoiceTargetMediaContentType.AudioWebm => "audio/webm",
                VoiceTargetMediaContentType.AudioWebm_codecs_opus => "audio/webm;codecs=opus",
                VoiceTargetMediaContentType.AudioXMatroska_codecs_aac => "audio/x-matroska;codecs=aac",
                VoiceTargetMediaContentType.AudioXMatroska_codecs_flac => "audio/x-matroska;codecs=flac",
                VoiceTargetMediaContentType.AudioXMatroska_codecs_opus => "audio/x-matroska;codecs=opus",
                VoiceTargetMediaContentType.VideoMp2t_codecs_aac => "video/mp2t;codecs=aac",
                VoiceTargetMediaContentType.VideoMp2t_codecs_opus => "video/mp2t;codecs=opus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceTargetMediaContentType? ToEnum(string value)
        {
            return value switch
            {
                "audio/flac" => VoiceTargetMediaContentType.AudioFlac,
                "audio/ogg" => VoiceTargetMediaContentType.AudioOgg,
                "audio/ogg;codecs=flac" => VoiceTargetMediaContentType.AudioOgg_codecs_flac,
                "audio/ogg;codecs=opus" => VoiceTargetMediaContentType.AudioOgg_codecs_opus,
                "audio/opus" => VoiceTargetMediaContentType.AudioOpus,
                "audio/pcm;encoding=alaw;rate=8000" => VoiceTargetMediaContentType.AudioPcm_encoding_alaw_rate_8000,
                "audio/pcm;encoding=s16le;rate=16000" => VoiceTargetMediaContentType.AudioPcm_encoding_s16le_rate_16000,
                "audio/pcm;encoding=s16le;rate=24000" => VoiceTargetMediaContentType.AudioPcm_encoding_s16le_rate_24000,
                "audio/pcm;encoding=ulaw;rate=8000" => VoiceTargetMediaContentType.AudioPcm_encoding_ulaw_rate_8000,
                "audio/webm" => VoiceTargetMediaContentType.AudioWebm,
                "audio/webm;codecs=opus" => VoiceTargetMediaContentType.AudioWebm_codecs_opus,
                "audio/x-matroska;codecs=aac" => VoiceTargetMediaContentType.AudioXMatroska_codecs_aac,
                "audio/x-matroska;codecs=flac" => VoiceTargetMediaContentType.AudioXMatroska_codecs_flac,
                "audio/x-matroska;codecs=opus" => VoiceTargetMediaContentType.AudioXMatroska_codecs_opus,
                "video/mp2t;codecs=aac" => VoiceTargetMediaContentType.VideoMp2t_codecs_aac,
                "video/mp2t;codecs=opus" => VoiceTargetMediaContentType.VideoMp2t_codecs_opus,
                _ => null,
            };
        }
    }
}