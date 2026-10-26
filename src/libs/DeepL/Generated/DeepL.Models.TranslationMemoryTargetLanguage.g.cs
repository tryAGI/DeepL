
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The list of target languages available in the translation memory. A translation memory's target language must be compatible with the `target_lang` specified in a translation request.<br/>
    /// Example: es
    /// </summary>
    public enum TranslationMemoryTargetLanguage
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
        DeCh,
        /// <summary>
        ///
        /// </summary>
        DeDe,
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
        Es419,
        /// <summary>
        ///
        /// </summary>
        EsEs,
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
        FrCa,
        /// <summary>
        ///
        /// </summary>
        FrFr,
        /// <summary>
        ///
        /// </summary>
        He,
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
    public static class TranslationMemoryTargetLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationMemoryTargetLanguage value)
        {
            return value switch
            {
                TranslationMemoryTargetLanguage.Ar => "ar",
                TranslationMemoryTargetLanguage.Bg => "bg",
                TranslationMemoryTargetLanguage.Cs => "cs",
                TranslationMemoryTargetLanguage.Da => "da",
                TranslationMemoryTargetLanguage.De => "de",
                TranslationMemoryTargetLanguage.DeCh => "de-ch",
                TranslationMemoryTargetLanguage.DeDe => "de-de",
                TranslationMemoryTargetLanguage.El => "el",
                TranslationMemoryTargetLanguage.En => "en",
                TranslationMemoryTargetLanguage.EnGb => "en-gb",
                TranslationMemoryTargetLanguage.EnUs => "en-us",
                TranslationMemoryTargetLanguage.Es => "es",
                TranslationMemoryTargetLanguage.Es419 => "es-419",
                TranslationMemoryTargetLanguage.EsEs => "es-es",
                TranslationMemoryTargetLanguage.Et => "et",
                TranslationMemoryTargetLanguage.Fi => "fi",
                TranslationMemoryTargetLanguage.Fr => "fr",
                TranslationMemoryTargetLanguage.FrCa => "fr-ca",
                TranslationMemoryTargetLanguage.FrFr => "fr-fr",
                TranslationMemoryTargetLanguage.He => "he",
                TranslationMemoryTargetLanguage.Hu => "hu",
                TranslationMemoryTargetLanguage.Id => "id",
                TranslationMemoryTargetLanguage.It => "it",
                TranslationMemoryTargetLanguage.Ja => "ja",
                TranslationMemoryTargetLanguage.Ko => "ko",
                TranslationMemoryTargetLanguage.Lt => "lt",
                TranslationMemoryTargetLanguage.Lv => "lv",
                TranslationMemoryTargetLanguage.Nb => "nb",
                TranslationMemoryTargetLanguage.Nl => "nl",
                TranslationMemoryTargetLanguage.Pl => "pl",
                TranslationMemoryTargetLanguage.PtBr => "pt-br",
                TranslationMemoryTargetLanguage.PtPt => "pt-pt",
                TranslationMemoryTargetLanguage.Ro => "ro",
                TranslationMemoryTargetLanguage.Ru => "ru",
                TranslationMemoryTargetLanguage.Sk => "sk",
                TranslationMemoryTargetLanguage.Sl => "sl",
                TranslationMemoryTargetLanguage.Sv => "sv",
                TranslationMemoryTargetLanguage.Th => "th",
                TranslationMemoryTargetLanguage.Tr => "tr",
                TranslationMemoryTargetLanguage.Uk => "uk",
                TranslationMemoryTargetLanguage.Vi => "vi",
                TranslationMemoryTargetLanguage.Zh => "zh",
                TranslationMemoryTargetLanguage.ZhHans => "zh-hans",
                TranslationMemoryTargetLanguage.ZhHant => "zh-hant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationMemoryTargetLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => TranslationMemoryTargetLanguage.Ar,
                "bg" => TranslationMemoryTargetLanguage.Bg,
                "cs" => TranslationMemoryTargetLanguage.Cs,
                "da" => TranslationMemoryTargetLanguage.Da,
                "de" => TranslationMemoryTargetLanguage.De,
                "de-ch" => TranslationMemoryTargetLanguage.DeCh,
                "de-de" => TranslationMemoryTargetLanguage.DeDe,
                "el" => TranslationMemoryTargetLanguage.El,
                "en" => TranslationMemoryTargetLanguage.En,
                "en-gb" => TranslationMemoryTargetLanguage.EnGb,
                "en-us" => TranslationMemoryTargetLanguage.EnUs,
                "es" => TranslationMemoryTargetLanguage.Es,
                "es-419" => TranslationMemoryTargetLanguage.Es419,
                "es-es" => TranslationMemoryTargetLanguage.EsEs,
                "et" => TranslationMemoryTargetLanguage.Et,
                "fi" => TranslationMemoryTargetLanguage.Fi,
                "fr" => TranslationMemoryTargetLanguage.Fr,
                "fr-ca" => TranslationMemoryTargetLanguage.FrCa,
                "fr-fr" => TranslationMemoryTargetLanguage.FrFr,
                "he" => TranslationMemoryTargetLanguage.He,
                "hu" => TranslationMemoryTargetLanguage.Hu,
                "id" => TranslationMemoryTargetLanguage.Id,
                "it" => TranslationMemoryTargetLanguage.It,
                "ja" => TranslationMemoryTargetLanguage.Ja,
                "ko" => TranslationMemoryTargetLanguage.Ko,
                "lt" => TranslationMemoryTargetLanguage.Lt,
                "lv" => TranslationMemoryTargetLanguage.Lv,
                "nb" => TranslationMemoryTargetLanguage.Nb,
                "nl" => TranslationMemoryTargetLanguage.Nl,
                "pl" => TranslationMemoryTargetLanguage.Pl,
                "pt-br" => TranslationMemoryTargetLanguage.PtBr,
                "pt-pt" => TranslationMemoryTargetLanguage.PtPt,
                "ro" => TranslationMemoryTargetLanguage.Ro,
                "ru" => TranslationMemoryTargetLanguage.Ru,
                "sk" => TranslationMemoryTargetLanguage.Sk,
                "sl" => TranslationMemoryTargetLanguage.Sl,
                "sv" => TranslationMemoryTargetLanguage.Sv,
                "th" => TranslationMemoryTargetLanguage.Th,
                "tr" => TranslationMemoryTargetLanguage.Tr,
                "uk" => TranslationMemoryTargetLanguage.Uk,
                "vi" => TranslationMemoryTargetLanguage.Vi,
                "zh" => TranslationMemoryTargetLanguage.Zh,
                "zh-hans" => TranslationMemoryTargetLanguage.ZhHans,
                "zh-hant" => TranslationMemoryTargetLanguage.ZhHant,
                _ => null,
            };
        }
    }
}