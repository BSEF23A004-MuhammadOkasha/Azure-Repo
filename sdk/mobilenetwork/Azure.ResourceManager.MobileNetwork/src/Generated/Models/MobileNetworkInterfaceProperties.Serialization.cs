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

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkInterfaceProperties : IUtf8JsonSerializable, IModelJsonSerializable<MobileNetworkInterfaceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MobileNetworkInterfaceProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MobileNetworkInterfaceProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MobileNetworkInterfaceProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(IPv4Address))
            {
                writer.WritePropertyName("ipv4Address"u8);
                writer.WriteStringValue(IPv4Address);
            }
            if (Optional.IsDefined(IPv4Subnet))
            {
                writer.WritePropertyName("ipv4Subnet"u8);
                writer.WriteStringValue(IPv4Subnet);
            }
            if (Optional.IsDefined(IPv4Gateway))
            {
                writer.WritePropertyName("ipv4Gateway"u8);
                writer.WriteStringValue(IPv4Gateway);
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

        internal static MobileNetworkInterfaceProperties DeserializeMobileNetworkInterfaceProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> ipv4Address = default;
            Optional<string> ipv4Subnet = default;
            Optional<string> ipv4Gateway = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv4Address"u8))
                {
                    ipv4Address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv4Subnet"u8))
                {
                    ipv4Subnet = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv4Gateway"u8))
                {
                    ipv4Gateway = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MobileNetworkInterfaceProperties(name.Value, ipv4Address.Value, ipv4Subnet.Value, ipv4Gateway.Value, rawData);
        }

        MobileNetworkInterfaceProperties IModelJsonSerializable<MobileNetworkInterfaceProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MobileNetworkInterfaceProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkInterfaceProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MobileNetworkInterfaceProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MobileNetworkInterfaceProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MobileNetworkInterfaceProperties IModelSerializable<MobileNetworkInterfaceProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MobileNetworkInterfaceProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMobileNetworkInterfaceProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MobileNetworkInterfaceProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MobileNetworkInterfaceProperties"/> to convert. </param>
        public static implicit operator RequestContent(MobileNetworkInterfaceProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MobileNetworkInterfaceProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MobileNetworkInterfaceProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMobileNetworkInterfaceProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
