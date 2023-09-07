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
    public partial class AccessControlListMatchConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<AccessControlListMatchConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AccessControlListMatchConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AccessControlListMatchConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AccessControlListMatchConfiguration>(this, options.Format);

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
                        ((IModelJsonSerializable<AccessControlListMatchCondition>)item).Serialize(writer, options);
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
                        ((IModelJsonSerializable<AccessControlListAction>)item).Serialize(writer, options);
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

        internal static AccessControlListMatchConfiguration DeserializeAccessControlListMatchConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> matchConfigurationName = default;
            Optional<long> sequenceNumber = default;
            Optional<NetworkFabricIPAddressType> ipAddressType = default;
            Optional<IList<AccessControlListMatchCondition>> matchConditions = default;
            Optional<IList<AccessControlListAction>> actions = default;
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
                    List<AccessControlListMatchCondition> array = new List<AccessControlListMatchCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AccessControlListMatchCondition.DeserializeAccessControlListMatchCondition(item));
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
                    List<AccessControlListAction> array = new List<AccessControlListAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AccessControlListAction.DeserializeAccessControlListAction(item));
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
            return new AccessControlListMatchConfiguration(matchConfigurationName.Value, Optional.ToNullable(sequenceNumber), Optional.ToNullable(ipAddressType), Optional.ToList(matchConditions), Optional.ToList(actions), serializedAdditionalRawData);
        }

        AccessControlListMatchConfiguration IModelJsonSerializable<AccessControlListMatchConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AccessControlListMatchConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAccessControlListMatchConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AccessControlListMatchConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AccessControlListMatchConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AccessControlListMatchConfiguration IModelSerializable<AccessControlListMatchConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AccessControlListMatchConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAccessControlListMatchConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AccessControlListMatchConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AccessControlListMatchConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(AccessControlListMatchConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AccessControlListMatchConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AccessControlListMatchConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAccessControlListMatchConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
