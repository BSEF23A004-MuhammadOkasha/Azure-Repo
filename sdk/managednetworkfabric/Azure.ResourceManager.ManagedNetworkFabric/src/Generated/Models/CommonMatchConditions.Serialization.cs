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
    public partial class CommonMatchConditions : IUtf8JsonSerializable, IModelJsonSerializable<CommonMatchConditions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CommonMatchConditions>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CommonMatchConditions>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CommonMatchConditions>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ProtocolTypes))
            {
                writer.WritePropertyName("protocolTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ProtocolTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VlanMatchCondition))
            {
                writer.WritePropertyName("vlanMatchCondition"u8);
                if (VlanMatchCondition is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<VlanMatchCondition>)VlanMatchCondition).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(IPCondition))
            {
                writer.WritePropertyName("ipCondition"u8);
                if (IPCondition is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<IPMatchCondition>)IPCondition).Serialize(writer, options);
                }
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

        internal static CommonMatchConditions DeserializeCommonMatchConditions(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> protocolTypes = default;
            Optional<VlanMatchCondition> vlanMatchCondition = default;
            Optional<IPMatchCondition> ipCondition = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protocolTypes"u8))
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
                    protocolTypes = array;
                    continue;
                }
                if (property.NameEquals("vlanMatchCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vlanMatchCondition = VlanMatchCondition.DeserializeVlanMatchCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("ipCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipCondition = IPMatchCondition.DeserializeIPMatchCondition(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CommonMatchConditions(Optional.ToList(protocolTypes), vlanMatchCondition.Value, ipCondition.Value, serializedAdditionalRawData);
        }

        CommonMatchConditions IModelJsonSerializable<CommonMatchConditions>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CommonMatchConditions>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCommonMatchConditions(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CommonMatchConditions>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CommonMatchConditions>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CommonMatchConditions IModelSerializable<CommonMatchConditions>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CommonMatchConditions>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCommonMatchConditions(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CommonMatchConditions"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CommonMatchConditions"/> to convert. </param>
        public static implicit operator RequestContent(CommonMatchConditions model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CommonMatchConditions"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CommonMatchConditions(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCommonMatchConditions(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
