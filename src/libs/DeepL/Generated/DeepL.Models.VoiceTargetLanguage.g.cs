
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceTargetLanguage
    {
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        El,
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        EnGb,
        /// <summary>
        /// 
        /// </summary>
        EnUs,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        He,
        /// <summary>
        /// 
        /// </summary>
        Hr,
        /// <summary>
        /// 
        /// </summary>
        Hu,
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        Pt,
        /// <summary>
        /// 
        /// </summary>
        PtBr,
        /// <summary>
        /// 
        /// </summary>
        PtPt,
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        Th,
        /// <summary>
        /// 
        /// </summary>
        Tl,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// 
        /// </summary>
        Vi,
        /// <summary>
        /// 
        /// </summary>
        Zh,
        /// <summary>
        /// 
        /// </summary>
        ZhHans,
        /// <summary>
        /// 
        /// </summary>
        ZhHant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceTargetLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceTargetLanguage value)
        {
            return value switch
            {
                VoiceTargetLanguage.Ar => "ar",
                VoiceTargetLanguage.Bg => "bg",
                VoiceTargetLanguage.Bn => "bn",
                VoiceTargetLanguage.Cs => "cs",
                VoiceTargetLanguage.Da => "da",
                VoiceTargetLanguage.De => "de",
                VoiceTargetLanguage.El => "el",
                VoiceTargetLanguage.En => "en",
                VoiceTargetLanguage.EnGb => "en-GB",
                VoiceTargetLanguage.EnUs => "en-US",
                VoiceTargetLanguage.Es => "es",
                VoiceTargetLanguage.Et => "et",
                VoiceTargetLanguage.Fi => "fi",
                VoiceTargetLanguage.Fr => "fr",
                VoiceTargetLanguage.Ga => "ga",
                VoiceTargetLanguage.He => "he",
                VoiceTargetLanguage.Hr => "hr",
                VoiceTargetLanguage.Hu => "hu",
                VoiceTargetLanguage.Id => "id",
                VoiceTargetLanguage.It => "it",
                VoiceTargetLanguage.Ja => "ja",
                VoiceTargetLanguage.Ko => "ko",
                VoiceTargetLanguage.Lt => "lt",
                VoiceTargetLanguage.Lv => "lv",
                VoiceTargetLanguage.Mt => "mt",
                VoiceTargetLanguage.Nb => "nb",
                VoiceTargetLanguage.Nl => "nl",
                VoiceTargetLanguage.Pl => "pl",
                VoiceTargetLanguage.Pt => "pt",
                VoiceTargetLanguage.PtBr => "pt-BR",
                VoiceTargetLanguage.PtPt => "pt-PT",
                VoiceTargetLanguage.Ro => "ro",
                VoiceTargetLanguage.Ru => "ru",
                VoiceTargetLanguage.Sk => "sk",
                VoiceTargetLanguage.Sl => "sl",
                VoiceTargetLanguage.Sv => "sv",
                VoiceTargetLanguage.Th => "th",
                VoiceTargetLanguage.Tl => "tl",
                VoiceTargetLanguage.Tr => "tr",
                VoiceTargetLanguage.Uk => "uk",
                VoiceTargetLanguage.Vi => "vi",
                VoiceTargetLanguage.Zh => "zh",
                VoiceTargetLanguage.ZhHans => "zh-HANS",
                VoiceTargetLanguage.ZhHant => "zh-HANT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceTargetLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => VoiceTargetLanguage.Ar,
                "bg" => VoiceTargetLanguage.Bg,
                "bn" => VoiceTargetLanguage.Bn,
                "cs" => VoiceTargetLanguage.Cs,
                "da" => VoiceTargetLanguage.Da,
                "de" => VoiceTargetLanguage.De,
                "el" => VoiceTargetLanguage.El,
                "en" => VoiceTargetLanguage.En,
                "en-GB" => VoiceTargetLanguage.EnGb,
                "en-US" => VoiceTargetLanguage.EnUs,
                "es" => VoiceTargetLanguage.Es,
                "et" => VoiceTargetLanguage.Et,
                "fi" => VoiceTargetLanguage.Fi,
                "fr" => VoiceTargetLanguage.Fr,
                "ga" => VoiceTargetLanguage.Ga,
                "he" => VoiceTargetLanguage.He,
                "hr" => VoiceTargetLanguage.Hr,
                "hu" => VoiceTargetLanguage.Hu,
                "id" => VoiceTargetLanguage.Id,
                "it" => VoiceTargetLanguage.It,
                "ja" => VoiceTargetLanguage.Ja,
                "ko" => VoiceTargetLanguage.Ko,
                "lt" => VoiceTargetLanguage.Lt,
                "lv" => VoiceTargetLanguage.Lv,
                "mt" => VoiceTargetLanguage.Mt,
                "nb" => VoiceTargetLanguage.Nb,
                "nl" => VoiceTargetLanguage.Nl,
                "pl" => VoiceTargetLanguage.Pl,
                "pt" => VoiceTargetLanguage.Pt,
                "pt-BR" => VoiceTargetLanguage.PtBr,
                "pt-PT" => VoiceTargetLanguage.PtPt,
                "ro" => VoiceTargetLanguage.Ro,
                "ru" => VoiceTargetLanguage.Ru,
                "sk" => VoiceTargetLanguage.Sk,
                "sl" => VoiceTargetLanguage.Sl,
                "sv" => VoiceTargetLanguage.Sv,
                "th" => VoiceTargetLanguage.Th,
                "tl" => VoiceTargetLanguage.Tl,
                "tr" => VoiceTargetLanguage.Tr,
                "uk" => VoiceTargetLanguage.Uk,
                "vi" => VoiceTargetLanguage.Vi,
                "zh" => VoiceTargetLanguage.Zh,
                "zh-HANS" => VoiceTargetLanguage.ZhHans,
                "zh-HANT" => VoiceTargetLanguage.ZhHant,
                _ => null,
            };
        }
    }
}