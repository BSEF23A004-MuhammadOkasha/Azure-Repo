// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBox;

namespace Azure.ResourceManager.DataBox.Models
{
    internal partial class ScheduleAvailabilityResponse : IUtf8JsonSerializable, IJsonModel<ScheduleAvailabilityResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScheduleAvailabilityResponse>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScheduleAvailabilityResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleAvailabilityResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduleAvailabilityResponse)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(AvailableDates is ChangeTrackingList<DateTimeOffset> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("availableDates"u8);
                writer.WriteStartArray();
                foreach (var item in AvailableDates)
                {
                    writer.WriteStringValue(item, "O");
                }
                writer.WriteEndArray();
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

        ScheduleAvailabilityResponse IJsonModel<ScheduleAvailabilityResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleAvailabilityResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduleAvailabilityResponse)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduleAvailabilityResponse(document.RootElement, options);
        }

        internal static ScheduleAvailabilityResponse DeserializeScheduleAvailabilityResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DateTimeOffset> availableDates = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("availableDates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DateTimeOffset> array = new List<DateTimeOffset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDateTimeOffset("O"));
                    }
                    availableDates = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ScheduleAvailabilityResponse(availableDates ?? new ChangeTrackingList<DateTimeOffset>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScheduleAvailabilityResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleAvailabilityResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScheduleAvailabilityResponse)} does not support '{options.Format}' format.");
            }
        }

        ScheduleAvailabilityResponse IPersistableModel<ScheduleAvailabilityResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduleAvailabilityResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScheduleAvailabilityResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScheduleAvailabilityResponse)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScheduleAvailabilityResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
