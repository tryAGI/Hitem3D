
#nullable enable

namespace Hitem3D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessToken")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenType")]
        public string? TokenType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nonce")]
        public string? Nonce { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenData" /> class.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="tokenType"></param>
        /// <param name="nonce"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenData(
            string? accessToken,
            string? tokenType,
            string? nonce)
        {
            this.AccessToken = accessToken;
            this.TokenType = tokenType;
            this.Nonce = nonce;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenData" /> class.
        /// </summary>
        public TokenData()
        {
        }

    }
}