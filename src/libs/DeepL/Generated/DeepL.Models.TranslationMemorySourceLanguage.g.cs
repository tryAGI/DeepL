
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
        De,
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
                TranslationMemorySourceLanguage.De => "de",
                TranslationMemorySourceLanguage.En => "en",
                TranslationMemorySourceLanguage.Es => "es",
                TranslationMemorySourceLanguage.Fr => "fr",
                TranslationMemorySourceLanguage.It => "it",
                TranslationMemorySourceLanguage.Ja => "ja",
                TranslationMemorySourceLanguage.Ko => "ko",
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
                "de" => TranslationMemorySourceLanguage.De,
                "en" => TranslationMemorySourceLanguage.En,
                "es" => TranslationMemorySourceLanguage.Es,
                "fr" => TranslationMemorySourceLanguage.Fr,
                "it" => TranslationMemorySourceLanguage.It,
                "ja" => TranslationMemorySourceLanguage.Ja,
                "ko" => TranslationMemorySourceLanguage.Ko,
                "zh" => TranslationMemorySourceLanguage.Zh,
                _ => null,
            };
        }
    }
}