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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ComputeResourceSkuZoneDetails : IUtf8JsonSerializable, IModelJsonSerializable<ComputeResourceSkuZoneDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ComputeResourceSkuZoneDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ComputeResourceSkuZoneDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

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

        internal static ComputeResourceSkuZoneDetails DeserializeComputeResourceSkuZoneDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<string>> name = default;
            Optional<IReadOnlyList<ComputeResourceSkuCapabilities>> capabilities = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
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
                    name = array;
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComputeResourceSkuCapabilities> array = new List<ComputeResourceSkuCapabilities>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComputeResourceSkuCapabilities.DeserializeComputeResourceSkuCapabilities(item));
                    }
                    capabilities = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ComputeResourceSkuZoneDetails(Optional.ToList(name), Optional.ToList(capabilities), serializedAdditionalRawData);
        }

        ComputeResourceSkuZoneDetails IModelJsonSerializable<ComputeResourceSkuZoneDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeResourceSkuZoneDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ComputeResourceSkuZoneDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ComputeResourceSkuZoneDetails IModelSerializable<ComputeResourceSkuZoneDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeComputeResourceSkuZoneDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ComputeResourceSkuZoneDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ComputeResourceSkuZoneDetails"/> to convert. </param>
        public static implicit operator RequestContent(ComputeResourceSkuZoneDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ComputeResourceSkuZoneDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ComputeResourceSkuZoneDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeComputeResourceSkuZoneDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
