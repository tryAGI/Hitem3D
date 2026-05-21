
#nullable enable

namespace Hitem3D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BalanceEnvelopeVariant2Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalBalance")]
        public double? TotalBalance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceEnvelopeVariant2Data" /> class.
        /// </summary>
        /// <param name="totalBalance"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BalanceEnvelopeVariant2Data(
            double? totalBalance)
        {
            this.TotalBalance = totalBalance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceEnvelopeVariant2Data" /> class.
        /// </summary>
        public BalanceEnvelopeVariant2Data()
        {
        }

    }
}