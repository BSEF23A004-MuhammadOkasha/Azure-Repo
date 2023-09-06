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

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightBillingSpecsListResult : IUtf8JsonSerializable, IModelJsonSerializable<HDInsightBillingSpecsListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HDInsightBillingSpecsListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HDInsightBillingSpecsListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightBillingSpecsListResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(VmSizes))
            {
                writer.WritePropertyName("vmSizes"u8);
                writer.WriteStartArray();
                foreach (var item in VmSizes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VmSizesWithEncryptionAtHost))
            {
                writer.WritePropertyName("vmSizesWithEncryptionAtHost"u8);
                writer.WriteStartArray();
                foreach (var item in VmSizesWithEncryptionAtHost)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VmSizeFilters))
            {
                writer.WritePropertyName("vmSizeFilters"u8);
                writer.WriteStartArray();
                foreach (var item in VmSizeFilters)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<HDInsightVmSizeCompatibilityFilterV2>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BillingResources))
            {
                writer.WritePropertyName("billingResources"u8);
                writer.WriteStartArray();
                foreach (var item in BillingResources)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<HDInsightBillingResources>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static HDInsightBillingSpecsListResult DeserializeHDInsightBillingSpecsListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<string>> vmSizes = default;
            Optional<IReadOnlyList<string>> vmSizesWithEncryptionAtHost = default;
            Optional<IReadOnlyList<HDInsightVmSizeCompatibilityFilterV2>> vmSizeFilters = default;
            Optional<IReadOnlyList<HDInsightVmSizeProperty>> vmSizeProperties = default;
            Optional<IReadOnlyList<HDInsightBillingResources>> billingResources = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSizes"u8))
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
                    vmSizes = array;
                    continue;
                }
                if (property.NameEquals("vmSizesWithEncryptionAtHost"u8))
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
                    vmSizesWithEncryptionAtHost = array;
                    continue;
                }
                if (property.NameEquals("vmSizeFilters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightVmSizeCompatibilityFilterV2> array = new List<HDInsightVmSizeCompatibilityFilterV2>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightVmSizeCompatibilityFilterV2.DeserializeHDInsightVmSizeCompatibilityFilterV2(item));
                    }
                    vmSizeFilters = array;
                    continue;
                }
                if (property.NameEquals("vmSizeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightVmSizeProperty> array = new List<HDInsightVmSizeProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightVmSizeProperty.DeserializeHDInsightVmSizeProperty(item));
                    }
                    vmSizeProperties = array;
                    continue;
                }
                if (property.NameEquals("billingResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightBillingResources> array = new List<HDInsightBillingResources>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightBillingResources.DeserializeHDInsightBillingResources(item));
                    }
                    billingResources = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HDInsightBillingSpecsListResult(Optional.ToList(vmSizes), Optional.ToList(vmSizesWithEncryptionAtHost), Optional.ToList(vmSizeFilters), Optional.ToList(vmSizeProperties), Optional.ToList(billingResources), rawData);
        }

        HDInsightBillingSpecsListResult IModelJsonSerializable<HDInsightBillingSpecsListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightBillingSpecsListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightBillingSpecsListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HDInsightBillingSpecsListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightBillingSpecsListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HDInsightBillingSpecsListResult IModelSerializable<HDInsightBillingSpecsListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightBillingSpecsListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHDInsightBillingSpecsListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HDInsightBillingSpecsListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HDInsightBillingSpecsListResult"/> to convert. </param>
        public static implicit operator RequestContent(HDInsightBillingSpecsListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HDInsightBillingSpecsListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HDInsightBillingSpecsListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHDInsightBillingSpecsListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
