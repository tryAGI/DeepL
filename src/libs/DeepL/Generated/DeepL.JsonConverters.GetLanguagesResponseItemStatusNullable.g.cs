#nullable enable

namespace DeepL.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetLanguagesResponseItemStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DeepL.GetLanguagesResponseItemStatus?>
    {
        /// <inheritdoc />
        public override global::DeepL.GetLanguagesResponseItemStatus? Read(
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
                        return global::DeepL.GetLanguagesResponseItemStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DeepL.GetLanguagesResponseItemStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DeepL.GetLanguagesResponseItemStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DeepL.GetLanguagesResponseItemStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DeepL.GetLanguagesResponseItemStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
