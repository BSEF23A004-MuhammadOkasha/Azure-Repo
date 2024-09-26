// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class SnapshotPolicyHourlySchedule : IUtf8JsonSerializable, IJsonModel<SnapshotPolicyHourlySchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SnapshotPolicyHourlySchedule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SnapshotPolicyHourlySchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotPolicyHourlySchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SnapshotPolicyHourlySchedule)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(SnapshotsToKeep))
            {
                writer.WritePropertyName("snapshotsToKeep"u8);
                writer.WriteNumberValue(SnapshotsToKeep.Value);
            }
            if (Optional.IsDefined(Minute))
            {
                writer.WritePropertyName("minute"u8);
                writer.WriteNumberValue(Minute.Value);
            }
            if (Optional.IsDefined(UsedBytes))
            {
                writer.WritePropertyName("usedBytes"u8);
                writer.WriteNumberValue(UsedBytes.Value);
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
        }

        SnapshotPolicyHourlySchedule IJsonModel<SnapshotPolicyHourlySchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotPolicyHourlySchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SnapshotPolicyHourlySchedule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSnapshotPolicyHourlySchedule(document.RootElement, options);
        }

        internal static SnapshotPolicyHourlySchedule DeserializeSnapshotPolicyHourlySchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? snapshotsToKeep = default;
            int? minute = default;
            long? usedBytes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("snapshotsToKeep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    snapshotsToKeep = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minute = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("usedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usedBytes = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SnapshotPolicyHourlySchedule(snapshotsToKeep, minute, usedBytes, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SnapshotPolicyHourlySchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotPolicyHourlySchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SnapshotPolicyHourlySchedule)} does not support writing '{options.Format}' format.");
            }
        }

        SnapshotPolicyHourlySchedule IPersistableModel<SnapshotPolicyHourlySchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotPolicyHourlySchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSnapshotPolicyHourlySchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SnapshotPolicyHourlySchedule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SnapshotPolicyHourlySchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
