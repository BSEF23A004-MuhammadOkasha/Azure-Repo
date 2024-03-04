// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.OperationalInsights;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsCapacityReservationProperties : IUtf8JsonSerializable, IJsonModel<OperationalInsightsCapacityReservationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalInsightsCapacityReservationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OperationalInsightsCapacityReservationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsCapacityReservationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsCapacityReservationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(LastSkuUpdatedOn))
            {
                writer.WritePropertyName("lastSkuUpdate"u8);
                writer.WriteStringValue(LastSkuUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(MinCapacity))
            {
                writer.WritePropertyName("minCapacity"u8);
                writer.WriteNumberValue(MinCapacity.Value);
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

        OperationalInsightsCapacityReservationProperties IJsonModel<OperationalInsightsCapacityReservationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsCapacityReservationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsCapacityReservationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsCapacityReservationProperties(document.RootElement, options);
        }

        internal static OperationalInsightsCapacityReservationProperties DeserializeOperationalInsightsCapacityReservationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? lastSkuUpdate = default;
            long? minCapacity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastSkuUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSkuUpdate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("minCapacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minCapacity = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OperationalInsightsCapacityReservationProperties(lastSkuUpdate, minCapacity, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OperationalInsightsCapacityReservationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsCapacityReservationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsCapacityReservationProperties)} does not support '{options.Format}' format.");
            }
        }

        OperationalInsightsCapacityReservationProperties IPersistableModel<OperationalInsightsCapacityReservationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsCapacityReservationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOperationalInsightsCapacityReservationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsCapacityReservationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OperationalInsightsCapacityReservationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
