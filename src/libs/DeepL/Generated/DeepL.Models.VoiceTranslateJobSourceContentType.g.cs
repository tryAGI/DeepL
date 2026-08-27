
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The MIME type of the source audio file.
    /// </summary>
    public enum VoiceTranslateJobSourceContentType
    {
        /// <summary>
        ///
        /// </summary>
        AudioFlac,
        /// <summary>
        ///
        /// </summary>
        AudioMp4,
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
        AudioWav,
        /// <summary>
        ///
        /// </summary>
        AudioWebm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceTranslateJobSourceContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceTranslateJobSourceContentType value)
        {
            return value switch
            {
                VoiceTranslateJobSourceContentType.AudioFlac => "audio/flac",
                VoiceTranslateJobSourceContentType.AudioMp4 => "audio/mp4",
                VoiceTranslateJobSourceContentType.AudioMpeg => "audio/mpeg",
                VoiceTranslateJobSourceContentType.AudioOgg => "audio/ogg",
                VoiceTranslateJobSourceContentType.AudioWav => "audio/wav",
                VoiceTranslateJobSourceContentType.AudioWebm => "audio/webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceTranslateJobSourceContentType? ToEnum(string value)
        {
            return value switch
            {
                "audio/flac" => VoiceTranslateJobSourceContentType.AudioFlac,
                "audio/mp4" => VoiceTranslateJobSourceContentType.AudioMp4,
                "audio/mpeg" => VoiceTranslateJobSourceContentType.AudioMpeg,
                "audio/ogg" => VoiceTranslateJobSourceContentType.AudioOgg,
                "audio/wav" => VoiceTranslateJobSourceContentType.AudioWav,
                "audio/webm" => VoiceTranslateJobSourceContentType.AudioWebm,
                _ => null,
            };
        }
    }
}