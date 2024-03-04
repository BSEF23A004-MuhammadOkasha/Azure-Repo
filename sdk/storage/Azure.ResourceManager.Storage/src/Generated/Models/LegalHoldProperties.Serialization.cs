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
    public partial class LegalHoldProperties : IUtf8JsonSerializable, IJsonModel<LegalHoldProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LegalHoldProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LegalHoldProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LegalHoldProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LegalHoldProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && HasLegalHold.HasValue)
            {
                writer.WritePropertyName("hasLegalHold"u8);
                writer.WriteBooleanValue(HasLegalHold.Value);
            }
            if (!(Tags is ChangeTrackingList<LegalHoldTag> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartArray();
                foreach (var item in Tags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ProtectedAppendWritesHistory != null)
            {
                writer.WritePropertyName("protectedAppendWritesHistory"u8);
                writer.WriteObjectValue(ProtectedAppendWritesHistory);
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

        LegalHoldProperties IJsonModel<LegalHoldProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LegalHoldProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LegalHoldProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLegalHoldProperties(document.RootElement, options);
        }

        internal static LegalHoldProperties DeserializeLegalHoldProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? hasLegalHold = default;
            IReadOnlyList<LegalHoldTag> tags = default;
            ProtectedAppendWritesHistory protectedAppendWritesHistory = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hasLegalHold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasLegalHold = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LegalHoldTag> array = new List<LegalHoldTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LegalHoldTag.DeserializeLegalHoldTag(item, options));
                    }
                    tags = array;
                    continue;
                }
                if (property.NameEquals("protectedAppendWritesHistory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedAppendWritesHistory = ProtectedAppendWritesHistory.DeserializeProtectedAppendWritesHistory(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LegalHoldProperties(hasLegalHold, tags ?? new ChangeTrackingList<LegalHoldTag>(), protectedAppendWritesHistory, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LegalHoldProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LegalHoldProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LegalHoldProperties)} does not support '{options.Format}' format.");
            }
        }

        LegalHoldProperties IPersistableModel<LegalHoldProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LegalHoldProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLegalHoldProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LegalHoldProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LegalHoldProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
