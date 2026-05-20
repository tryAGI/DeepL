
#nullable enable

namespace DeepL
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobUsage
    {
        /// <summary>
        /// Total storage used by this job in bytes, including source and output files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_used")]
        public long? StorageUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobUsage" /> class.
        /// </summary>
        /// <param name="storageUsed">
        /// Total storage used by this job in bytes, including source and output files.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobUsage(
            long? storageUsed)
        {
            this.StorageUsed = storageUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobUsage" /> class.
        /// </summary>
        public JobUsage()
        {
        }

    }
}