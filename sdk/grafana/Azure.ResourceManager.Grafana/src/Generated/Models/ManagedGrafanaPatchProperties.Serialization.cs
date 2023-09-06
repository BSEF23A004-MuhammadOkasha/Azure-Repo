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

namespace Azure.ResourceManager.Grafana.Models
{
    public partial class ManagedGrafanaPatchProperties : IUtf8JsonSerializable, IModelJsonSerializable<ManagedGrafanaPatchProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedGrafanaPatchProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedGrafanaPatchProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedGrafanaPatchProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ZoneRedundancy))
            {
                writer.WritePropertyName("zoneRedundancy"u8);
                writer.WriteStringValue(ZoneRedundancy.Value.ToString());
            }
            if (Optional.IsDefined(ApiKey))
            {
                writer.WritePropertyName("apiKey"u8);
                writer.WriteStringValue(ApiKey.Value.ToString());
            }
            if (Optional.IsDefined(DeterministicOutboundIP))
            {
                writer.WritePropertyName("deterministicOutboundIP"u8);
                writer.WriteStringValue(DeterministicOutboundIP.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(GrafanaIntegrations))
            {
                writer.WritePropertyName("grafanaIntegrations"u8);
                if (GrafanaIntegrations is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<GrafanaIntegrations>)GrafanaIntegrations).Serialize(writer, options);
                }
            }
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

        internal static ManagedGrafanaPatchProperties DeserializeManagedGrafanaPatchProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GrafanaZoneRedundancy> zoneRedundancy = default;
            Optional<GrafanaApiKey> apiKey = default;
            Optional<DeterministicOutboundIP> deterministicOutboundIP = default;
            Optional<GrafanaPublicNetworkAccess> publicNetworkAccess = default;
            Optional<GrafanaIntegrations> grafanaIntegrations = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zoneRedundancy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneRedundancy = new GrafanaZoneRedundancy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("apiKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apiKey = new GrafanaApiKey(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deterministicOutboundIP"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deterministicOutboundIP = new DeterministicOutboundIP(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new GrafanaPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("grafanaIntegrations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    grafanaIntegrations = GrafanaIntegrations.DeserializeGrafanaIntegrations(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedGrafanaPatchProperties(Optional.ToNullable(zoneRedundancy), Optional.ToNullable(apiKey), Optional.ToNullable(deterministicOutboundIP), Optional.ToNullable(publicNetworkAccess), grafanaIntegrations.Value, rawData);
        }

        ManagedGrafanaPatchProperties IModelJsonSerializable<ManagedGrafanaPatchProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedGrafanaPatchProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedGrafanaPatchProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedGrafanaPatchProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedGrafanaPatchProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedGrafanaPatchProperties IModelSerializable<ManagedGrafanaPatchProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedGrafanaPatchProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedGrafanaPatchProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedGrafanaPatchProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedGrafanaPatchProperties"/> to convert. </param>
        public static implicit operator RequestContent(ManagedGrafanaPatchProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedGrafanaPatchProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedGrafanaPatchProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedGrafanaPatchProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
