
#nullable enable

namespace Hitem3D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitTaskEnvelopeVariant2Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitTaskEnvelopeVariant2Data" /> class.
        /// </summary>
        /// <param name="taskId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitTaskEnvelopeVariant2Data(
            string? taskId)
        {
            this.TaskId = taskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitTaskEnvelopeVariant2Data" /> class.
        /// </summary>
        public SubmitTaskEnvelopeVariant2Data()
        {
        }
    }
}