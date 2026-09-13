
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslationMemory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslationMemorySourceLanguage), TypeInfoPropertyName = "TranslationMemorySourceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.TranslationMemoryTargetLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslationMemoryTargetLanguage), TypeInfoPropertyName = "TranslationMemoryTargetLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslationMemorySegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.TranslationMemoryTargetSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslationMemoryTargetSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CreateTranslationMemoryExport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CreateTranslationMemoryExportParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslationMemoryJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslationMemoryJobOperation), TypeInfoPropertyName = "TranslationMemoryJobOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslationMemoryJobSourceFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslationMemoryJobParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.TranslationMemoryJobResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslationMemoryJobResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslationMemoryJobResultStatus), TypeInfoPropertyName = "TranslationMemoryJobResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslationMemoryJobResultStatusMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslationMemoryJobResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.InfrastructureErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.InfrastructureErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CreateTranslationMemoryImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CreateTranslationMemoryImportRequestSourceFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CreateTranslationMemoryImportRequestParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.OneOf<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>), TypeInfoPropertyName = "OneOfErrorResponseInfrastructureErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ListTranslationMemoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.TranslationMemory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CreateTranslationMemoryImportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GetTranslationMemorySegmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.TranslationMemorySegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslationMemorySourceLanguage?), TypeInfoPropertyName = "NullableTranslationMemorySourceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslationMemoryTargetLanguage?), TypeInfoPropertyName = "NullableTranslationMemoryTargetLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslationMemoryJobOperation?), TypeInfoPropertyName = "NullableTranslationMemoryJobOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.TranslationMemoryJobResultStatus?), TypeInfoPropertyName = "NullableTranslationMemoryJobResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.OneOf<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>?), TypeInfoPropertyName = "NullableOneOfErrorResponseInfrastructureErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.TranslationMemoryTargetLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.TranslationMemoryTargetSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.TranslationMemoryJobResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.TranslationMemory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.TranslationMemorySegment>))]
    internal sealed partial class TranslationMemoriesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TranslationMemoriesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TranslationMemoriesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TranslationMemoriesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::DeepL.TranslationMemorySourceLanguage)

                    || typeToConvert == typeof(global::DeepL.TranslationMemorySourceLanguage?)

                    || typeToConvert == typeof(global::DeepL.TranslationMemoryTargetLanguage)

                    || typeToConvert == typeof(global::DeepL.TranslationMemoryTargetLanguage?)

                    || typeToConvert == typeof(global::DeepL.TranslationMemoryJobOperation)

                    || typeToConvert == typeof(global::DeepL.TranslationMemoryJobOperation?)

                    || typeToConvert == typeof(global::DeepL.TranslationMemoryJobResultStatus)

                    || typeToConvert == typeof(global::DeepL.TranslationMemoryJobResultStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DeepL.TranslationMemorySourceLanguage))
                {
                    return new global::DeepL.JsonConverters.TranslationMemorySourceLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.TranslationMemorySourceLanguage?))
                {
                    return new global::DeepL.JsonConverters.TranslationMemorySourceLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.TranslationMemoryTargetLanguage))
                {
                    return new global::DeepL.JsonConverters.TranslationMemoryTargetLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.TranslationMemoryTargetLanguage?))
                {
                    return new global::DeepL.JsonConverters.TranslationMemoryTargetLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.TranslationMemoryJobOperation))
                {
                    return new global::DeepL.JsonConverters.TranslationMemoryJobOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.TranslationMemoryJobOperation?))
                {
                    return new global::DeepL.JsonConverters.TranslationMemoryJobOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.TranslationMemoryJobResultStatus))
                {
                    return new global::DeepL.JsonConverters.TranslationMemoryJobResultStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.TranslationMemoryJobResultStatus?))
                {
                    return new global::DeepL.JsonConverters.TranslationMemoryJobResultStatusNullableJsonConverter();
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
                    0 => new TranslationMemoriesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}