
#nullable enable

namespace DeepL
{
    /// <summary>
    /// (closed beta) Target audio voice selection for synthesized speech. The default voice is language dependent.<br/>
    /// Example: female
    /// </summary>
    public enum VoiceTargetMediaVoice
    {
        /// <summary>
        /// 
        /// </summary>
        Female,
        /// <summary>
        /// 
        /// </summary>
        Male,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceTargetMediaVoiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceTargetMediaVoice value)
        {
            return value switch
            {
                VoiceTargetMediaVoice.Female => "female",
                VoiceTargetMediaVoice.Male => "male",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceTargetMediaVoice? ToEnum(string value)
        {
            return value switch
            {
                "female" => VoiceTargetMediaVoice.Female,
                "male" => VoiceTargetMediaVoice.Male,
                _ => null,
            };
        }
    }
}