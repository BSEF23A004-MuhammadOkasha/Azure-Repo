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

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkFabricPortCondition : IUtf8JsonSerializable, IModelJsonSerializable<NetworkFabricPortCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkFabricPortCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkFabricPortCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkFabricPortCondition>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PortType))
            {
                writer.WritePropertyName("portType"u8);
                writer.WriteStringValue(PortType.Value.ToString());
            }
            writer.WritePropertyName("layer4Protocol"u8);
            writer.WriteStringValue(Layer4Protocol.ToString());
            if (Optional.IsCollectionDefined(Ports))
            {
                writer.WritePropertyName("ports"u8);
                writer.WriteStartArray();
                foreach (var item in Ports)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PortGroupNames))
            {
                writer.WritePropertyName("portGroupNames"u8);
                writer.WriteStartArray();
                foreach (var item in PortGroupNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static NetworkFabricPortCondition DeserializeNetworkFabricPortCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NetworkFabricPortType> portType = default;
            Layer4Protocol layer4Protocol = default;
            Optional<IList<string>> ports = default;
            Optional<IList<string>> portGroupNames = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("portType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portType = new NetworkFabricPortType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("layer4Protocol"u8))
                {
                    layer4Protocol = new Layer4Protocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ports"u8))
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
                    ports = array;
                    continue;
                }
                if (property.NameEquals("portGroupNames"u8))
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
                    portGroupNames = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkFabricPortCondition(Optional.ToNullable(portType), layer4Protocol, Optional.ToList(ports), Optional.ToList(portGroupNames), serializedAdditionalRawData);
        }

        NetworkFabricPortCondition IModelJsonSerializable<NetworkFabricPortCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkFabricPortCondition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFabricPortCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkFabricPortCondition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkFabricPortCondition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkFabricPortCondition IModelSerializable<NetworkFabricPortCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkFabricPortCondition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkFabricPortCondition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetworkFabricPortCondition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetworkFabricPortCondition"/> to convert. </param>
        public static implicit operator RequestContent(NetworkFabricPortCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetworkFabricPortCondition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetworkFabricPortCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkFabricPortCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
