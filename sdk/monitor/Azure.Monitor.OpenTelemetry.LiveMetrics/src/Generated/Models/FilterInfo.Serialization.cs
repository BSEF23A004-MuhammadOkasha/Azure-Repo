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

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    internal partial class FilterInfo : IUtf8JsonSerializable, IJsonModel<FilterInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FilterInfo>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<FilterInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<FilterInfo>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<FilterInfo>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FieldName))
            {
                writer.WritePropertyName("FieldName"u8);
                writer.WriteStringValue(FieldName);
            }
            if (Optional.IsDefined(Predicate))
            {
                writer.WritePropertyName("Predicate"u8);
                writer.WriteStringValue(Predicate.Value.ToString());
            }
            if (Optional.IsDefined(Comparand))
            {
                writer.WritePropertyName("Comparand"u8);
                writer.WriteStringValue(Comparand);
            }
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

        FilterInfo IJsonModel<FilterInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FilterInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFilterInfo(document.RootElement, options);
        }

        internal static FilterInfo DeserializeFilterInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> fieldName = default;
            Optional<FilterInfoPredicate> predicate = default;
            Optional<string> comparand = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("FieldName"u8))
                {
                    fieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Predicate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    predicate = new FilterInfoPredicate(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("Comparand"u8))
                {
                    comparand = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FilterInfo(fieldName.Value, Optional.ToNullable(predicate), comparand.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FilterInfo>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FilterInfo)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        FilterInfo IPersistableModel<FilterInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FilterInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFilterInfo(document.RootElement, options);
        }

        string IPersistableModel<FilterInfo>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
