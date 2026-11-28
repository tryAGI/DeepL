
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The language in which the target texts in the dictionary are specified. Besides the base languages, the<br/>
    /// target can be one of these variants: `de-CH`, `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-CA`,<br/>
    /// `fr-FR`, `pt-BR`, `pt-PT`, `zh-Hans`, or `zh-Hant`. Source languages are always base languages. The current<br/>
    /// list is returned by `GET /v3/languages?resource=glossary`.<br/>
    /// A dictionary with a base target, such as `de`, applies when translating into that language and any of its<br/>
    /// variants. A dictionary with a variant target, such as `de-CH`, applies only when translating into that<br/>
    /// exact variant.<br/>
    /// Within one glossary, each language family uses either the base language or its variants as targets, not<br/>
    /// both. For example, `de-CH` and `de-DE` can be combined, but `de` and `de-DE` cannot. Adding a dictionary<br/>
    /// that breaks this rule returns a 400 error.<br/>
    /// Example: de
    /// </summary>
    public enum MultilingualGlossaryTargetLanguage
    {
        /// <summary>
        /// `de-CH`, `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-CA`,
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
        /// `de-CH`, `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-CA`,
        /// </summary>
        De,
        /// <summary>
        /// `de-CH`, `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-CA`,
        /// </summary>
        DeCh,
        /// <summary>
        /// `de-CH`, `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-CA`,
        /// </summary>
        DeDe,
        /// <summary>
        ///
        /// </summary>
        El,
        /// <summary>
        /// `de-CH`, `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-CA`,
        /// </summary>
        En,
        /// <summary>
        /// `de-CH`, `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-CA`,
        /// </summary>
        EnGb,
        /// <summary>
        /// `de-CH`, `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-CA`,
        /// </summary>
        EnUs,
        /// <summary>
        /// `de-CH`, `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-CA`,
        /// </summary>
        Es,
        /// <summary>
        /// `de-CH`, `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-CA`,
        /// </summary>
        Es419,
        /// <summary>
        /// `de-CH`, `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-CA`,
        /// </summary>
        EsEs,
        /// <summary>
        /// `de-CH`, `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-CA`,
        /// </summary>
        Et,
        /// <summary>
        ///
        /// </summary>
        Fi,
        /// <summary>
        /// `de-CH`, `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-CA`,
        /// </summary>
        Fr,
        /// <summary>
        /// `de-CH`, `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-CA`,
        /// </summary>
        FrCa,
        /// <summary>
        ///
        /// </summary>
        FrFr,
        /// <summary>
        /// `de-CH`, `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-CA`,
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
    public static class MultilingualGlossaryTargetLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultilingualGlossaryTargetLanguage value)
        {
            return value switch
            {
                MultilingualGlossaryTargetLanguage.Ar => "ar",
                MultilingualGlossaryTargetLanguage.Bg => "bg",
                MultilingualGlossaryTargetLanguage.Cs => "cs",
                MultilingualGlossaryTargetLanguage.Da => "da",
                MultilingualGlossaryTargetLanguage.De => "de",
                MultilingualGlossaryTargetLanguage.DeCh => "de-CH",
                MultilingualGlossaryTargetLanguage.DeDe => "de-DE",
                MultilingualGlossaryTargetLanguage.El => "el",
                MultilingualGlossaryTargetLanguage.En => "en",
                MultilingualGlossaryTargetLanguage.EnGb => "en-GB",
                MultilingualGlossaryTargetLanguage.EnUs => "en-US",
                MultilingualGlossaryTargetLanguage.Es => "es",
                MultilingualGlossaryTargetLanguage.Es419 => "es-419",
                MultilingualGlossaryTargetLanguage.EsEs => "es-ES",
                MultilingualGlossaryTargetLanguage.Et => "et",
                MultilingualGlossaryTargetLanguage.Fi => "fi",
                MultilingualGlossaryTargetLanguage.Fr => "fr",
                MultilingualGlossaryTargetLanguage.FrCa => "fr-CA",
                MultilingualGlossaryTargetLanguage.FrFr => "fr-FR",
                MultilingualGlossaryTargetLanguage.He => "he",
                MultilingualGlossaryTargetLanguage.Hu => "hu",
                MultilingualGlossaryTargetLanguage.Id => "id",
                MultilingualGlossaryTargetLanguage.It => "it",
                MultilingualGlossaryTargetLanguage.Ja => "ja",
                MultilingualGlossaryTargetLanguage.Ko => "ko",
                MultilingualGlossaryTargetLanguage.Lt => "lt",
                MultilingualGlossaryTargetLanguage.Lv => "lv",
                MultilingualGlossaryTargetLanguage.Nb => "nb",
                MultilingualGlossaryTargetLanguage.Nl => "nl",
                MultilingualGlossaryTargetLanguage.Pl => "pl",
                MultilingualGlossaryTargetLanguage.Pt => "pt",
                MultilingualGlossaryTargetLanguage.PtBr => "pt-BR",
                MultilingualGlossaryTargetLanguage.PtPt => "pt-PT",
                MultilingualGlossaryTargetLanguage.Ro => "ro",
                MultilingualGlossaryTargetLanguage.Ru => "ru",
                MultilingualGlossaryTargetLanguage.Sk => "sk",
                MultilingualGlossaryTargetLanguage.Sl => "sl",
                MultilingualGlossaryTargetLanguage.Sv => "sv",
                MultilingualGlossaryTargetLanguage.Tr => "tr",
                MultilingualGlossaryTargetLanguage.Uk => "uk",
                MultilingualGlossaryTargetLanguage.Vi => "vi",
                MultilingualGlossaryTargetLanguage.Zh => "zh",
                MultilingualGlossaryTargetLanguage.ZhHans => "zh-Hans",
                MultilingualGlossaryTargetLanguage.ZhHant => "zh-Hant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultilingualGlossaryTargetLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => MultilingualGlossaryTargetLanguage.Ar,
                "bg" => MultilingualGlossaryTargetLanguage.Bg,
                "cs" => MultilingualGlossaryTargetLanguage.Cs,
                "da" => MultilingualGlossaryTargetLanguage.Da,
                "de" => MultilingualGlossaryTargetLanguage.De,
                "de-CH" => MultilingualGlossaryTargetLanguage.DeCh,
                "de-DE" => MultilingualGlossaryTargetLanguage.DeDe,
                "el" => MultilingualGlossaryTargetLanguage.El,
                "en" => MultilingualGlossaryTargetLanguage.En,
                "en-GB" => MultilingualGlossaryTargetLanguage.EnGb,
                "en-US" => MultilingualGlossaryTargetLanguage.EnUs,
                "es" => MultilingualGlossaryTargetLanguage.Es,
                "es-419" => MultilingualGlossaryTargetLanguage.Es419,
                "es-ES" => MultilingualGlossaryTargetLanguage.EsEs,
                "et" => MultilingualGlossaryTargetLanguage.Et,
                "fi" => MultilingualGlossaryTargetLanguage.Fi,
                "fr" => MultilingualGlossaryTargetLanguage.Fr,
                "fr-CA" => MultilingualGlossaryTargetLanguage.FrCa,
                "fr-FR" => MultilingualGlossaryTargetLanguage.FrFr,
                "he" => MultilingualGlossaryTargetLanguage.He,
                "hu" => MultilingualGlossaryTargetLanguage.Hu,
                "id" => MultilingualGlossaryTargetLanguage.Id,
                "it" => MultilingualGlossaryTargetLanguage.It,
                "ja" => MultilingualGlossaryTargetLanguage.Ja,
                "ko" => MultilingualGlossaryTargetLanguage.Ko,
                "lt" => MultilingualGlossaryTargetLanguage.Lt,
                "lv" => MultilingualGlossaryTargetLanguage.Lv,
                "nb" => MultilingualGlossaryTargetLanguage.Nb,
                "nl" => MultilingualGlossaryTargetLanguage.Nl,
                "pl" => MultilingualGlossaryTargetLanguage.Pl,
                "pt" => MultilingualGlossaryTargetLanguage.Pt,
                "pt-BR" => MultilingualGlossaryTargetLanguage.PtBr,
                "pt-PT" => MultilingualGlossaryTargetLanguage.PtPt,
                "ro" => MultilingualGlossaryTargetLanguage.Ro,
                "ru" => MultilingualGlossaryTargetLanguage.Ru,
                "sk" => MultilingualGlossaryTargetLanguage.Sk,
                "sl" => MultilingualGlossaryTargetLanguage.Sl,
                "sv" => MultilingualGlossaryTargetLanguage.Sv,
                "tr" => MultilingualGlossaryTargetLanguage.Tr,
                "uk" => MultilingualGlossaryTargetLanguage.Uk,
                "vi" => MultilingualGlossaryTargetLanguage.Vi,
                "zh" => MultilingualGlossaryTargetLanguage.Zh,
                "zh-Hans" => MultilingualGlossaryTargetLanguage.ZhHans,
                "zh-Hant" => MultilingualGlossaryTargetLanguage.ZhHant,
                _ => null,
            };
        }
    }
}