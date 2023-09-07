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
    public partial class AvailableLabServicesSku : IUtf8JsonSerializable, IModelJsonSerializable<AvailableLabServicesSku>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AvailableLabServicesSku>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AvailableLabServicesSku>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvailableLabServicesSku>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                if (Capacity is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AvailableLabServicesSkuCapacity>)Capacity).Serialize(writer, options);
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

        internal static AvailableLabServicesSku DeserializeAvailableLabServicesSku(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceType = default;
            Optional<string> name = default;
            Optional<AvailableLabServicesSkuTier> tier = default;
            Optional<string> size = default;
            Optional<string> family = default;
            Optional<AvailableLabServicesSkuCapacity> capacity = default;
            Optional<IReadOnlyList<AvailableLabServicesSkuCapability>> capabilities = default;
            Optional<IReadOnlyList<AzureLocation>> locations = default;
            Optional<IReadOnlyList<AvailableLabServicesSkuCost>> costs = default;
            Optional<IReadOnlyList<AvailableLabServicesSkuRestrictions>> restrictions = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tier = new AvailableLabServicesSkuTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("family"u8))
                {
                    family = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = AvailableLabServicesSkuCapacity.DeserializeAvailableLabServicesSkuCapacity(property.Value);
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvailableLabServicesSkuCapability> array = new List<AvailableLabServicesSkuCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableLabServicesSkuCapability.DeserializeAvailableLabServicesSkuCapability(item));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("costs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvailableLabServicesSkuCost> array = new List<AvailableLabServicesSkuCost>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableLabServicesSkuCost.DeserializeAvailableLabServicesSkuCost(item));
                    }
                    costs = array;
                    continue;
                }
                if (property.NameEquals("restrictions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvailableLabServicesSkuRestrictions> array = new List<AvailableLabServicesSkuRestrictions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableLabServicesSkuRestrictions.DeserializeAvailableLabServicesSkuRestrictions(item));
                    }
                    restrictions = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AvailableLabServicesSku(resourceType.Value, name.Value, Optional.ToNullable(tier), size.Value, family.Value, capacity.Value, Optional.ToList(capabilities), Optional.ToList(locations), Optional.ToList(costs), Optional.ToList(restrictions), serializedAdditionalRawData);
        }

        AvailableLabServicesSku IModelJsonSerializable<AvailableLabServicesSku>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvailableLabServicesSku>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailableLabServicesSku(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AvailableLabServicesSku>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvailableLabServicesSku>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AvailableLabServicesSku IModelSerializable<AvailableLabServicesSku>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AvailableLabServicesSku>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAvailableLabServicesSku(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AvailableLabServicesSku"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AvailableLabServicesSku"/> to convert. </param>
        public static implicit operator RequestContent(AvailableLabServicesSku model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AvailableLabServicesSku"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AvailableLabServicesSku(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAvailableLabServicesSku(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
