#nullable enable

namespace DeepL.JsonConverters
{
    /// <inheritdoc />
    public sealed class PreserveFormattingOptionStrNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepL.PreserveFormattingOptionStr?>
    {
        /// <inheritdoc />
        public override global::DeepL.PreserveFormattingOptionStr? Read(
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
                        return global::DeepL.PreserveFormattingOptionStrExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DeepL.PreserveFormattingOptionStr)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DeepL.PreserveFormattingOptionStr?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepL.PreserveFormattingOptionStr? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DeepL.PreserveFormattingOptionStrExtensions.ToValueString(value.Value));
            }
        }
    }
}
