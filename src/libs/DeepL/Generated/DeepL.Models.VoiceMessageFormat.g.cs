
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Message encoding format for WebSocket communication. Determines how messages are serialized and transmitted.<br/>
    /// Using `json`,  messages are JSON-encoded and sent as TEXT WebSocket frames. All binary fields (such as audio data) are base64-encoded strings.<br/>
    /// Using `msgpack`, messages are MessagePack-encoded and sent as BINARY WebSocket frames. All binary fields (such as audio data) contain raw binary data.<br/>
    /// For more details, see [Message Encoding](/api-reference/voice#message-encoding).<br/>
    /// Default Value: json<br/>
    /// Example: json
    /// </summary>
    public enum VoiceMessageFormat
    {
        /// <summary>
        ///
        /// </summary>
        Json,
        /// <summary>
        ///
        /// </summary>
        Msgpack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceMessageFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceMessageFormat value)
        {
            return value switch
            {
                VoiceMessageFormat.Json => "json",
                VoiceMessageFormat.Msgpack => "msgpack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceMessageFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => VoiceMessageFormat.Json,
                "msgpack" => VoiceMessageFormat.Msgpack,
                _ => null,
            };
        }
    }
}