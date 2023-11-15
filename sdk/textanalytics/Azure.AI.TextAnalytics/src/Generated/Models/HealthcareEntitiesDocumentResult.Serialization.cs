// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class HealthcareEntitiesDocumentResult : IUtf8JsonSerializable, IJsonModel<HealthcareEntitiesDocumentResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HealthcareEntitiesDocumentResult>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<HealthcareEntitiesDocumentResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<HealthcareEntitiesDocumentResult>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<HealthcareEntitiesDocumentResult>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("entities"u8);
            writer.WriteStartArray();
            foreach (var item in Entities)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("relations"u8);
            writer.WriteStartArray();
            foreach (var item in Relations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("warnings"u8);
            writer.WriteStartArray();
            foreach (var item in Warnings)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Statistics))
            {
                writer.WritePropertyName("statistics"u8);
                writer.WriteObjectValue(Statistics);
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

        HealthcareEntitiesDocumentResult IJsonModel<HealthcareEntitiesDocumentResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HealthcareEntitiesDocumentResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareEntitiesDocumentResult(document.RootElement, options);
        }

        internal static HealthcareEntitiesDocumentResult DeserializeHealthcareEntitiesDocumentResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<HealthcareEntityInternal> entities = default;
            IList<HealthcareRelationInternal> relations = default;
            string id = default;
            IList<DocumentWarning> warnings = default;
            Optional<TextDocumentStatistics> statistics = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("entities"u8))
                {
                    List<HealthcareEntityInternal> array = new List<HealthcareEntityInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareEntityInternal.DeserializeHealthcareEntityInternal(item));
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("relations"u8))
                {
                    List<HealthcareRelationInternal> array = new List<HealthcareRelationInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareRelationInternal.DeserializeHealthcareRelationInternal(item));
                    }
                    relations = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warnings"u8))
                {
                    List<DocumentWarning> array = new List<DocumentWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentWarning.DeserializeDocumentWarning(item));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("statistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statistics = TextDocumentStatistics.DeserializeTextDocumentStatistics(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HealthcareEntitiesDocumentResult(id, warnings, Optional.ToNullable(statistics), serializedAdditionalRawData, entities, relations);
        }

        BinaryData IPersistableModel<HealthcareEntitiesDocumentResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HealthcareEntitiesDocumentResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        HealthcareEntitiesDocumentResult IPersistableModel<HealthcareEntitiesDocumentResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HealthcareEntitiesDocumentResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeHealthcareEntitiesDocumentResult(document.RootElement, options);
        }

        string IPersistableModel<HealthcareEntitiesDocumentResult>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
