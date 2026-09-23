
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationProcessingStatus), TypeInfoPropertyName = "QualityEvaluationProcessingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationDoneStatus), TypeInfoPropertyName = "QualityEvaluationDoneStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationFailedStatus), TypeInfoPropertyName = "QualityEvaluationFailedStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationFailedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationAppliedGlossaryTermPair>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationAppliedGlossaryTermPair))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.QualityEvaluationSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationIssueType), TypeInfoPropertyName = "QualityEvaluationIssueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationIssueSubType), TypeInfoPropertyName = "QualityEvaluationIssueSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationIssueSeverity), TypeInfoPropertyName = "QualityEvaluationIssueSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationApiError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.OneOf<global::DeepL.QualityEvaluationDone, global::DeepL.QualityEvaluationFailed>), TypeInfoPropertyName = "OneOfQualityEvaluationDoneQualityEvaluationFailed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationProcessingStatus?), TypeInfoPropertyName = "NullableQualityEvaluationProcessingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationDoneStatus?), TypeInfoPropertyName = "NullableQualityEvaluationDoneStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationFailedStatus?), TypeInfoPropertyName = "NullableQualityEvaluationFailedStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationIssueType?), TypeInfoPropertyName = "NullableQualityEvaluationIssueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationIssueSubType?), TypeInfoPropertyName = "NullableQualityEvaluationIssueSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.QualityEvaluationIssueSeverity?), TypeInfoPropertyName = "NullableQualityEvaluationIssueSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.OneOf<global::DeepL.QualityEvaluationDone, global::DeepL.QualityEvaluationFailed>?), TypeInfoPropertyName = "NullableOneOfQualityEvaluationDoneQualityEvaluationFailed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.QualityEvaluationSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.QualityEvaluationAppliedGlossaryTermPair>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.QualityEvaluationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.QualityEvaluationSpan>))]
    internal sealed partial class QualityEvaluationSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualityEvaluationSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static QualityEvaluationSourceGenerationContext Default { get; } = new(DefaultOptions);

        private QualityEvaluationSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::DeepL.JsonConverters.OneOfJsonConverter<global::DeepL.QualityEvaluationDone, global::DeepL.QualityEvaluationFailed>());
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
                    typeToConvert == typeof(global::DeepL.QualityEvaluationProcessingStatus)

                    || typeToConvert == typeof(global::DeepL.QualityEvaluationProcessingStatus?)

                    || typeToConvert == typeof(global::DeepL.QualityEvaluationDoneStatus)

                    || typeToConvert == typeof(global::DeepL.QualityEvaluationDoneStatus?)

                    || typeToConvert == typeof(global::DeepL.QualityEvaluationFailedStatus)

                    || typeToConvert == typeof(global::DeepL.QualityEvaluationFailedStatus?)

                    || typeToConvert == typeof(global::DeepL.QualityEvaluationIssueType)

                    || typeToConvert == typeof(global::DeepL.QualityEvaluationIssueType?)

                    || typeToConvert == typeof(global::DeepL.QualityEvaluationIssueSubType)

                    || typeToConvert == typeof(global::DeepL.QualityEvaluationIssueSubType?)

                    || typeToConvert == typeof(global::DeepL.QualityEvaluationIssueSeverity)

                    || typeToConvert == typeof(global::DeepL.QualityEvaluationIssueSeverity?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DeepL.QualityEvaluationProcessingStatus))
                {
                    return new global::DeepL.JsonConverters.QualityEvaluationProcessingStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.QualityEvaluationProcessingStatus?))
                {
                    return new global::DeepL.JsonConverters.QualityEvaluationProcessingStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.QualityEvaluationDoneStatus))
                {
                    return new global::DeepL.JsonConverters.QualityEvaluationDoneStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.QualityEvaluationDoneStatus?))
                {
                    return new global::DeepL.JsonConverters.QualityEvaluationDoneStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.QualityEvaluationFailedStatus))
                {
                    return new global::DeepL.JsonConverters.QualityEvaluationFailedStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.QualityEvaluationFailedStatus?))
                {
                    return new global::DeepL.JsonConverters.QualityEvaluationFailedStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.QualityEvaluationIssueType))
                {
                    return new global::DeepL.JsonConverters.QualityEvaluationIssueTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.QualityEvaluationIssueType?))
                {
                    return new global::DeepL.JsonConverters.QualityEvaluationIssueTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.QualityEvaluationIssueSubType))
                {
                    return new global::DeepL.JsonConverters.QualityEvaluationIssueSubTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.QualityEvaluationIssueSubType?))
                {
                    return new global::DeepL.JsonConverters.QualityEvaluationIssueSubTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.QualityEvaluationIssueSeverity))
                {
                    return new global::DeepL.JsonConverters.QualityEvaluationIssueSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.QualityEvaluationIssueSeverity?))
                {
                    return new global::DeepL.JsonConverters.QualityEvaluationIssueSeverityNullableJsonConverter();
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
                    0 => new QualityEvaluationSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}