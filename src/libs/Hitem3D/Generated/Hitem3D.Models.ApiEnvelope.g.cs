
#nullable enable

namespace Hitem3D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiEnvelope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public int? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string? Msg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiEnvelope" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="msg"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiEnvelope(
            int? code,
            string? msg,
            string? message)
        {
            this.Code = code;
            this.Msg = msg;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiEnvelope" /> class.
        /// </summary>
        public ApiEnvelope()
        {
        }

    }
}