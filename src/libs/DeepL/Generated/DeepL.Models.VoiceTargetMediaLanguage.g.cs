
#nullable enable

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    public enum VoiceTargetMediaLanguage
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
        Fi,
        /// <summary>
        ///
        /// </summary>
        Fr,
        /// <summary>
        ///
        /// </summary>
        Hi,
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
        Ms,
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
        Sv,
        /// <summary>
        ///
        /// </summary>
        Ta,
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
    public static class VoiceTargetMediaLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceTargetMediaLanguage value)
        {
            return value switch
            {
                VoiceTargetMediaLanguage.Ar => "ar",
                VoiceTargetMediaLanguage.Bg => "bg",
                VoiceTargetMediaLanguage.Cs => "cs",
                VoiceTargetMediaLanguage.Da => "da",
                VoiceTargetMediaLanguage.De => "de",
                VoiceTargetMediaLanguage.El => "el",
                VoiceTargetMediaLanguage.En => "en",
                VoiceTargetMediaLanguage.EnGb => "en-GB",
                VoiceTargetMediaLanguage.EnUs => "en-US",
                VoiceTargetMediaLanguage.Es => "es",
                VoiceTargetMediaLanguage.Fi => "fi",
                VoiceTargetMediaLanguage.Fr => "fr",
                VoiceTargetMediaLanguage.Hi => "hi",
                VoiceTargetMediaLanguage.Hu => "hu",
                VoiceTargetMediaLanguage.Id => "id",
                VoiceTargetMediaLanguage.It => "it",
                VoiceTargetMediaLanguage.Ja => "ja",
                VoiceTargetMediaLanguage.Ko => "ko",
                VoiceTargetMediaLanguage.Ms => "ms",
                VoiceTargetMediaLanguage.Nb => "nb",
                VoiceTargetMediaLanguage.Nl => "nl",
                VoiceTargetMediaLanguage.Pl => "pl",
                VoiceTargetMediaLanguage.Pt => "pt",
                VoiceTargetMediaLanguage.PtBr => "pt-BR",
                VoiceTargetMediaLanguage.PtPt => "pt-PT",
                VoiceTargetMediaLanguage.Ro => "ro",
                VoiceTargetMediaLanguage.Ru => "ru",
                VoiceTargetMediaLanguage.Sk => "sk",
                VoiceTargetMediaLanguage.Sv => "sv",
                VoiceTargetMediaLanguage.Ta => "ta",
                VoiceTargetMediaLanguage.Tr => "tr",
                VoiceTargetMediaLanguage.Uk => "uk",
                VoiceTargetMediaLanguage.Vi => "vi",
                VoiceTargetMediaLanguage.Zh => "zh",
                VoiceTargetMediaLanguage.ZhHans => "zh-HANS",
                VoiceTargetMediaLanguage.ZhHant => "zh-HANT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceTargetMediaLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => VoiceTargetMediaLanguage.Ar,
                "bg" => VoiceTargetMediaLanguage.Bg,
                "cs" => VoiceTargetMediaLanguage.Cs,
                "da" => VoiceTargetMediaLanguage.Da,
                "de" => VoiceTargetMediaLanguage.De,
                "el" => VoiceTargetMediaLanguage.El,
                "en" => VoiceTargetMediaLanguage.En,
                "en-GB" => VoiceTargetMediaLanguage.EnGb,
                "en-US" => VoiceTargetMediaLanguage.EnUs,
                "es" => VoiceTargetMediaLanguage.Es,
                "fi" => VoiceTargetMediaLanguage.Fi,
                "fr" => VoiceTargetMediaLanguage.Fr,
                "hi" => VoiceTargetMediaLanguage.Hi,
                "hu" => VoiceTargetMediaLanguage.Hu,
                "id" => VoiceTargetMediaLanguage.Id,
                "it" => VoiceTargetMediaLanguage.It,
                "ja" => VoiceTargetMediaLanguage.Ja,
                "ko" => VoiceTargetMediaLanguage.Ko,
                "ms" => VoiceTargetMediaLanguage.Ms,
                "nb" => VoiceTargetMediaLanguage.Nb,
                "nl" => VoiceTargetMediaLanguage.Nl,
                "pl" => VoiceTargetMediaLanguage.Pl,
                "pt" => VoiceTargetMediaLanguage.Pt,
                "pt-BR" => VoiceTargetMediaLanguage.PtBr,
                "pt-PT" => VoiceTargetMediaLanguage.PtPt,
                "ro" => VoiceTargetMediaLanguage.Ro,
                "ru" => VoiceTargetMediaLanguage.Ru,
                "sk" => VoiceTargetMediaLanguage.Sk,
                "sv" => VoiceTargetMediaLanguage.Sv,
                "ta" => VoiceTargetMediaLanguage.Ta,
                "tr" => VoiceTargetMediaLanguage.Tr,
                "uk" => VoiceTargetMediaLanguage.Uk,
                "vi" => VoiceTargetMediaLanguage.Vi,
                "zh" => VoiceTargetMediaLanguage.Zh,
                "zh-HANS" => VoiceTargetMediaLanguage.ZhHans,
                "zh-HANT" => VoiceTargetMediaLanguage.ZhHant,
                _ => null,
            };
        }
    }
}