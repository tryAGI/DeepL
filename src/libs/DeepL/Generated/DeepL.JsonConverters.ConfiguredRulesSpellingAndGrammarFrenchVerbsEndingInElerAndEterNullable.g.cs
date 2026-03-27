#nullable enable

namespace DeepL.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEterNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepL.ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEter?>
    {
        /// <inheritdoc />
        public override global::DeepL.ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEter? Read(
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
                        return global::DeepL.ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEterExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DeepL.ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEter)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DeepL.ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEter?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepL.ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEter? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DeepL.ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEterExtensions.ToValueString(value.Value));
            }
        }
    }
}
