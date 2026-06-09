
#nullable enable

namespace DeepL
{
    /// <summary>
    /// Nested counts keyed by `type`, then `sub_type`, then `severity`. Leaf values are integer counts.<br/>
    /// Example: {"Accuracy":{"Mistranslation":{"Critical":1,"Minor":1},"Omission":{"Major":1}}}
    /// </summary>
    public sealed partial class QualityEvaluationDoneSummaryGranularCounts
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}