// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ComputeSkuProfile : IUtf8JsonSerializable, IJsonModel<ComputeSkuProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeSkuProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ComputeSkuProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeSkuProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeSkuProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(VmSizes))
            {
                writer.WritePropertyName("vmSizes"u8);
                writer.WriteStartArray();
                foreach (var item in VmSizes)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllocationStrategy))
            {
                writer.WritePropertyName("allocationStrategy"u8);
                writer.WriteStringValue(AllocationStrategy.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ComputeSkuProfile IJsonModel<ComputeSkuProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeSkuProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeSkuProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeSkuProfile(document.RootElement, options);
        }

        internal static ComputeSkuProfile DeserializeComputeSkuProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ComputeSkuProfileVmSize> vmSizes = default;
            ComputeAllocationStrategy? allocationStrategy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSizes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComputeSkuProfileVmSize> array = new List<ComputeSkuProfileVmSize>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComputeSkuProfileVmSize.DeserializeComputeSkuProfileVmSize(item, options));
                    }
                    vmSizes = array;
                    continue;
                }
                if (property.NameEquals("allocationStrategy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationStrategy = new ComputeAllocationStrategy(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ComputeSkuProfile(vmSizes ?? new ChangeTrackingList<ComputeSkuProfileVmSize>(), allocationStrategy, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputeSkuProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeSkuProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputeSkuProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ComputeSkuProfile IPersistableModel<ComputeSkuProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeSkuProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComputeSkuProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputeSkuProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeSkuProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
