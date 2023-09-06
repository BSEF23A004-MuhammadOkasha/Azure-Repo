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
using Azure.ResourceManager.Grafana;

namespace Azure.ResourceManager.Grafana.Models
{
    public partial class ManagedGrafanaProperties : IUtf8JsonSerializable, IModelJsonSerializable<ManagedGrafanaProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedGrafanaProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedGrafanaProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedGrafanaProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
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
            if (Optional.IsDefined(AutoGeneratedDomainNameLabelScope))
            {
                writer.WritePropertyName("autoGeneratedDomainNameLabelScope"u8);
                writer.WriteStringValue(AutoGeneratedDomainNameLabelScope.Value.ToString());
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

        internal static ManagedGrafanaProperties DeserializeManagedGrafanaProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GrafanaProvisioningState> provisioningState = default;
            Optional<string> grafanaVersion = default;
            Optional<string> endpoint = default;
            Optional<GrafanaPublicNetworkAccess> publicNetworkAccess = default;
            Optional<GrafanaZoneRedundancy> zoneRedundancy = default;
            Optional<GrafanaApiKey> apiKey = default;
            Optional<DeterministicOutboundIP> deterministicOutboundIP = default;
            Optional<IReadOnlyList<string>> outboundIPs = default;
            Optional<IReadOnlyList<GrafanaPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<AutoGeneratedDomainNameLabelScope> autoGeneratedDomainNameLabelScope = default;
            Optional<GrafanaIntegrations> grafanaIntegrations = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new GrafanaProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("grafanaVersion"u8))
                {
                    grafanaVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = property.Value.GetString();
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
                if (property.NameEquals("outboundIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    outboundIPs = array;
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GrafanaPrivateEndpointConnectionData> array = new List<GrafanaPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GrafanaPrivateEndpointConnectionData.DeserializeGrafanaPrivateEndpointConnectionData(item));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("autoGeneratedDomainNameLabelScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoGeneratedDomainNameLabelScope = new AutoGeneratedDomainNameLabelScope(property.Value.GetString());
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
            return new ManagedGrafanaProperties(Optional.ToNullable(provisioningState), grafanaVersion.Value, endpoint.Value, Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(zoneRedundancy), Optional.ToNullable(apiKey), Optional.ToNullable(deterministicOutboundIP), Optional.ToList(outboundIPs), Optional.ToList(privateEndpointConnections), Optional.ToNullable(autoGeneratedDomainNameLabelScope), grafanaIntegrations.Value, rawData);
        }

        ManagedGrafanaProperties IModelJsonSerializable<ManagedGrafanaProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedGrafanaProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedGrafanaProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedGrafanaProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedGrafanaProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedGrafanaProperties IModelSerializable<ManagedGrafanaProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedGrafanaProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedGrafanaProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedGrafanaProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedGrafanaProperties"/> to convert. </param>
        public static implicit operator RequestContent(ManagedGrafanaProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedGrafanaProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedGrafanaProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedGrafanaProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
