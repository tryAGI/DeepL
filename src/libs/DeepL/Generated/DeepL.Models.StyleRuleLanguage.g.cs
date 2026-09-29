
#nullable enable

namespace DeepL
{
    /// <summary>
    /// The target language the style rule list applies to. Codes are matched case-insensitively;<br/>
    /// the response returns the canonical form (for example `de-CH`).<br/>
    /// A root code (for example `en`) applies to that language and all of its variants. A variant<br/>
    /// code (for example `en-GB`) applies only when `target_lang` is that variant.<br/>
    /// Variant lists for `de-CH`, `fr-CA`, `pt-BR`, and `pt-PT` are generally available. Variant<br/>
    /// lists for `de-DE`, `en-GB`, `en-US`, `es-419`, `es-ES`, `fr-FR`, `zh-Hans`, and `zh-Hant`<br/>
    /// are in beta. The current list and the status of each language are returned by<br/>
    /// [`GET /v3/languages?resource=style_rules&amp;include=beta`](/docs/languages/using-the-languages-api).
    /// </summary>
    public enum StyleRuleLanguage
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
    public static class StyleRuleLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StyleRuleLanguage value)
        {
            return value switch
            {
                StyleRuleLanguage.Ar => "ar",
                StyleRuleLanguage.Bg => "bg",
                StyleRuleLanguage.Cs => "cs",
                StyleRuleLanguage.Da => "da",
                StyleRuleLanguage.De => "de",
                StyleRuleLanguage.DeCh => "de-CH",
                StyleRuleLanguage.DeDe => "de-DE",
                StyleRuleLanguage.El => "el",
                StyleRuleLanguage.En => "en",
                StyleRuleLanguage.EnGb => "en-GB",
                StyleRuleLanguage.EnUs => "en-US",
                StyleRuleLanguage.Es => "es",
                StyleRuleLanguage.Es419 => "es-419",
                StyleRuleLanguage.EsEs => "es-ES",
                StyleRuleLanguage.Et => "et",
                StyleRuleLanguage.Fi => "fi",
                StyleRuleLanguage.Fr => "fr",
                StyleRuleLanguage.FrCa => "fr-CA",
                StyleRuleLanguage.FrFr => "fr-FR",
                StyleRuleLanguage.He => "he",
                StyleRuleLanguage.Hu => "hu",
                StyleRuleLanguage.Id => "id",
                StyleRuleLanguage.It => "it",
                StyleRuleLanguage.Ja => "ja",
                StyleRuleLanguage.Ko => "ko",
                StyleRuleLanguage.Lt => "lt",
                StyleRuleLanguage.Lv => "lv",
                StyleRuleLanguage.Nb => "nb",
                StyleRuleLanguage.Nl => "nl",
                StyleRuleLanguage.Pl => "pl",
                StyleRuleLanguage.Pt => "pt",
                StyleRuleLanguage.PtBr => "pt-BR",
                StyleRuleLanguage.PtPt => "pt-PT",
                StyleRuleLanguage.Ro => "ro",
                StyleRuleLanguage.Ru => "ru",
                StyleRuleLanguage.Sk => "sk",
                StyleRuleLanguage.Sl => "sl",
                StyleRuleLanguage.Sv => "sv",
                StyleRuleLanguage.Th => "th",
                StyleRuleLanguage.Tr => "tr",
                StyleRuleLanguage.Uk => "uk",
                StyleRuleLanguage.Vi => "vi",
                StyleRuleLanguage.Zh => "zh",
                StyleRuleLanguage.ZhHans => "zh-Hans",
                StyleRuleLanguage.ZhHant => "zh-Hant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StyleRuleLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => StyleRuleLanguage.Ar,
                "bg" => StyleRuleLanguage.Bg,
                "cs" => StyleRuleLanguage.Cs,
                "da" => StyleRuleLanguage.Da,
                "de" => StyleRuleLanguage.De,
                "de-CH" => StyleRuleLanguage.DeCh,
                "de-DE" => StyleRuleLanguage.DeDe,
                "el" => StyleRuleLanguage.El,
                "en" => StyleRuleLanguage.En,
                "en-GB" => StyleRuleLanguage.EnGb,
                "en-US" => StyleRuleLanguage.EnUs,
                "es" => StyleRuleLanguage.Es,
                "es-419" => StyleRuleLanguage.Es419,
                "es-ES" => StyleRuleLanguage.EsEs,
                "et" => StyleRuleLanguage.Et,
                "fi" => StyleRuleLanguage.Fi,
                "fr" => StyleRuleLanguage.Fr,
                "fr-CA" => StyleRuleLanguage.FrCa,
                "fr-FR" => StyleRuleLanguage.FrFr,
                "he" => StyleRuleLanguage.He,
                "hu" => StyleRuleLanguage.Hu,
                "id" => StyleRuleLanguage.Id,
                "it" => StyleRuleLanguage.It,
                "ja" => StyleRuleLanguage.Ja,
                "ko" => StyleRuleLanguage.Ko,
                "lt" => StyleRuleLanguage.Lt,
                "lv" => StyleRuleLanguage.Lv,
                "nb" => StyleRuleLanguage.Nb,
                "nl" => StyleRuleLanguage.Nl,
                "pl" => StyleRuleLanguage.Pl,
                "pt" => StyleRuleLanguage.Pt,
                "pt-BR" => StyleRuleLanguage.PtBr,
                "pt-PT" => StyleRuleLanguage.PtPt,
                "ro" => StyleRuleLanguage.Ro,
                "ru" => StyleRuleLanguage.Ru,
                "sk" => StyleRuleLanguage.Sk,
                "sl" => StyleRuleLanguage.Sl,
                "sv" => StyleRuleLanguage.Sv,
                "th" => StyleRuleLanguage.Th,
                "tr" => StyleRuleLanguage.Tr,
                "uk" => StyleRuleLanguage.Uk,
                "vi" => StyleRuleLanguage.Vi,
                "zh" => StyleRuleLanguage.Zh,
                "zh-Hans" => StyleRuleLanguage.ZhHans,
                "zh-Hant" => StyleRuleLanguage.ZhHant,
                _ => null,
            };
        }
    }
}