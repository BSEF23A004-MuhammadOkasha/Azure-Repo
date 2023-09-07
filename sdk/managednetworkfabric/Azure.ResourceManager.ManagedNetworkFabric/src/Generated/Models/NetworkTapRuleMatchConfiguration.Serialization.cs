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
    public partial class NetworkTapRuleMatchConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<NetworkTapRuleMatchConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkTapRuleMatchConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkTapRuleMatchConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkTapRuleMatchConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MatchConfigurationName))
            {
                writer.WritePropertyName("matchConfigurationName"u8);
                writer.WriteStringValue(MatchConfigurationName);
            }
            if (Optional.IsDefined(SequenceNumber))
            {
                writer.WritePropertyName("sequenceNumber"u8);
                writer.WriteNumberValue(SequenceNumber.Value);
            }
            if (Optional.IsDefined(IPAddressType))
            {
                writer.WritePropertyName("ipAddressType"u8);
                writer.WriteStringValue(IPAddressType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(MatchConditions))
            {
                writer.WritePropertyName("matchConditions"u8);
                writer.WriteStartArray();
                foreach (var item in MatchConditions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<NetworkTapRuleMatchCondition>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Actions))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<NetworkTapRuleAction>)item).Serialize(writer, options);
                    }
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

        internal static NetworkTapRuleMatchConfiguration DeserializeNetworkTapRuleMatchConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> matchConfigurationName = default;
            Optional<long> sequenceNumber = default;
            Optional<NetworkFabricIPAddressType> ipAddressType = default;
            Optional<IList<NetworkTapRuleMatchCondition>> matchConditions = default;
            Optional<IList<NetworkTapRuleAction>> actions = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("matchConfigurationName"u8))
                {
                    matchConfigurationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sequenceNumber = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("ipAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddressType = new NetworkFabricIPAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("matchConditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkTapRuleMatchCondition> array = new List<NetworkTapRuleMatchCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkTapRuleMatchCondition.DeserializeNetworkTapRuleMatchCondition(item));
                    }
                    matchConditions = array;
                    continue;
                }
                if (property.NameEquals("actions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkTapRuleAction> array = new List<NetworkTapRuleAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkTapRuleAction.DeserializeNetworkTapRuleAction(item));
                    }
                    actions = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkTapRuleMatchConfiguration(matchConfigurationName.Value, Optional.ToNullable(sequenceNumber), Optional.ToNullable(ipAddressType), Optional.ToList(matchConditions), Optional.ToList(actions), serializedAdditionalRawData);
        }

        NetworkTapRuleMatchConfiguration IModelJsonSerializable<NetworkTapRuleMatchConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkTapRuleMatchConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkTapRuleMatchConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkTapRuleMatchConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkTapRuleMatchConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkTapRuleMatchConfiguration IModelSerializable<NetworkTapRuleMatchConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkTapRuleMatchConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkTapRuleMatchConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetworkTapRuleMatchConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetworkTapRuleMatchConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(NetworkTapRuleMatchConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetworkTapRuleMatchConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetworkTapRuleMatchConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkTapRuleMatchConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
