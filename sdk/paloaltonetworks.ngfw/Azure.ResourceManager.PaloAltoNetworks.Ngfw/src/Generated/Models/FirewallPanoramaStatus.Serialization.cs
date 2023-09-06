// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class FirewallPanoramaStatus : IUtf8JsonSerializable, IModelJsonSerializable<FirewallPanoramaStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FirewallPanoramaStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FirewallPanoramaStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FirewallPanoramaStatus>(this, options.Format);

            writer.WriteStartObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static FirewallPanoramaStatus DeserializeFirewallPanoramaStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<FirewallPanoramaServerStatus> panoramaServerStatus = default;
            Optional<FirewallPanoramaServerStatus> panoramaServer2Status = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("panoramaServerStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    panoramaServerStatus = new FirewallPanoramaServerStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("panoramaServer2Status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    panoramaServer2Status = new FirewallPanoramaServerStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FirewallPanoramaStatus(Optional.ToNullable(panoramaServerStatus), Optional.ToNullable(panoramaServer2Status), rawData);
        }

        FirewallPanoramaStatus IModelJsonSerializable<FirewallPanoramaStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FirewallPanoramaStatus>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallPanoramaStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FirewallPanoramaStatus>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FirewallPanoramaStatus>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FirewallPanoramaStatus IModelSerializable<FirewallPanoramaStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FirewallPanoramaStatus>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFirewallPanoramaStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FirewallPanoramaStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FirewallPanoramaStatus"/> to convert. </param>
        public static implicit operator RequestContent(FirewallPanoramaStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FirewallPanoramaStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FirewallPanoramaStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFirewallPanoramaStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
