
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace DeepL
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceFormality), TypeInfoPropertyName = "VoiceFormality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceMessageFormat), TypeInfoPropertyName = "VoiceMessageFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTargetMediaVoice), TypeInfoPropertyName = "VoiceTargetMediaVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceSourceMediaContentType), TypeInfoPropertyName = "VoiceSourceMediaContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceSourceLanguage), TypeInfoPropertyName = "VoiceSourceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceSourceLanguageMode), TypeInfoPropertyName = "VoiceSourceLanguageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.VoiceTargetLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTargetLanguage), TypeInfoPropertyName = "VoiceTargetLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.VoiceTargetMediaLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTargetMediaLanguage), TypeInfoPropertyName = "VoiceTargetMediaLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTargetMediaContentType), TypeInfoPropertyName = "VoiceTargetMediaContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceStreamingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.InfrastructureErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.InfrastructureErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GetVoiceStreamingUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.OneOf<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>), TypeInfoPropertyName = "OneOfErrorResponseInfrastructureErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceFormality?), TypeInfoPropertyName = "NullableVoiceFormality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceMessageFormat?), TypeInfoPropertyName = "NullableVoiceMessageFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTargetMediaVoice?), TypeInfoPropertyName = "NullableVoiceTargetMediaVoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceSourceMediaContentType?), TypeInfoPropertyName = "NullableVoiceSourceMediaContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceSourceLanguage?), TypeInfoPropertyName = "NullableVoiceSourceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceSourceLanguageMode?), TypeInfoPropertyName = "NullableVoiceSourceLanguageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTargetLanguage?), TypeInfoPropertyName = "NullableVoiceTargetLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTargetMediaLanguage?), TypeInfoPropertyName = "NullableVoiceTargetMediaLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTargetMediaContentType?), TypeInfoPropertyName = "NullableVoiceTargetMediaContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.OneOf<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>?), TypeInfoPropertyName = "NullableOneOfErrorResponseInfrastructureErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.VoiceTargetLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.VoiceTargetMediaLanguage>))]
    internal sealed partial class VoiceAPISourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceAPISourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VoiceAPISourceGenerationContext Default { get; } = new(DefaultOptions);

        private VoiceAPISourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::DeepL.JsonConverters.AllOfJsonConverter<string, object>());
            options.Converters.Add(new global::DeepL.JsonConverters.AllOfJsonConverter<string, object>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>());
            options.Converters.Add(new global::DeepL.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::DeepL.VoiceFormality)

                    || typeToConvert == typeof(global::DeepL.VoiceFormality?)

                    || typeToConvert == typeof(global::DeepL.VoiceMessageFormat)

                    || typeToConvert == typeof(global::DeepL.VoiceMessageFormat?)

                    || typeToConvert == typeof(global::DeepL.VoiceTargetMediaVoice)

                    || typeToConvert == typeof(global::DeepL.VoiceTargetMediaVoice?)

                    || typeToConvert == typeof(global::DeepL.VoiceSourceMediaContentType)

                    || typeToConvert == typeof(global::DeepL.VoiceSourceMediaContentType?)

                    || typeToConvert == typeof(global::DeepL.VoiceSourceLanguage)

                    || typeToConvert == typeof(global::DeepL.VoiceSourceLanguage?)

                    || typeToConvert == typeof(global::DeepL.VoiceSourceLanguageMode)

                    || typeToConvert == typeof(global::DeepL.VoiceSourceLanguageMode?)

                    || typeToConvert == typeof(global::DeepL.VoiceTargetLanguage)

                    || typeToConvert == typeof(global::DeepL.VoiceTargetLanguage?)

                    || typeToConvert == typeof(global::DeepL.VoiceTargetMediaLanguage)

                    || typeToConvert == typeof(global::DeepL.VoiceTargetMediaLanguage?)

                    || typeToConvert == typeof(global::DeepL.VoiceTargetMediaContentType)

                    || typeToConvert == typeof(global::DeepL.VoiceTargetMediaContentType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DeepL.VoiceFormality))
                {
                    return new global::DeepL.JsonConverters.VoiceFormalityJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceFormality?))
                {
                    return new global::DeepL.JsonConverters.VoiceFormalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceMessageFormat))
                {
                    return new global::DeepL.JsonConverters.VoiceMessageFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceMessageFormat?))
                {
                    return new global::DeepL.JsonConverters.VoiceMessageFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceTargetMediaVoice))
                {
                    return new global::DeepL.JsonConverters.VoiceTargetMediaVoiceJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceTargetMediaVoice?))
                {
                    return new global::DeepL.JsonConverters.VoiceTargetMediaVoiceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceSourceMediaContentType))
                {
                    return new global::DeepL.JsonConverters.VoiceSourceMediaContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceSourceMediaContentType?))
                {
                    return new global::DeepL.JsonConverters.VoiceSourceMediaContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceSourceLanguage))
                {
                    return new global::DeepL.JsonConverters.VoiceSourceLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceSourceLanguage?))
                {
                    return new global::DeepL.JsonConverters.VoiceSourceLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceSourceLanguageMode))
                {
                    return new global::DeepL.JsonConverters.VoiceSourceLanguageModeJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceSourceLanguageMode?))
                {
                    return new global::DeepL.JsonConverters.VoiceSourceLanguageModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceTargetLanguage))
                {
                    return new global::DeepL.JsonConverters.VoiceTargetLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceTargetLanguage?))
                {
                    return new global::DeepL.JsonConverters.VoiceTargetLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceTargetMediaLanguage))
                {
                    return new global::DeepL.JsonConverters.VoiceTargetMediaLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceTargetMediaLanguage?))
                {
                    return new global::DeepL.JsonConverters.VoiceTargetMediaLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceTargetMediaContentType))
                {
                    return new global::DeepL.JsonConverters.VoiceTargetMediaContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceTargetMediaContentType?))
                {
                    return new global::DeepL.JsonConverters.VoiceTargetMediaContentTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new VoiceAPISourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}