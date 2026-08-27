
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The desired output format for the translation target.
    /// </summary>
    public enum VoiceTranslateJobTargetOutputType
    {
        /// <summary>
        ///
        /// </summary>
        ApplicationXSubrip,
        /// <summary>
        ///
        /// </summary>
        AudioFlac,
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
        AudioXMatroska_codecs_pcmS16le_rate_16000,
        /// <summary>
        ///
        /// </summary>
        AudioXMatroska_codecs_pcmS16le_rate_24000,
        /// <summary>
        ///
        /// </summary>
        TextPlain,
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
    public static class VoiceTranslateJobTargetOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceTranslateJobTargetOutputType value)
        {
            return value switch
            {
                VoiceTranslateJobTargetOutputType.ApplicationXSubrip => "application/x-subrip",
                VoiceTranslateJobTargetOutputType.AudioFlac => "audio/flac",
                VoiceTranslateJobTargetOutputType.AudioOgg_codecs_flac => "audio/ogg;codecs=flac",
                VoiceTranslateJobTargetOutputType.AudioOgg_codecs_opus => "audio/ogg;codecs=opus",
                VoiceTranslateJobTargetOutputType.AudioOpus => "audio/opus",
                VoiceTranslateJobTargetOutputType.AudioPcm_encoding_alaw_rate_8000 => "audio/pcm;encoding=alaw;rate=8000",
                VoiceTranslateJobTargetOutputType.AudioPcm_encoding_s16le_rate_16000 => "audio/pcm;encoding=s16le;rate=16000",
                VoiceTranslateJobTargetOutputType.AudioPcm_encoding_s16le_rate_24000 => "audio/pcm;encoding=s16le;rate=24000",
                VoiceTranslateJobTargetOutputType.AudioPcm_encoding_ulaw_rate_8000 => "audio/pcm;encoding=ulaw;rate=8000",
                VoiceTranslateJobTargetOutputType.AudioWebm_codecs_opus => "audio/webm;codecs=opus",
                VoiceTranslateJobTargetOutputType.AudioXMatroska_codecs_aac => "audio/x-matroska;codecs=aac",
                VoiceTranslateJobTargetOutputType.AudioXMatroska_codecs_flac => "audio/x-matroska;codecs=flac",
                VoiceTranslateJobTargetOutputType.AudioXMatroska_codecs_opus => "audio/x-matroska;codecs=opus",
                VoiceTranslateJobTargetOutputType.AudioXMatroska_codecs_pcmS16le_rate_16000 => "audio/x-matroska;codecs=pcm_s16le;rate=16000",
                VoiceTranslateJobTargetOutputType.AudioXMatroska_codecs_pcmS16le_rate_24000 => "audio/x-matroska;codecs=pcm_s16le;rate=24000",
                VoiceTranslateJobTargetOutputType.TextPlain => "text/plain",
                VoiceTranslateJobTargetOutputType.VideoMp2t_codecs_aac => "video/mp2t;codecs=aac",
                VoiceTranslateJobTargetOutputType.VideoMp2t_codecs_opus => "video/mp2t;codecs=opus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceTranslateJobTargetOutputType? ToEnum(string value)
        {
            return value switch
            {
                "application/x-subrip" => VoiceTranslateJobTargetOutputType.ApplicationXSubrip,
                "audio/flac" => VoiceTranslateJobTargetOutputType.AudioFlac,
                "audio/ogg;codecs=flac" => VoiceTranslateJobTargetOutputType.AudioOgg_codecs_flac,
                "audio/ogg;codecs=opus" => VoiceTranslateJobTargetOutputType.AudioOgg_codecs_opus,
                "audio/opus" => VoiceTranslateJobTargetOutputType.AudioOpus,
                "audio/pcm;encoding=alaw;rate=8000" => VoiceTranslateJobTargetOutputType.AudioPcm_encoding_alaw_rate_8000,
                "audio/pcm;encoding=s16le;rate=16000" => VoiceTranslateJobTargetOutputType.AudioPcm_encoding_s16le_rate_16000,
                "audio/pcm;encoding=s16le;rate=24000" => VoiceTranslateJobTargetOutputType.AudioPcm_encoding_s16le_rate_24000,
                "audio/pcm;encoding=ulaw;rate=8000" => VoiceTranslateJobTargetOutputType.AudioPcm_encoding_ulaw_rate_8000,
                "audio/webm;codecs=opus" => VoiceTranslateJobTargetOutputType.AudioWebm_codecs_opus,
                "audio/x-matroska;codecs=aac" => VoiceTranslateJobTargetOutputType.AudioXMatroska_codecs_aac,
                "audio/x-matroska;codecs=flac" => VoiceTranslateJobTargetOutputType.AudioXMatroska_codecs_flac,
                "audio/x-matroska;codecs=opus" => VoiceTranslateJobTargetOutputType.AudioXMatroska_codecs_opus,
                "audio/x-matroska;codecs=pcm_s16le;rate=16000" => VoiceTranslateJobTargetOutputType.AudioXMatroska_codecs_pcmS16le_rate_16000,
                "audio/x-matroska;codecs=pcm_s16le;rate=24000" => VoiceTranslateJobTargetOutputType.AudioXMatroska_codecs_pcmS16le_rate_24000,
                "text/plain" => VoiceTranslateJobTargetOutputType.TextPlain,
                "video/mp2t;codecs=aac" => VoiceTranslateJobTargetOutputType.VideoMp2t_codecs_aac,
                "video/mp2t;codecs=opus" => VoiceTranslateJobTargetOutputType.VideoMp2t_codecs_opus,
                _ => null,
            };
        }
    }
}