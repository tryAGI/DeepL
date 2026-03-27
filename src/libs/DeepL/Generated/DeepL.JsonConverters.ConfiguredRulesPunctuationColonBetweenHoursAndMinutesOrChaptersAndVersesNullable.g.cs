#nullable enable

namespace DeepL.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVersesNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepL.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses?>
    {
        /// <inheritdoc />
        public override global::DeepL.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::DeepL.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVersesExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DeepL.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DeepL.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepL.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVerses? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DeepL.ConfiguredRulesPunctuationColonBetweenHoursAndMinutesOrChaptersAndVersesExtensions.ToValueString(value.Value));
            }
        }
    }
}
