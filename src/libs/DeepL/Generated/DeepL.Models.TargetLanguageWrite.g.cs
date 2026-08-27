
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The language for the text improvement.<br/>
    /// Example: de
    /// </summary>
    public enum TargetLanguageWrite
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
        Zh,
        /// <summary>
        ///
        /// </summary>
        ZhHans,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TargetLanguageWriteExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TargetLanguageWrite value)
        {
            return value switch
            {
                TargetLanguageWrite.De => "de",
                TargetLanguageWrite.En => "en",
                TargetLanguageWrite.EnGb => "en-GB",
                TargetLanguageWrite.EnUs => "en-US",
                TargetLanguageWrite.Es => "es",
                TargetLanguageWrite.Fr => "fr",
                TargetLanguageWrite.It => "it",
                TargetLanguageWrite.Ja => "ja",
                TargetLanguageWrite.Ko => "ko",
                TargetLanguageWrite.Pt => "pt",
                TargetLanguageWrite.PtBr => "pt-BR",
                TargetLanguageWrite.PtPt => "pt-PT",
                TargetLanguageWrite.Zh => "zh",
                TargetLanguageWrite.ZhHans => "zh-Hans",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TargetLanguageWrite? ToEnum(string value)
        {
            return value switch
            {
                "de" => TargetLanguageWrite.De,
                "en" => TargetLanguageWrite.En,
                "en-GB" => TargetLanguageWrite.EnGb,
                "en-US" => TargetLanguageWrite.EnUs,
                "es" => TargetLanguageWrite.Es,
                "fr" => TargetLanguageWrite.Fr,
                "it" => TargetLanguageWrite.It,
                "ja" => TargetLanguageWrite.Ja,
                "ko" => TargetLanguageWrite.Ko,
                "pt" => TargetLanguageWrite.Pt,
                "pt-BR" => TargetLanguageWrite.PtBr,
                "pt-PT" => TargetLanguageWrite.PtPt,
                "zh" => TargetLanguageWrite.Zh,
                "zh-Hans" => TargetLanguageWrite.ZhHans,
                _ => null,
            };
        }
    }
}