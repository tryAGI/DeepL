
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
        De,
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
        Fr,
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
        Zh,
        /// <summary>
        /// 
        /// </summary>
        ZhHans,
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
                TranslationMemoryTargetLanguage.De => "de",
                TranslationMemoryTargetLanguage.En => "en",
                TranslationMemoryTargetLanguage.EnGb => "en-gb",
                TranslationMemoryTargetLanguage.EnUs => "en-us",
                TranslationMemoryTargetLanguage.Es => "es",
                TranslationMemoryTargetLanguage.Es419 => "es-419",
                TranslationMemoryTargetLanguage.Fr => "fr",
                TranslationMemoryTargetLanguage.It => "it",
                TranslationMemoryTargetLanguage.Ja => "ja",
                TranslationMemoryTargetLanguage.Ko => "ko",
                TranslationMemoryTargetLanguage.Zh => "zh",
                TranslationMemoryTargetLanguage.ZhHans => "zh-hans",
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
                "de" => TranslationMemoryTargetLanguage.De,
                "en" => TranslationMemoryTargetLanguage.En,
                "en-gb" => TranslationMemoryTargetLanguage.EnGb,
                "en-us" => TranslationMemoryTargetLanguage.EnUs,
                "es" => TranslationMemoryTargetLanguage.Es,
                "es-419" => TranslationMemoryTargetLanguage.Es419,
                "fr" => TranslationMemoryTargetLanguage.Fr,
                "it" => TranslationMemoryTargetLanguage.It,
                "ja" => TranslationMemoryTargetLanguage.Ja,
                "ko" => TranslationMemoryTargetLanguage.Ko,
                "zh" => TranslationMemoryTargetLanguage.Zh,
                "zh-hans" => TranslationMemoryTargetLanguage.ZhHans,
                _ => null,
            };
        }
    }
}