// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Consumption;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionUsageProperties : IUtf8JsonSerializable, IJsonModel<ConsumptionUsageProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionUsageProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConsumptionUsageProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionUsageProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionUsageProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && FirstConsumptionDate != null)
            {
                writer.WritePropertyName("firstConsumptionDate"u8);
                writer.WriteStringValue(FirstConsumptionDate);
            }
            if (options.Format != "W" && LastConsumptionDate != null)
            {
                writer.WritePropertyName("lastConsumptionDate"u8);
                writer.WriteStringValue(LastConsumptionDate);
            }
            if (options.Format != "W" && LookBackUnitType != null)
            {
                writer.WritePropertyName("lookBackUnitType"u8);
                writer.WriteStringValue(LookBackUnitType);
            }
            if (options.Format != "W" && !(UsageData is ChangeTrackingList<float> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("usageData"u8);
                writer.WriteStartArray();
                foreach (var item in UsageData)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && UsageGrain != null)
            {
                writer.WritePropertyName("usageGrain"u8);
                writer.WriteStringValue(UsageGrain);
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
            writer.WriteEndObject();
        }

        ConsumptionUsageProperties IJsonModel<ConsumptionUsageProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionUsageProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionUsageProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionUsageProperties(document.RootElement, options);
        }

        internal static ConsumptionUsageProperties DeserializeConsumptionUsageProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string firstConsumptionDate = default;
            string lastConsumptionDate = default;
            string lookBackUnitType = default;
            IReadOnlyList<float> usageData = default;
            string usageGrain = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstConsumptionDate"u8))
                {
                    firstConsumptionDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastConsumptionDate"u8))
                {
                    lastConsumptionDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lookBackUnitType"u8))
                {
                    lookBackUnitType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("usageData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    usageData = array;
                    continue;
                }
                if (property.NameEquals("usageGrain"u8))
                {
                    usageGrain = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConsumptionUsageProperties(
                firstConsumptionDate,
                lastConsumptionDate,
                lookBackUnitType,
                usageData ?? new ChangeTrackingList<float>(),
                usageGrain,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConsumptionUsageProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionUsageProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionUsageProperties)} does not support '{options.Format}' format.");
            }
        }

        ConsumptionUsageProperties IPersistableModel<ConsumptionUsageProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionUsageProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsumptionUsageProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConsumptionUsageProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionUsageProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
