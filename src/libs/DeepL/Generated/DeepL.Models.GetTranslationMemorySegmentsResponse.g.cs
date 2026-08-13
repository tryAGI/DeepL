
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTranslationMemorySegmentsResponse
    {
        /// <summary>
        /// The segments on this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DeepL.TranslationMemorySegment> Segments { get; set; }

        /// <summary>
        /// The total number of segments in the translation memory. This is not reduced by<br/>
        /// `filter_text`, so a filtered request still reports the full count. Do not use it to<br/>
        /// predict how many results a filtered query returns.<br/>
        /// Example: 3542
        /// </summary>
        /// <example>3542</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SegmentCount { get; set; }

        /// <summary>
        /// The cursor to pass as `page_cursor` to retrieve the next page. Absent on the last page.<br/>
        /// Example: eyJvZmZzZXQiOjUwfQ
        /// </summary>
        /// <example>eyJvZmZzZXQiOjUwfQ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_cursor")]
        public string? NextPageCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranslationMemorySegmentsResponse" /> class.
        /// </summary>
        /// <param name="segments">
        /// The segments on this page.
        /// </param>
        /// <param name="segmentCount">
        /// The total number of segments in the translation memory. This is not reduced by<br/>
        /// `filter_text`, so a filtered request still reports the full count. Do not use it to<br/>
        /// predict how many results a filtered query returns.<br/>
        /// Example: 3542
        /// </param>
        /// <param name="nextPageCursor">
        /// The cursor to pass as `page_cursor` to retrieve the next page. Absent on the last page.<br/>
        /// Example: eyJvZmZzZXQiOjUwfQ
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTranslationMemorySegmentsResponse(
            global::System.Collections.Generic.IList<global::DeepL.TranslationMemorySegment> segments,
            int segmentCount,
            string? nextPageCursor)
        {
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
            this.SegmentCount = segmentCount;
            this.NextPageCursor = nextPageCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranslationMemorySegmentsResponse" /> class.
        /// </summary>
        public GetTranslationMemorySegmentsResponse()
        {
        }

    }
}