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
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    public partial class PacketCoreControlPlaneVersionData : IUtf8JsonSerializable, IModelJsonSerializable<PacketCoreControlPlaneVersionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PacketCoreControlPlaneVersionData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PacketCoreControlPlaneVersionData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PacketCoreControlPlaneVersionData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Platforms))
            {
                writer.WritePropertyName("platforms"u8);
                writer.WriteStartArray();
                foreach (var item in Platforms)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MobileNetworkPlatform>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        internal static PacketCoreControlPlaneVersionData DeserializePacketCoreControlPlaneVersionData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<MobileNetworkProvisioningState> provisioningState = default;
            Optional<IList<MobileNetworkPlatform>> platforms = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new MobileNetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("platforms"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MobileNetworkPlatform> array = new List<MobileNetworkPlatform>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MobileNetworkPlatform.DeserializeMobileNetworkPlatform(item));
                            }
                            platforms = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PacketCoreControlPlaneVersionData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), Optional.ToList(platforms), rawData);
        }

        PacketCoreControlPlaneVersionData IModelJsonSerializable<PacketCoreControlPlaneVersionData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PacketCoreControlPlaneVersionData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePacketCoreControlPlaneVersionData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PacketCoreControlPlaneVersionData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PacketCoreControlPlaneVersionData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PacketCoreControlPlaneVersionData IModelSerializable<PacketCoreControlPlaneVersionData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PacketCoreControlPlaneVersionData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePacketCoreControlPlaneVersionData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PacketCoreControlPlaneVersionData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PacketCoreControlPlaneVersionData"/> to convert. </param>
        public static implicit operator RequestContent(PacketCoreControlPlaneVersionData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PacketCoreControlPlaneVersionData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PacketCoreControlPlaneVersionData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePacketCoreControlPlaneVersionData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
