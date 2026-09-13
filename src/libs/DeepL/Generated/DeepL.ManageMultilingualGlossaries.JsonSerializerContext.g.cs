
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GlossarySourceLanguage), TypeInfoPropertyName = "GlossarySourceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GlossaryTargetLanguage), TypeInfoPropertyName = "GlossaryTargetLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CreateMultilingualGlossaryParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.GlossaryDictionary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GlossaryDictionary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GlossaryEntriesFormat), TypeInfoPropertyName = "GlossaryEntriesFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.MultilingualGlossary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.MultilingualGlossaryEntries))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.MultilingualGlossaryEntriesInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.PatchMultilingualGlossaryParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.InfrastructureErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.InfrastructureErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.OneOf<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>), TypeInfoPropertyName = "OneOfErrorResponseInfrastructureErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CreateMultilingualGlossaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ListMultilingualGlossariesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.MultilingualGlossary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ListMultilingualGlossariesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GetMultilingualGlossaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.PatchMultilingualGlossaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.DeleteMultilingualGlossaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GetMultilingualGlossaryEntriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.MultilingualGlossaryEntries>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GetMultilingualGlossaryEntriesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.DeleteDictionaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ReplaceDictionaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GlossarySourceLanguage?), TypeInfoPropertyName = "NullableGlossarySourceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GlossaryTargetLanguage?), TypeInfoPropertyName = "NullableGlossaryTargetLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GlossaryEntriesFormat?), TypeInfoPropertyName = "NullableGlossaryEntriesFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.OneOf<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>?), TypeInfoPropertyName = "NullableOneOfErrorResponseInfrastructureErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.GlossaryDictionary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.MultilingualGlossary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.MultilingualGlossaryEntries>))]
    internal sealed partial class ManageMultilingualGlossariesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManageMultilingualGlossariesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ManageMultilingualGlossariesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ManageMultilingualGlossariesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::DeepL.GlossaryEntriesFormat)

                    || typeToConvert == typeof(global::DeepL.GlossaryEntriesFormat?)

                    || typeToConvert == typeof(global::DeepL.GlossarySourceLanguage)

                    || typeToConvert == typeof(global::DeepL.GlossarySourceLanguage?)

                    || typeToConvert == typeof(global::DeepL.GlossaryTargetLanguage)

                    || typeToConvert == typeof(global::DeepL.GlossaryTargetLanguage?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DeepL.GlossaryEntriesFormat))
                {
                    return new global::DeepL.JsonConverters.GlossaryEntriesFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.GlossaryEntriesFormat?))
                {
                    return new global::DeepL.JsonConverters.GlossaryEntriesFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.GlossarySourceLanguage))
                {
                    return new global::DeepL.JsonConverters.GlossarySourceLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.GlossarySourceLanguage?))
                {
                    return new global::DeepL.JsonConverters.GlossarySourceLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.GlossaryTargetLanguage))
                {
                    return new global::DeepL.JsonConverters.GlossaryTargetLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.GlossaryTargetLanguage?))
                {
                    return new global::DeepL.JsonConverters.GlossaryTargetLanguageNullableJsonConverter();
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
                    0 => new ManageMultilingualGlossariesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}