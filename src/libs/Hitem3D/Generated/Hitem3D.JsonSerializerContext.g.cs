
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Hitem3D
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Hitem3D.JsonConverters.TaskDataStateJsonConverter),

            typeof(global::Hitem3D.JsonConverters.TaskDataStateNullableJsonConverter),

            typeof(global::Hitem3D.JsonConverters.TokenEnvelopeJsonConverter),

            typeof(global::Hitem3D.JsonConverters.SubmitTaskEnvelopeJsonConverter),

            typeof(global::Hitem3D.JsonConverters.TaskEnvelopeJsonConverter),

            typeof(global::Hitem3D.JsonConverters.BalanceEnvelopeJsonConverter),

            typeof(global::Hitem3D.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hitem3D.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hitem3D.ApiEnvelope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hitem3D.TokenEnvelope), TypeInfoPropertyName = "TokenEnvelope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hitem3D.TokenEnvelopeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hitem3D.TokenData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hitem3D.SubmitTaskRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hitem3D.SubmitTaskEnvelope), TypeInfoPropertyName = "SubmitTaskEnvelope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hitem3D.SubmitTaskEnvelopeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hitem3D.SubmitTaskEnvelopeVariant2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hitem3D.TaskEnvelope), TypeInfoPropertyName = "TaskEnvelope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hitem3D.TaskEnvelopeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hitem3D.TaskData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hitem3D.TaskDataState), TypeInfoPropertyName = "TaskDataState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hitem3D.BalanceEnvelope), TypeInfoPropertyName = "BalanceEnvelope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hitem3D.BalanceEnvelopeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hitem3D.BalanceEnvelopeVariant2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hitem3D.GetTokenRequest))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}