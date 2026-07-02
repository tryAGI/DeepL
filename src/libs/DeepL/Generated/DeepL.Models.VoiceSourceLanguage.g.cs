
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The source language of the audio stream. It can be left empty or must be one of the supported Voice API source languages and comply with IETF BCP 47 language tags.<br/>
    /// Note: Some source transcription languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.<br/>
    /// Example: en
    /// </summary>
    public enum VoiceSourceLanguage
    {
        /// <summary>
        /// Some source transcription languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        Bg,
        /// <summary>
        /// 
        /// </summary>
        Bn,
        /// <summary>
        /// 
        /// </summary>
        Cs,
        /// <summary>
        /// 
        /// </summary>
        Da,
        /// <summary>
        /// Some source transcription languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        El,
        /// <summary>
        /// Some source transcription languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.
        /// </summary>
        En,
        /// <summary>
        /// Some source transcription languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.
        /// </summary>
        Es,
        /// <summary>
        /// Some source transcription languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.
        /// </summary>
        Et,
        /// <summary>
        /// 
        /// </summary>
        Fi,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Ga,
        /// <summary>
        /// Some source transcription languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.
        /// </summary>
        He,
        /// <summary>
        /// 
        /// </summary>
        Hi,
        /// <summary>
        /// Some source transcription languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.
        /// </summary>
        Hr,
        /// <summary>
        /// 
        /// </summary>
        Hu,
        /// <summary>
        /// Some source transcription languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lv,
        /// <summary>
        /// 
        /// </summary>
        Ms,
        /// <summary>
        /// 
        /// </summary>
        Mt,
        /// <summary>
        /// 
        /// </summary>
        Nb,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// Some source transcription languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.
        /// </summary>
        Pt,
        /// <summary>
        /// Some source transcription languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.
        /// </summary>
        Ro,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Sk,
        /// <summary>
        /// 
        /// </summary>
        Sl,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// Some source transcription languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.
        /// </summary>
        Ta,
        /// <summary>
        /// Some source transcription languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.
        /// </summary>
        Th,
        /// <summary>
        /// 
        /// </summary>
        Tl,
        /// <summary>
        /// Some source transcription languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// Some source transcription languages are provided through external service partners. See the [supported languages table](/api-reference/voice#show-supported-languages) for details.
        /// </summary>
        Vi,
        /// <summary>
        /// 
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceSourceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceSourceLanguage value)
        {
            return value switch
            {
                VoiceSourceLanguage.Ar => "ar",
                VoiceSourceLanguage.Bg => "bg",
                VoiceSourceLanguage.Bn => "bn",
                VoiceSourceLanguage.Cs => "cs",
                VoiceSourceLanguage.Da => "da",
                VoiceSourceLanguage.De => "de",
                VoiceSourceLanguage.El => "el",
                VoiceSourceLanguage.En => "en",
                VoiceSourceLanguage.Es => "es",
                VoiceSourceLanguage.Et => "et",
                VoiceSourceLanguage.Fi => "fi",
                VoiceSourceLanguage.Fr => "fr",
                VoiceSourceLanguage.Ga => "ga",
                VoiceSourceLanguage.He => "he",
                VoiceSourceLanguage.Hi => "hi",
                VoiceSourceLanguage.Hr => "hr",
                VoiceSourceLanguage.Hu => "hu",
                VoiceSourceLanguage.Id => "id",
                VoiceSourceLanguage.It => "it",
                VoiceSourceLanguage.Ja => "ja",
                VoiceSourceLanguage.Ko => "ko",
                VoiceSourceLanguage.Lt => "lt",
                VoiceSourceLanguage.Lv => "lv",
                VoiceSourceLanguage.Ms => "ms",
                VoiceSourceLanguage.Mt => "mt",
                VoiceSourceLanguage.Nb => "nb",
                VoiceSourceLanguage.Nl => "nl",
                VoiceSourceLanguage.Pl => "pl",
                VoiceSourceLanguage.Pt => "pt",
                VoiceSourceLanguage.Ro => "ro",
                VoiceSourceLanguage.Ru => "ru",
                VoiceSourceLanguage.Sk => "sk",
                VoiceSourceLanguage.Sl => "sl",
                VoiceSourceLanguage.Sv => "sv",
                VoiceSourceLanguage.Ta => "ta",
                VoiceSourceLanguage.Th => "th",
                VoiceSourceLanguage.Tl => "tl",
                VoiceSourceLanguage.Tr => "tr",
                VoiceSourceLanguage.Uk => "uk",
                VoiceSourceLanguage.Vi => "vi",
                VoiceSourceLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceSourceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => VoiceSourceLanguage.Ar,
                "bg" => VoiceSourceLanguage.Bg,
                "bn" => VoiceSourceLanguage.Bn,
                "cs" => VoiceSourceLanguage.Cs,
                "da" => VoiceSourceLanguage.Da,
                "de" => VoiceSourceLanguage.De,
                "el" => VoiceSourceLanguage.El,
                "en" => VoiceSourceLanguage.En,
                "es" => VoiceSourceLanguage.Es,
                "et" => VoiceSourceLanguage.Et,
                "fi" => VoiceSourceLanguage.Fi,
                "fr" => VoiceSourceLanguage.Fr,
                "ga" => VoiceSourceLanguage.Ga,
                "he" => VoiceSourceLanguage.He,
                "hi" => VoiceSourceLanguage.Hi,
                "hr" => VoiceSourceLanguage.Hr,
                "hu" => VoiceSourceLanguage.Hu,
                "id" => VoiceSourceLanguage.Id,
                "it" => VoiceSourceLanguage.It,
                "ja" => VoiceSourceLanguage.Ja,
                "ko" => VoiceSourceLanguage.Ko,
                "lt" => VoiceSourceLanguage.Lt,
                "lv" => VoiceSourceLanguage.Lv,
                "ms" => VoiceSourceLanguage.Ms,
                "mt" => VoiceSourceLanguage.Mt,
                "nb" => VoiceSourceLanguage.Nb,
                "nl" => VoiceSourceLanguage.Nl,
                "pl" => VoiceSourceLanguage.Pl,
                "pt" => VoiceSourceLanguage.Pt,
                "ro" => VoiceSourceLanguage.Ro,
                "ru" => VoiceSourceLanguage.Ru,
                "sk" => VoiceSourceLanguage.Sk,
                "sl" => VoiceSourceLanguage.Sl,
                "sv" => VoiceSourceLanguage.Sv,
                "ta" => VoiceSourceLanguage.Ta,
                "th" => VoiceSourceLanguage.Th,
                "tl" => VoiceSourceLanguage.Tl,
                "tr" => VoiceSourceLanguage.Tr,
                "uk" => VoiceSourceLanguage.Uk,
                "vi" => VoiceSourceLanguage.Vi,
                "zh" => VoiceSourceLanguage.Zh,
                _ => null,
            };
        }
    }
}