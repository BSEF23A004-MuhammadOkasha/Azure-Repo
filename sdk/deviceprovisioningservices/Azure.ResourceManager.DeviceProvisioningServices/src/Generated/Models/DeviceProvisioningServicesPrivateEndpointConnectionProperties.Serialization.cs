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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    public partial class DeviceProvisioningServicesPrivateEndpointConnectionProperties : IUtf8JsonSerializable, IModelJsonSerializable<DeviceProvisioningServicesPrivateEndpointConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DeviceProvisioningServicesPrivateEndpointConnectionProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DeviceProvisioningServicesPrivateEndpointConnectionProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeviceProvisioningServicesPrivateEndpointConnectionProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateEndpoint))
            {
                writer.WritePropertyName("privateEndpoint"u8);
                JsonSerializer.Serialize(writer, PrivateEndpoint);
            }
            writer.WritePropertyName("privateLinkServiceConnectionState"u8);
            if (ConnectionState is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<DeviceProvisioningServicesPrivateLinkServiceConnectionState>)ConnectionState).Serialize(writer, options);
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

        internal static DeviceProvisioningServicesPrivateEndpointConnectionProperties DeserializeDeviceProvisioningServicesPrivateEndpointConnectionProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SubResource> privateEndpoint = default;
            DeviceProvisioningServicesPrivateLinkServiceConnectionState privateLinkServiceConnectionState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpoint = JsonSerializer.Deserialize<SubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("privateLinkServiceConnectionState"u8))
                {
                    privateLinkServiceConnectionState = DeviceProvisioningServicesPrivateLinkServiceConnectionState.DeserializeDeviceProvisioningServicesPrivateLinkServiceConnectionState(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DeviceProvisioningServicesPrivateEndpointConnectionProperties(privateEndpoint, privateLinkServiceConnectionState, rawData);
        }

        DeviceProvisioningServicesPrivateEndpointConnectionProperties IModelJsonSerializable<DeviceProvisioningServicesPrivateEndpointConnectionProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeviceProvisioningServicesPrivateEndpointConnectionProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceProvisioningServicesPrivateEndpointConnectionProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DeviceProvisioningServicesPrivateEndpointConnectionProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeviceProvisioningServicesPrivateEndpointConnectionProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DeviceProvisioningServicesPrivateEndpointConnectionProperties IModelSerializable<DeviceProvisioningServicesPrivateEndpointConnectionProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeviceProvisioningServicesPrivateEndpointConnectionProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDeviceProvisioningServicesPrivateEndpointConnectionProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DeviceProvisioningServicesPrivateEndpointConnectionProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DeviceProvisioningServicesPrivateEndpointConnectionProperties"/> to convert. </param>
        public static implicit operator RequestContent(DeviceProvisioningServicesPrivateEndpointConnectionProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DeviceProvisioningServicesPrivateEndpointConnectionProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DeviceProvisioningServicesPrivateEndpointConnectionProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDeviceProvisioningServicesPrivateEndpointConnectionProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
