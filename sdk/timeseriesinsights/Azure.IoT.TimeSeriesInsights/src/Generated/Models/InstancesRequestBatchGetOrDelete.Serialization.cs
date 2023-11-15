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

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class InstancesRequestBatchGetOrDelete : IUtf8JsonSerializable, IJsonModel<InstancesRequestBatchGetOrDelete>
    {
        void IJsonModel<InstancesRequestBatchGetOrDelete>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<InstancesRequestBatchGetOrDelete>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<InstancesRequestBatchGetOrDelete>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TimeSeriesIdsInternal))
            {
                writer.WritePropertyName("timeSeriesIds"u8);
                writer.WriteStartArray();
                foreach (var item in TimeSeriesIdsInternal)
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
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Names))
            {
                writer.WritePropertyName("names"u8);
                writer.WriteStartArray();
                foreach (var item in Names)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        InstancesRequestBatchGetOrDelete IJsonModel<InstancesRequestBatchGetOrDelete>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InstancesRequestBatchGetOrDelete)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInstancesRequestBatchGetOrDelete(document.RootElement, options);
        }

        internal static InstancesRequestBatchGetOrDelete DeserializeInstancesRequestBatchGetOrDelete(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<IList<object>>> timeSeriesIds = default;
            Optional<IList<string>> names = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeSeriesIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IList<object>> array = new List<IList<object>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<object> array0 = new List<object>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                if (item0.ValueKind == JsonValueKind.Null)
                                {
                                    array0.Add(null);
                                }
                                else
                                {
                                    array0.Add(item0.GetObject());
                                }
                            }
                            array.Add(array0);
                        }
                    }
                    timeSeriesIds = array;
                    continue;
                }
                if (property.NameEquals("names"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    names = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InstancesRequestBatchGetOrDelete(Optional.ToList(timeSeriesIds), Optional.ToList(names), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InstancesRequestBatchGetOrDelete>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InstancesRequestBatchGetOrDelete)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        InstancesRequestBatchGetOrDelete IPersistableModel<InstancesRequestBatchGetOrDelete>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InstancesRequestBatchGetOrDelete)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeInstancesRequestBatchGetOrDelete(document.RootElement, options);
        }

        string IPersistableModel<InstancesRequestBatchGetOrDelete>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
