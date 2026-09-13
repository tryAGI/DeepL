
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ApiKeyUsageLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminUsageReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminUsageReportData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.UsageBreakdown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminUsageReportDataGroupBy), TypeInfoPropertyName = "AdminUsageReportDataGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.KeyUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.KeyUsageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.KeyAndDayUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.KeyAndDayUsageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CustomTagUsageReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CustomTagUsageReportData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CustomTagUsageReportDataAggregateBy), TypeInfoPropertyName = "CustomTagUsageReportDataAggregateBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.CustomTagUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CustomTagUsageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CustomTagBreakdown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.InfrastructureErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.InfrastructureErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminCreateDeveloperKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminDeactivateDeveloperKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminRenameDeveloperKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminSetDeveloperKeyUsageLimitsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminGetAnalyticsGroupBy), TypeInfoPropertyName = "AdminGetAnalyticsGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminGetCustomTagAnalyticsAggregateBy), TypeInfoPropertyName = "AdminGetCustomTagAnalyticsAggregateBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminGetAnalyticsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.OneOf<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>), TypeInfoPropertyName = "OneOfErrorResponseInfrastructureErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminGetCustomTagAnalyticsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.ApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminUsageReportDataGroupBy?), TypeInfoPropertyName = "NullableAdminUsageReportDataGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CustomTagUsageReportDataAggregateBy?), TypeInfoPropertyName = "NullableCustomTagUsageReportDataAggregateBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminGetAnalyticsGroupBy?), TypeInfoPropertyName = "NullableAdminGetAnalyticsGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AdminGetCustomTagAnalyticsAggregateBy?), TypeInfoPropertyName = "NullableAdminGetCustomTagAnalyticsAggregateBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.OneOf<global::DeepL.ErrorResponse, global::DeepL.InfrastructureErrorResponse>?), TypeInfoPropertyName = "NullableOneOfErrorResponseInfrastructureErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.KeyUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.KeyAndDayUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.CustomTagUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.ApiKey>))]
    internal sealed partial class AdminApiSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminApiSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AdminApiSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AdminApiSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::DeepL.AdminUsageReportDataGroupBy)

                    || typeToConvert == typeof(global::DeepL.AdminUsageReportDataGroupBy?)

                    || typeToConvert == typeof(global::DeepL.CustomTagUsageReportDataAggregateBy)

                    || typeToConvert == typeof(global::DeepL.CustomTagUsageReportDataAggregateBy?)

                    || typeToConvert == typeof(global::DeepL.AdminGetAnalyticsGroupBy)

                    || typeToConvert == typeof(global::DeepL.AdminGetAnalyticsGroupBy?)

                    || typeToConvert == typeof(global::DeepL.AdminGetCustomTagAnalyticsAggregateBy)

                    || typeToConvert == typeof(global::DeepL.AdminGetCustomTagAnalyticsAggregateBy?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DeepL.AdminUsageReportDataGroupBy))
                {
                    return new global::DeepL.JsonConverters.AdminUsageReportDataGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.AdminUsageReportDataGroupBy?))
                {
                    return new global::DeepL.JsonConverters.AdminUsageReportDataGroupByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.CustomTagUsageReportDataAggregateBy))
                {
                    return new global::DeepL.JsonConverters.CustomTagUsageReportDataAggregateByJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.CustomTagUsageReportDataAggregateBy?))
                {
                    return new global::DeepL.JsonConverters.CustomTagUsageReportDataAggregateByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.AdminGetAnalyticsGroupBy))
                {
                    return new global::DeepL.JsonConverters.AdminGetAnalyticsGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.AdminGetAnalyticsGroupBy?))
                {
                    return new global::DeepL.JsonConverters.AdminGetAnalyticsGroupByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.AdminGetCustomTagAnalyticsAggregateBy))
                {
                    return new global::DeepL.JsonConverters.AdminGetCustomTagAnalyticsAggregateByJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.AdminGetCustomTagAnalyticsAggregateBy?))
                {
                    return new global::DeepL.JsonConverters.AdminGetCustomTagAnalyticsAggregateByNullableJsonConverter();
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
                    0 => new AdminApiSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}