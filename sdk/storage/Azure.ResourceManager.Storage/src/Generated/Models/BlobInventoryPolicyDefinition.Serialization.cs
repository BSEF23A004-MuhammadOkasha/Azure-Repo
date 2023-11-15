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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class BlobInventoryPolicyDefinition : IUtf8JsonSerializable, IJsonModel<BlobInventoryPolicyDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BlobInventoryPolicyDefinition>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<BlobInventoryPolicyDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<BlobInventoryPolicyDefinition>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<BlobInventoryPolicyDefinition>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Filters))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteObjectValue(Filters);
            }
            writer.WritePropertyName("format"u8);
            writer.WriteStringValue(Format.ToString());
            writer.WritePropertyName("schedule"u8);
            writer.WriteStringValue(Schedule.ToString());
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType.ToString());
            writer.WritePropertyName("schemaFields"u8);
            writer.WriteStartArray();
            foreach (var item in SchemaFields)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

        BlobInventoryPolicyDefinition IJsonModel<BlobInventoryPolicyDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlobInventoryPolicyDefinition)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBlobInventoryPolicyDefinition(document.RootElement, options);
        }

        internal static BlobInventoryPolicyDefinition DeserializeBlobInventoryPolicyDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BlobInventoryPolicyFilter> filters = default;
            BlobInventoryPolicyFormat format = default;
            BlobInventoryPolicySchedule schedule = default;
            BlobInventoryPolicyObjectType objectType = default;
            IList<string> schemaFields = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filters = BlobInventoryPolicyFilter.DeserializeBlobInventoryPolicyFilter(property.Value);
                    continue;
                }
                if (property.NameEquals("format"u8))
                {
                    format = new BlobInventoryPolicyFormat(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("schedule"u8))
                {
                    schedule = new BlobInventoryPolicySchedule(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = new BlobInventoryPolicyObjectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("schemaFields"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    schemaFields = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BlobInventoryPolicyDefinition(filters.Value, format, schedule, objectType, schemaFields, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BlobInventoryPolicyDefinition>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlobInventoryPolicyDefinition)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BlobInventoryPolicyDefinition IPersistableModel<BlobInventoryPolicyDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlobInventoryPolicyDefinition)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBlobInventoryPolicyDefinition(document.RootElement, options);
        }

        string IPersistableModel<BlobInventoryPolicyDefinition>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
