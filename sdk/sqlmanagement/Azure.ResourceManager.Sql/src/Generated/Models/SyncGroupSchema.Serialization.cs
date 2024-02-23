// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SyncGroupSchema : IUtf8JsonSerializable, IJsonModel<SyncGroupSchema>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SyncGroupSchema>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SyncGroupSchema>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncGroupSchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncGroupSchema)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tables is ChangeTrackingList<SyncGroupSchemaTable> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tables"u8);
                writer.WriteStartArray();
                foreach (var item in Tables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (MasterSyncMemberName != null)
            {
                writer.WritePropertyName("masterSyncMemberName"u8);
                writer.WriteStringValue(MasterSyncMemberName);
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

        SyncGroupSchema IJsonModel<SyncGroupSchema>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncGroupSchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncGroupSchema)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSyncGroupSchema(document.RootElement, options);
        }

        internal static SyncGroupSchema DeserializeSyncGroupSchema(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<SyncGroupSchemaTable> tables = default;
            Optional<string> masterSyncMemberName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SyncGroupSchemaTable> array = new List<SyncGroupSchemaTable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncGroupSchemaTable.DeserializeSyncGroupSchemaTable(item, options));
                    }
                    tables = array;
                    continue;
                }
                if (property.NameEquals("masterSyncMemberName"u8))
                {
                    masterSyncMemberName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SyncGroupSchema(tables ?? new ChangeTrackingList<SyncGroupSchemaTable>(), masterSyncMemberName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SyncGroupSchema>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncGroupSchema>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SyncGroupSchema)} does not support '{options.Format}' format.");
            }
        }

        SyncGroupSchema IPersistableModel<SyncGroupSchema>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncGroupSchema>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSyncGroupSchema(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SyncGroupSchema)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SyncGroupSchema>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
