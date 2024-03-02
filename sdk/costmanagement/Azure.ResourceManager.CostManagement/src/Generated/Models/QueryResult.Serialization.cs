// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.CostManagement;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class QueryResult : IUtf8JsonSerializable, IJsonModel<QueryResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QueryResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QueryResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W" && Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku);
            }
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W" && !(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (NextLink != null)
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
            if (!(Columns is ChangeTrackingList<QueryColumn> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("columns"u8);
                writer.WriteStartArray();
                foreach (var item in Columns)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Rows is ChangeTrackingList<IList<BinaryData>> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("rows"u8);
                writer.WriteStartArray();
                foreach (var item in Rows)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        if (item0 == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item0);
#else
                        using (JsonDocument document = JsonDocument.Parse(item0))
                        {
                            JsonSerializer.Serialize(writer, document.RootElement);
                        }
#endif
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        QueryResult IJsonModel<QueryResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQueryResult(document.RootElement, options);
        }

        internal static QueryResult DeserializeQueryResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            string sku = default;
            ETag? eTag = default;
            IReadOnlyDictionary<string, string> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string nextLink = default;
            IReadOnlyList<QueryColumn> columns = default;
            IReadOnlyList<IList<BinaryData>> rows = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    ReadId(property, ref id);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("nextLink"u8))
                        {
                            nextLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("columns"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<QueryColumn> array = new List<QueryColumn>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(QueryColumn.DeserializeQueryColumn(item, options));
                            }
                            columns = array;
                            continue;
                        }
                        if (property0.NameEquals("rows"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IList<BinaryData>> array = new List<IList<BinaryData>>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    List<BinaryData> array0 = new List<BinaryData>();
                                    foreach (var item0 in item.EnumerateArray())
                                    {
                                        if (item0.ValueKind == JsonValueKind.Null)
                                        {
                                            array0.Add(null);
                                        }
                                        else
                                        {
                                            array0.Add(BinaryData.FromString(item0.GetRawText()));
                                        }
                                    }
                                    array.Add(array0);
                                }
                            }
                            rows = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QueryResult(
                id,
                name,
                type,
                systemData,
                nextLink,
                columns ?? new ChangeTrackingList<QueryColumn>(),
                rows ?? new ChangeTrackingList<IList<BinaryData>>(),
                location,
                sku,
                eTag,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QueryResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QueryResult)} does not support '{options.Format}' format.");
            }
        }

        QueryResult IPersistableModel<QueryResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQueryResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QueryResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QueryResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
