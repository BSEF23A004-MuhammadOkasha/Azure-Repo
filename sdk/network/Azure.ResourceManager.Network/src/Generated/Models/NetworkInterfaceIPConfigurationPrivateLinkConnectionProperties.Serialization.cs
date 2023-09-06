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

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties : IUtf8JsonSerializable, IModelJsonSerializable<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties>(this, options.Format);

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

        internal static NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties DeserializeNetworkInterfaceIPConfigurationPrivateLinkConnectionProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> groupId = default;
            Optional<string> requiredMemberName = default;
            Optional<IReadOnlyList<string>> fqdns = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requiredMemberName"u8))
                {
                    requiredMemberName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fqdns"u8))
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
                    fqdns = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties(groupId.Value, requiredMemberName.Value, Optional.ToList(fqdns), rawData);
        }

        NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties IModelJsonSerializable<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkInterfaceIPConfigurationPrivateLinkConnectionProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties IModelSerializable<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkInterfaceIPConfigurationPrivateLinkConnectionProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties"/> to convert. </param>
        public static implicit operator RequestContent(NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkInterfaceIPConfigurationPrivateLinkConnectionProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
