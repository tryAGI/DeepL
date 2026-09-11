
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Target audio voice selection for synthesized speech. The default voice is language dependent.<br/>
    /// Use `match` for speaker match, which produces translated speech with a voice close to the speaker's voice. Speaker match is only available for target languages whose translated speech is provided by DeepL, not for languages provided through external service partners. See the [supported languages table](/docs/voice/supported-voice-languages) for details.<br/>
    /// Requesting `match` for a target language that does not support it is not an error: the session is created and that language's translated speech uses a preset voice instead.<br/>
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
        /// <summary>
        /// the session is created and that language's translated speech uses a preset voice instead.
        /// </summary>
        Match,
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
                VoiceTargetMediaVoice.Match => "match",
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
                "match" => VoiceTargetMediaVoice.Match,
                _ => null,
            };
        }
    }
}