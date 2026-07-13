
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageResponse
    {
        /// <summary>
        /// Characters translated so far in the current billing period.<br/>
        /// Example: 180118
        /// </summary>
        /// <example>180118</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_count")]
        public long? CharacterCount { get; set; }

        /// <summary>
        /// Current maximum number of characters that can be translated per billing period. If cost control is set, the cost control limit will be returned in this field.<br/>
        /// Example: 1250000
        /// </summary>
        /// <example>1250000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_limit")]
        public long? CharacterLimit { get; set; }

        /// <summary>
        /// Only present for API Pro users. Per-product usage details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("products")]
        public global::System.Collections.Generic.IList<global::DeepL.UsageResponseProduct>? Products { get; set; }

        /// <summary>
        /// Only present for API Pro users. Total characters used by this API key in the current period.<br/>
        /// Example: 636
        /// </summary>
        /// <example>636</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_character_count")]
        public int? ApiKeyCharacterCount { get; set; }

        /// <summary>
        /// Only present for API Pro users. Character limit for this API key in the current period.<br/>
        /// Example: 1000000000000
        /// </summary>
        /// <example>1000000000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_character_limit")]
        public long? ApiKeyCharacterLimit { get; set; }

        /// <summary>
        /// Deprecated. Always returns 0. Use speech_to_text_minutes_count instead.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_to_text_milliseconds_count")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? SpeechToTextMillisecondsCount { get; set; }

        /// <summary>
        /// Deprecated. Always returns 0. Use speech_to_text_minutes_limit instead.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_to_text_milliseconds_limit")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? SpeechToTextMillisecondsLimit { get; set; }

        /// <summary>
        /// Only present for API Pro users. Minutes of speech-to-text used in the current period. Milliseconds are rounded up to the nearest minute.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_to_text_minutes_count")]
        public int? SpeechToTextMinutesCount { get; set; }

        /// <summary>
        /// Only present for API Pro users. Maximum minutes of speech-to-text that can be used in the current billing period.<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_to_text_minutes_limit")]
        public int? SpeechToTextMinutesLimit { get; set; }

        /// <summary>
        /// Only present for API Pro users. Minutes of speech-to-speech used in the current period. Milliseconds are rounded up to the nearest minute.<br/>
        /// Example: 12
        /// </summary>
        /// <example>12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_to_speech_minutes_count")]
        public int? SpeechToSpeechMinutesCount { get; set; }

        /// <summary>
        /// Only present for API Pro users. Maximum minutes of speech-to-speech that can be used in the current billing period.<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_to_speech_minutes_limit")]
        public int? SpeechToSpeechMinutesLimit { get; set; }

        /// <summary>
        /// Only present for API Pro users. Start time of the current billing period (ISO 8601).<br/>
        /// Example: 2025-05-13T09:18:42Z
        /// </summary>
        /// <example>2025-05-13T09:18:42Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Only present for API Pro users. End time of the current billing period (ISO 8601).<br/>
        /// Example: 2025-06-13T09:18:42Z
        /// </summary>
        /// <example>2025-06-13T09:18:42Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageResponse" /> class.
        /// </summary>
        /// <param name="characterCount">
        /// Characters translated so far in the current billing period.<br/>
        /// Example: 180118
        /// </param>
        /// <param name="characterLimit">
        /// Current maximum number of characters that can be translated per billing period. If cost control is set, the cost control limit will be returned in this field.<br/>
        /// Example: 1250000
        /// </param>
        /// <param name="products">
        /// Only present for API Pro users. Per-product usage details.
        /// </param>
        /// <param name="apiKeyCharacterCount">
        /// Only present for API Pro users. Total characters used by this API key in the current period.<br/>
        /// Example: 636
        /// </param>
        /// <param name="apiKeyCharacterLimit">
        /// Only present for API Pro users. Character limit for this API key in the current period.<br/>
        /// Example: 1000000000000
        /// </param>
        /// <param name="speechToTextMinutesCount">
        /// Only present for API Pro users. Minutes of speech-to-text used in the current period. Milliseconds are rounded up to the nearest minute.<br/>
        /// Example: 30
        /// </param>
        /// <param name="speechToTextMinutesLimit">
        /// Only present for API Pro users. Maximum minutes of speech-to-text that can be used in the current billing period.<br/>
        /// Example: 600
        /// </param>
        /// <param name="speechToSpeechMinutesCount">
        /// Only present for API Pro users. Minutes of speech-to-speech used in the current period. Milliseconds are rounded up to the nearest minute.<br/>
        /// Example: 12
        /// </param>
        /// <param name="speechToSpeechMinutesLimit">
        /// Only present for API Pro users. Maximum minutes of speech-to-speech that can be used in the current billing period.<br/>
        /// Example: 600
        /// </param>
        /// <param name="startTime">
        /// Only present for API Pro users. Start time of the current billing period (ISO 8601).<br/>
        /// Example: 2025-05-13T09:18:42Z
        /// </param>
        /// <param name="endTime">
        /// Only present for API Pro users. End time of the current billing period (ISO 8601).<br/>
        /// Example: 2025-06-13T09:18:42Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageResponse(
            long? characterCount,
            long? characterLimit,
            global::System.Collections.Generic.IList<global::DeepL.UsageResponseProduct>? products,
            int? apiKeyCharacterCount,
            long? apiKeyCharacterLimit,
            int? speechToTextMinutesCount,
            int? speechToTextMinutesLimit,
            int? speechToSpeechMinutesCount,
            int? speechToSpeechMinutesLimit,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime)
        {
            this.CharacterCount = characterCount;
            this.CharacterLimit = characterLimit;
            this.Products = products;
            this.ApiKeyCharacterCount = apiKeyCharacterCount;
            this.ApiKeyCharacterLimit = apiKeyCharacterLimit;
            this.SpeechToTextMinutesCount = speechToTextMinutesCount;
            this.SpeechToTextMinutesLimit = speechToTextMinutesLimit;
            this.SpeechToSpeechMinutesCount = speechToSpeechMinutesCount;
            this.SpeechToSpeechMinutesLimit = speechToSpeechMinutesLimit;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageResponse" /> class.
        /// </summary>
        public UsageResponse()
        {
        }

    }
}