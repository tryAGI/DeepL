
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTranslateJobSourceContentType), TypeInfoPropertyName = "VoiceTranslateJobSourceContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.JobSourceFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.JobSourceFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTranslateJobTargetOutputType), TypeInfoPropertyName = "VoiceTranslateJobTargetOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTranslateJobParametersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AllOf<string, object>), TypeInfoPropertyName = "AllOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTranslateJobParametersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTranslateJobTargetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTranslateJobTargetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTranslateCreateJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.VoiceTranslateJobTargetRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTranslateCreateJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.JobUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ResultStatus), TypeInfoPropertyName = "ResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTranslateJobTargetResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTranslateJobStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.VoiceTranslateJobTargetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.VoiceTranslateJobTargetResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.CreateVoiceTranslateJobIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CreateVoiceTranslateJobIncludeItem), TypeInfoPropertyName = "CreateVoiceTranslateJobIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DeepL.GetVoiceTranslateJobStatusIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GetVoiceTranslateJobStatusIncludeItem), TypeInfoPropertyName = "GetVoiceTranslateJobStatusIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTranslateJobSourceContentType?), TypeInfoPropertyName = "NullableVoiceTranslateJobSourceContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.VoiceTranslateJobTargetOutputType?), TypeInfoPropertyName = "NullableVoiceTranslateJobTargetOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.AllOf<string, object>?), TypeInfoPropertyName = "NullableAllOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.ResultStatus?), TypeInfoPropertyName = "NullableResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.CreateVoiceTranslateJobIncludeItem?), TypeInfoPropertyName = "NullableCreateVoiceTranslateJobIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DeepL.GetVoiceTranslateJobStatusIncludeItem?), TypeInfoPropertyName = "NullableGetVoiceTranslateJobStatusIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.VoiceTranslateJobTargetRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.VoiceTranslateJobTargetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.VoiceTranslateJobTargetResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.CreateVoiceTranslateJobIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DeepL.GetVoiceTranslateJobStatusIncludeItem>))]
    internal sealed partial class VoiceTranslateJobSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceTranslateJobSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VoiceTranslateJobSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VoiceTranslateJobSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::DeepL.VoiceTranslateJobSourceContentType)

                    || typeToConvert == typeof(global::DeepL.VoiceTranslateJobSourceContentType?)

                    || typeToConvert == typeof(global::DeepL.VoiceTranslateJobTargetOutputType)

                    || typeToConvert == typeof(global::DeepL.VoiceTranslateJobTargetOutputType?)

                    || typeToConvert == typeof(global::DeepL.ResultStatus)

                    || typeToConvert == typeof(global::DeepL.ResultStatus?)

                    || typeToConvert == typeof(global::DeepL.CreateVoiceTranslateJobIncludeItem)

                    || typeToConvert == typeof(global::DeepL.CreateVoiceTranslateJobIncludeItem?)

                    || typeToConvert == typeof(global::DeepL.GetVoiceTranslateJobStatusIncludeItem)

                    || typeToConvert == typeof(global::DeepL.GetVoiceTranslateJobStatusIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::DeepL.VoiceTranslateJobSourceContentType))
                {
                    return new global::DeepL.JsonConverters.VoiceTranslateJobSourceContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceTranslateJobSourceContentType?))
                {
                    return new global::DeepL.JsonConverters.VoiceTranslateJobSourceContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceTranslateJobTargetOutputType))
                {
                    return new global::DeepL.JsonConverters.VoiceTranslateJobTargetOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.VoiceTranslateJobTargetOutputType?))
                {
                    return new global::DeepL.JsonConverters.VoiceTranslateJobTargetOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.ResultStatus))
                {
                    return new global::DeepL.JsonConverters.ResultStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.ResultStatus?))
                {
                    return new global::DeepL.JsonConverters.ResultStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.CreateVoiceTranslateJobIncludeItem))
                {
                    return new global::DeepL.JsonConverters.CreateVoiceTranslateJobIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.CreateVoiceTranslateJobIncludeItem?))
                {
                    return new global::DeepL.JsonConverters.CreateVoiceTranslateJobIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.GetVoiceTranslateJobStatusIncludeItem))
                {
                    return new global::DeepL.JsonConverters.GetVoiceTranslateJobStatusIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::DeepL.GetVoiceTranslateJobStatusIncludeItem?))
                {
                    return new global::DeepL.JsonConverters.GetVoiceTranslateJobStatusIncludeItemNullableJsonConverter();
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
                    0 => new VoiceTranslateJobSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}