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
    internal partial class InstancesBatchResponse : IUtf8JsonSerializable, IJsonModel<InstancesBatchResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InstancesBatchResponse>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<InstancesBatchResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<InstancesBatchResponse>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<InstancesBatchResponse>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Get))
                {
                    writer.WritePropertyName("get"u8);
                    writer.WriteStartArray();
                    foreach (var item in Get)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Put))
                {
                    writer.WritePropertyName("put"u8);
                    writer.WriteStartArray();
                    foreach (var item in Put)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Update))
                {
                    writer.WritePropertyName("update"u8);
                    writer.WriteStartArray();
                    foreach (var item in Update)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Delete))
                {
                    writer.WritePropertyName("delete"u8);
                    writer.WriteStartArray();
                    foreach (var item in Delete)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
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

        InstancesBatchResponse IJsonModel<InstancesBatchResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InstancesBatchResponse)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInstancesBatchResponse(document.RootElement, options);
        }

        internal static InstancesBatchResponse DeserializeInstancesBatchResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<InstancesOperationResult>> @get = default;
            Optional<IReadOnlyList<InstancesOperationResult>> put = default;
            Optional<IReadOnlyList<InstancesOperationResult>> update = default;
            Optional<IReadOnlyList<TimeSeriesOperationError>> delete = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("get"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InstancesOperationResult> array = new List<InstancesOperationResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstancesOperationResult.DeserializeInstancesOperationResult(item));
                    }
                    @get = array;
                    continue;
                }
                if (property.NameEquals("put"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InstancesOperationResult> array = new List<InstancesOperationResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstancesOperationResult.DeserializeInstancesOperationResult(item));
                    }
                    put = array;
                    continue;
                }
                if (property.NameEquals("update"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InstancesOperationResult> array = new List<InstancesOperationResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstancesOperationResult.DeserializeInstancesOperationResult(item));
                    }
                    update = array;
                    continue;
                }
                if (property.NameEquals("delete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TimeSeriesOperationError> array = new List<TimeSeriesOperationError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeSeriesOperationError.DeserializeTimeSeriesOperationError(item));
                    }
                    delete = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InstancesBatchResponse(Optional.ToList(@get), Optional.ToList(put), Optional.ToList(update), Optional.ToList(delete), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InstancesBatchResponse>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InstancesBatchResponse)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        InstancesBatchResponse IPersistableModel<InstancesBatchResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InstancesBatchResponse)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeInstancesBatchResponse(document.RootElement, options);
        }

        string IPersistableModel<InstancesBatchResponse>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
