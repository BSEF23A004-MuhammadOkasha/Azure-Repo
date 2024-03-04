// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Storage;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class DateAfterCreation : IUtf8JsonSerializable, IJsonModel<DateAfterCreation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DateAfterCreation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DateAfterCreation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DateAfterCreation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DateAfterCreation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("daysAfterCreationGreaterThan"u8);
            writer.WriteNumberValue(DaysAfterCreationGreaterThan);
            if (Optional.IsDefined(DaysAfterLastTierChangeGreaterThan))
            {
                writer.WritePropertyName("daysAfterLastTierChangeGreaterThan"u8);
                writer.WriteNumberValue(DaysAfterLastTierChangeGreaterThan.Value);
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

        DateAfterCreation IJsonModel<DateAfterCreation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DateAfterCreation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DateAfterCreation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDateAfterCreation(document.RootElement, options);
        }

        internal static DateAfterCreation DeserializeDateAfterCreation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float daysAfterCreationGreaterThan = default;
            float? daysAfterLastTierChangeGreaterThan = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("daysAfterCreationGreaterThan"u8))
                {
                    daysAfterCreationGreaterThan = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("daysAfterLastTierChangeGreaterThan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    daysAfterLastTierChangeGreaterThan = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DateAfterCreation(daysAfterCreationGreaterThan, daysAfterLastTierChangeGreaterThan, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DateAfterCreation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DateAfterCreation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DateAfterCreation)} does not support '{options.Format}' format.");
            }
        }

        DateAfterCreation IPersistableModel<DateAfterCreation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DateAfterCreation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDateAfterCreation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DateAfterCreation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DateAfterCreation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
