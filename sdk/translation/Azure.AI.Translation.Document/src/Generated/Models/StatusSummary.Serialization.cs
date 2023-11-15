// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translation.Document.Models
{
    internal partial class StatusSummary : IUtf8JsonSerializable, IJsonModel<StatusSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StatusSummary>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<StatusSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<StatusSummary>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<StatusSummary>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("total"u8);
            writer.WriteNumberValue(Total);
            writer.WritePropertyName("failed"u8);
            writer.WriteNumberValue(Failed);
            writer.WritePropertyName("success"u8);
            writer.WriteNumberValue(Success);
            writer.WritePropertyName("inProgress"u8);
            writer.WriteNumberValue(InProgress);
            writer.WritePropertyName("notYetStarted"u8);
            writer.WriteNumberValue(NotYetStarted);
            writer.WritePropertyName("cancelled"u8);
            writer.WriteNumberValue(Cancelled);
            writer.WritePropertyName("totalCharacterCharged"u8);
            writer.WriteNumberValue(TotalCharacterCharged);
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        StatusSummary IJsonModel<StatusSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StatusSummary)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStatusSummary(document.RootElement, options);
        }

        internal static StatusSummary DeserializeStatusSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int total = default;
            int failed = default;
            int success = default;
            int inProgress = default;
            int notYetStarted = default;
            int cancelled = default;
            long totalCharacterCharged = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("total"u8))
                {
                    total = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failed"u8))
                {
                    failed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("success"u8))
                {
                    success = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("inProgress"u8))
                {
                    inProgress = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("notYetStarted"u8))
                {
                    notYetStarted = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cancelled"u8))
                {
                    cancelled = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalCharacterCharged"u8))
                {
                    totalCharacterCharged = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StatusSummary(total, failed, success, inProgress, notYetStarted, cancelled, totalCharacterCharged, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StatusSummary>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StatusSummary)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        StatusSummary IPersistableModel<StatusSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StatusSummary)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeStatusSummary(document.RootElement, options);
        }

        string IPersistableModel<StatusSummary>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
