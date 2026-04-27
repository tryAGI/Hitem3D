
#nullable enable

namespace Hitem3D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hitem3D.JsonConverters.TaskDataStateJsonConverter))]
        public global::Hitem3D.TaskDataState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_url")]
        public string? CoverUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskData" /> class.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="state"></param>
        /// <param name="id"></param>
        /// <param name="coverUrl"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskData(
            string? taskId,
            global::Hitem3D.TaskDataState? state,
            string? id,
            string? coverUrl,
            string? url)
        {
            this.TaskId = taskId;
            this.State = state;
            this.Id = id;
            this.CoverUrl = coverUrl;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskData" /> class.
        /// </summary>
        public TaskData()
        {
        }
    }
}