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

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class NetworkCloudNetworkInterface : IUtf8JsonSerializable, IModelJsonSerializable<NetworkCloudNetworkInterface>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkCloudNetworkInterface>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkCloudNetworkInterface>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkCloudNetworkInterface>(this, options.Format);

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

        internal static NetworkCloudNetworkInterface DeserializeNetworkCloudNetworkInterface(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> address = default;
            Optional<DeviceConnectionType> deviceConnectionType = default;
            Optional<string> model = default;
            Optional<long> physicalSlot = default;
            Optional<long> portCount = default;
            Optional<long> portSpeed = default;
            Optional<string> vendor = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceConnectionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceConnectionType = new DeviceConnectionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("physicalSlot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    physicalSlot = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("portCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("portSpeed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portSpeed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("vendor"u8))
                {
                    vendor = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkCloudNetworkInterface(address.Value, Optional.ToNullable(deviceConnectionType), model.Value, Optional.ToNullable(physicalSlot), Optional.ToNullable(portCount), Optional.ToNullable(portSpeed), vendor.Value, rawData);
        }

        NetworkCloudNetworkInterface IModelJsonSerializable<NetworkCloudNetworkInterface>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkCloudNetworkInterface>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudNetworkInterface(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkCloudNetworkInterface>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkCloudNetworkInterface>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkCloudNetworkInterface IModelSerializable<NetworkCloudNetworkInterface>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkCloudNetworkInterface>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkCloudNetworkInterface(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetworkCloudNetworkInterface"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetworkCloudNetworkInterface"/> to convert. </param>
        public static implicit operator RequestContent(NetworkCloudNetworkInterface model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetworkCloudNetworkInterface"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetworkCloudNetworkInterface(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkCloudNetworkInterface(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
