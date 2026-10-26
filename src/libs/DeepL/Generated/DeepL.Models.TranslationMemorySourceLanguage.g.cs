
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The source language of the translation memory.<br/>
    /// Example: en
    /// </summary>
    public enum TranslationMemorySourceLanguage
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
        Pt,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationMemorySourceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationMemorySourceLanguage value)
        {
            return value switch
            {
                TranslationMemorySourceLanguage.Ar => "ar",
                TranslationMemorySourceLanguage.Bg => "bg",
                TranslationMemorySourceLanguage.Cs => "cs",
                TranslationMemorySourceLanguage.Da => "da",
                TranslationMemorySourceLanguage.De => "de",
                TranslationMemorySourceLanguage.El => "el",
                TranslationMemorySourceLanguage.En => "en",
                TranslationMemorySourceLanguage.Es => "es",
                TranslationMemorySourceLanguage.Et => "et",
                TranslationMemorySourceLanguage.Fi => "fi",
                TranslationMemorySourceLanguage.Fr => "fr",
                TranslationMemorySourceLanguage.He => "he",
                TranslationMemorySourceLanguage.Hu => "hu",
                TranslationMemorySourceLanguage.Id => "id",
                TranslationMemorySourceLanguage.It => "it",
                TranslationMemorySourceLanguage.Ja => "ja",
                TranslationMemorySourceLanguage.Ko => "ko",
                TranslationMemorySourceLanguage.Lt => "lt",
                TranslationMemorySourceLanguage.Lv => "lv",
                TranslationMemorySourceLanguage.Nb => "nb",
                TranslationMemorySourceLanguage.Nl => "nl",
                TranslationMemorySourceLanguage.Pl => "pl",
                TranslationMemorySourceLanguage.Pt => "pt",
                TranslationMemorySourceLanguage.Ro => "ro",
                TranslationMemorySourceLanguage.Ru => "ru",
                TranslationMemorySourceLanguage.Sk => "sk",
                TranslationMemorySourceLanguage.Sl => "sl",
                TranslationMemorySourceLanguage.Sv => "sv",
                TranslationMemorySourceLanguage.Th => "th",
                TranslationMemorySourceLanguage.Tr => "tr",
                TranslationMemorySourceLanguage.Uk => "uk",
                TranslationMemorySourceLanguage.Vi => "vi",
                TranslationMemorySourceLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationMemorySourceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => TranslationMemorySourceLanguage.Ar,
                "bg" => TranslationMemorySourceLanguage.Bg,
                "cs" => TranslationMemorySourceLanguage.Cs,
                "da" => TranslationMemorySourceLanguage.Da,
                "de" => TranslationMemorySourceLanguage.De,
                "el" => TranslationMemorySourceLanguage.El,
                "en" => TranslationMemorySourceLanguage.En,
                "es" => TranslationMemorySourceLanguage.Es,
                "et" => TranslationMemorySourceLanguage.Et,
                "fi" => TranslationMemorySourceLanguage.Fi,
                "fr" => TranslationMemorySourceLanguage.Fr,
                "he" => TranslationMemorySourceLanguage.He,
                "hu" => TranslationMemorySourceLanguage.Hu,
                "id" => TranslationMemorySourceLanguage.Id,
                "it" => TranslationMemorySourceLanguage.It,
                "ja" => TranslationMemorySourceLanguage.Ja,
                "ko" => TranslationMemorySourceLanguage.Ko,
                "lt" => TranslationMemorySourceLanguage.Lt,
                "lv" => TranslationMemorySourceLanguage.Lv,
                "nb" => TranslationMemorySourceLanguage.Nb,
                "nl" => TranslationMemorySourceLanguage.Nl,
                "pl" => TranslationMemorySourceLanguage.Pl,
                "pt" => TranslationMemorySourceLanguage.Pt,
                "ro" => TranslationMemorySourceLanguage.Ro,
                "ru" => TranslationMemorySourceLanguage.Ru,
                "sk" => TranslationMemorySourceLanguage.Sk,
                "sl" => TranslationMemorySourceLanguage.Sl,
                "sv" => TranslationMemorySourceLanguage.Sv,
                "th" => TranslationMemorySourceLanguage.Th,
                "tr" => TranslationMemorySourceLanguage.Tr,
                "uk" => TranslationMemorySourceLanguage.Uk,
                "vi" => TranslationMemorySourceLanguage.Vi,
                "zh" => TranslationMemorySourceLanguage.Zh,
                _ => null,
            };
        }
    }
}