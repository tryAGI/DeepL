
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfiguredRulesFormatting
    {
        /// <summary>
        /// Formatting options for Email Address Format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_address_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingEmailAddressFormatJsonConverter))]
        public global::DeepL.ConfiguredRulesFormattingEmailAddressFormat? EmailAddressFormat { get; set; }

        /// <summary>
        /// Formatting options for Phone Number Country Code Format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_country_code_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingPhoneNumberCountryCodeFormatJsonConverter))]
        public global::DeepL.ConfiguredRulesFormattingPhoneNumberCountryCodeFormat? PhoneNumberCountryCodeFormat { get; set; }

        /// <summary>
        /// Formatting options for Phone Number Format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingPhoneNumberFormatJsonConverter))]
        public global::DeepL.ConfiguredRulesFormattingPhoneNumberFormat? PhoneNumberFormat { get; set; }

        /// <summary>
        /// Formatting options for Space Between Arabic Numerals And Unit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("space_between_arabic_numerals_and_unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnitJsonConverter))]
        public global::DeepL.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit? SpaceBetweenArabicNumeralsAndUnit { get; set; }

        /// <summary>
        /// Formatting options for Space Between Chinese And English
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("space_between_chinese_and_english")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingSpaceBetweenChineseAndEnglishJsonConverter))]
        public global::DeepL.ConfiguredRulesFormattingSpaceBetweenChineseAndEnglish? SpaceBetweenChineseAndEnglish { get; set; }

        /// <summary>
        /// Formatting options for Space Between Chinese Characters And Arabic Numerals
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("space_between_chinese_characters_and_arabic_numerals")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DeepL.JsonConverters.ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumeralsJsonConverter))]
        public global::DeepL.ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumerals? SpaceBetweenChineseCharactersAndArabicNumerals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRulesFormatting" /> class.
        /// </summary>
        /// <param name="emailAddressFormat">
        /// Formatting options for Email Address Format
        /// </param>
        /// <param name="phoneNumberCountryCodeFormat">
        /// Formatting options for Phone Number Country Code Format
        /// </param>
        /// <param name="phoneNumberFormat">
        /// Formatting options for Phone Number Format
        /// </param>
        /// <param name="spaceBetweenArabicNumeralsAndUnit">
        /// Formatting options for Space Between Arabic Numerals And Unit
        /// </param>
        /// <param name="spaceBetweenChineseAndEnglish">
        /// Formatting options for Space Between Chinese And English
        /// </param>
        /// <param name="spaceBetweenChineseCharactersAndArabicNumerals">
        /// Formatting options for Space Between Chinese Characters And Arabic Numerals
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfiguredRulesFormatting(
            global::DeepL.ConfiguredRulesFormattingEmailAddressFormat? emailAddressFormat,
            global::DeepL.ConfiguredRulesFormattingPhoneNumberCountryCodeFormat? phoneNumberCountryCodeFormat,
            global::DeepL.ConfiguredRulesFormattingPhoneNumberFormat? phoneNumberFormat,
            global::DeepL.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit? spaceBetweenArabicNumeralsAndUnit,
            global::DeepL.ConfiguredRulesFormattingSpaceBetweenChineseAndEnglish? spaceBetweenChineseAndEnglish,
            global::DeepL.ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumerals? spaceBetweenChineseCharactersAndArabicNumerals)
        {
            this.EmailAddressFormat = emailAddressFormat;
            this.PhoneNumberCountryCodeFormat = phoneNumberCountryCodeFormat;
            this.PhoneNumberFormat = phoneNumberFormat;
            this.SpaceBetweenArabicNumeralsAndUnit = spaceBetweenArabicNumeralsAndUnit;
            this.SpaceBetweenChineseAndEnglish = spaceBetweenChineseAndEnglish;
            this.SpaceBetweenChineseCharactersAndArabicNumerals = spaceBetweenChineseCharactersAndArabicNumerals;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguredRulesFormatting" /> class.
        /// </summary>
        public ConfiguredRulesFormatting()
        {
        }
    }
}