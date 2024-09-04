// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class OverviewStatusItem : IUtf8JsonSerializable, IJsonModel<OverviewStatusItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OverviewStatusItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OverviewStatusItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OverviewStatusItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OverviewStatusItem)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StatusName))
            {
                writer.WritePropertyName("statusName"u8);
                writer.WriteStringValue(StatusName);
            }
            if (Optional.IsDefined(StatusValue))
            {
                writer.WritePropertyName("statusValue"u8);
                writer.WriteStringValue(StatusValue);
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

        OverviewStatusItem IJsonModel<OverviewStatusItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OverviewStatusItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OverviewStatusItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOverviewStatusItem(document.RootElement, options);
        }

        internal static OverviewStatusItem DeserializeOverviewStatusItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string statusName = default;
            string statusValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusName"u8))
                {
                    statusName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusValue"u8))
                {
                    statusValue = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OverviewStatusItem(statusName, statusValue, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OverviewStatusItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OverviewStatusItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OverviewStatusItem)} does not support writing '{options.Format}' format.");
            }
        }

        OverviewStatusItem IPersistableModel<OverviewStatusItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OverviewStatusItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOverviewStatusItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OverviewStatusItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OverviewStatusItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
