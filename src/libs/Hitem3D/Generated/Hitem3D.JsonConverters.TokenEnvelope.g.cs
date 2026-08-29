#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Hitem3D.JsonConverters
{
    /// <inheritdoc />
    public class TokenEnvelopeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Hitem3D.TokenEnvelope>
    {
        /// <inheritdoc />
        public override global::Hitem3D.TokenEnvelope Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Hitem3D.ApiEnvelope? api = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hitem3D.ApiEnvelope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hitem3D.ApiEnvelope> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hitem3D.ApiEnvelope).Name}");
                api = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Hitem3D.TokenEnvelopeVariant2? tokenEnvelopeVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hitem3D.TokenEnvelopeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hitem3D.TokenEnvelopeVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hitem3D.TokenEnvelopeVariant2).Name}");
                tokenEnvelopeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Hitem3D.TokenEnvelope(
                api,

                tokenEnvelopeVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Hitem3D.TokenEnvelope value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsApi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hitem3D.ApiEnvelope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hitem3D.ApiEnvelope?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hitem3D.ApiEnvelope).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Api!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsTokenEnvelopeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hitem3D.TokenEnvelopeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hitem3D.TokenEnvelopeVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hitem3D.TokenEnvelopeVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.TokenEnvelopeVariant2!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}