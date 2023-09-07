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

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class AvailableLabServicesSkuRestrictions : IUtf8JsonSerializable, IModelJsonSerializable<AvailableLabServicesSkuRestrictions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AvailableLabServicesSkuRestrictions>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AvailableLabServicesSkuRestrictions>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvailableLabServicesSkuRestrictions>(this, options.Format);

            writer.WriteStartObject();
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

        internal static AvailableLabServicesSkuRestrictions DeserializeAvailableLabServicesSkuRestrictions(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LabServicesSkuRestrictionType> type = default;
            Optional<IReadOnlyList<string>> values = default;
            Optional<LabServicesSkuRestrictionReasonCode> reasonCode = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new LabServicesSkuRestrictionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("values"u8))
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
                    values = array;
                    continue;
                }
                if (property.NameEquals("reasonCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reasonCode = new LabServicesSkuRestrictionReasonCode(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AvailableLabServicesSkuRestrictions(Optional.ToNullable(type), Optional.ToList(values), Optional.ToNullable(reasonCode), serializedAdditionalRawData);
        }

        AvailableLabServicesSkuRestrictions IModelJsonSerializable<AvailableLabServicesSkuRestrictions>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvailableLabServicesSkuRestrictions>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailableLabServicesSkuRestrictions(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AvailableLabServicesSkuRestrictions>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvailableLabServicesSkuRestrictions>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AvailableLabServicesSkuRestrictions IModelSerializable<AvailableLabServicesSkuRestrictions>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvailableLabServicesSkuRestrictions>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAvailableLabServicesSkuRestrictions(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AvailableLabServicesSkuRestrictions"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AvailableLabServicesSkuRestrictions"/> to convert. </param>
        public static implicit operator RequestContent(AvailableLabServicesSkuRestrictions model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AvailableLabServicesSkuRestrictions"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AvailableLabServicesSkuRestrictions(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAvailableLabServicesSkuRestrictions(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
