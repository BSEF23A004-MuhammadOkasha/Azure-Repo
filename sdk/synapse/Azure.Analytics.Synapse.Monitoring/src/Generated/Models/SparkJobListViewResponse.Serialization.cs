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

namespace Azure.Analytics.Synapse.Monitoring.Models
{
    public partial class SparkJobListViewResponse : IUtf8JsonSerializable, IJsonModel<SparkJobListViewResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SparkJobListViewResponse>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SparkJobListViewResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SparkJobListViewResponse>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SparkJobListViewResponse>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NJobs))
            {
                writer.WritePropertyName("nJobs"u8);
                writer.WriteNumberValue(NJobs.Value);
            }
            if (Optional.IsCollectionDefined(SparkJobs))
            {
                if (SparkJobs != null)
                {
                    writer.WritePropertyName("sparkJobs"u8);
                    writer.WriteStartArray();
                    foreach (var item in SparkJobs)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("sparkJobs");
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

        SparkJobListViewResponse IJsonModel<SparkJobListViewResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SparkJobListViewResponse)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSparkJobListViewResponse(document.RootElement, options);
        }

        internal static SparkJobListViewResponse DeserializeSparkJobListViewResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> nJobs = default;
            Optional<IReadOnlyList<SparkJob>> sparkJobs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nJobs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sparkJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SparkJob> array = new List<SparkJob>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SparkJob.DeserializeSparkJob(item));
                    }
                    sparkJobs = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SparkJobListViewResponse(Optional.ToNullable(nJobs), Optional.ToList(sparkJobs), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SparkJobListViewResponse>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SparkJobListViewResponse)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SparkJobListViewResponse IPersistableModel<SparkJobListViewResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SparkJobListViewResponse)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSparkJobListViewResponse(document.RootElement, options);
        }

        string IPersistableModel<SparkJobListViewResponse>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
