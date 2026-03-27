#nullable enable

namespace DeepL.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfiguredRulesStyleAndToneDeclarativeEndingsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepL.ConfiguredRulesStyleAndToneDeclarativeEndings>
    {
        /// <inheritdoc />
        public override global::DeepL.ConfiguredRulesStyleAndToneDeclarativeEndings Read(
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
                        return global::DeepL.ConfiguredRulesStyleAndToneDeclarativeEndingsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DeepL.ConfiguredRulesStyleAndToneDeclarativeEndings)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DeepL.ConfiguredRulesStyleAndToneDeclarativeEndings);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepL.ConfiguredRulesStyleAndToneDeclarativeEndings value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DeepL.ConfiguredRulesStyleAndToneDeclarativeEndingsExtensions.ToValueString(value));
        }
    }
}
