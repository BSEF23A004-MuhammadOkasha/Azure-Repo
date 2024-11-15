// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class SourceControlSyncJobStream : IUtf8JsonSerializable, IJsonModel<SourceControlSyncJobStream>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SourceControlSyncJobStream>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SourceControlSyncJobStream>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlSyncJobStream>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceControlSyncJobStream)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceControlSyncJobStreamId))
            {
                writer.WritePropertyName("sourceControlSyncJobStreamId"u8);
                writer.WriteStringValue(SourceControlSyncJobStreamId);
            }
            if (Optional.IsDefined(Summary))
            {
                writer.WritePropertyName("summary"u8);
                writer.WriteStringValue(Summary);
            }
            if (options.Format != "W" && Optional.IsDefined(Time))
            {
                if (Time != null)
                {
                    writer.WritePropertyName("time"u8);
                    writer.WriteStringValue(Time.Value, "O");
                }
                else
                {
                    writer.WriteNull("time");
                }
            }
            if (Optional.IsDefined(StreamType))
            {
                writer.WritePropertyName("streamType"u8);
                writer.WriteStringValue(StreamType.Value.ToString());
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
        }

        SourceControlSyncJobStream IJsonModel<SourceControlSyncJobStream>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlSyncJobStream>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceControlSyncJobStream)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceControlSyncJobStream(document.RootElement, options);
        }

        internal static SourceControlSyncJobStream DeserializeSourceControlSyncJobStream(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string sourceControlSyncJobStreamId = default;
            string summary = default;
            DateTimeOffset? time = default;
            SourceControlStreamType? streamType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
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
                        if (property0.NameEquals("sourceControlSyncJobStreamId"u8))
                        {
                            sourceControlSyncJobStreamId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("summary"u8))
                        {
                            summary = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("time"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                time = null;
                                continue;
                            }
                            time = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("streamType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            streamType = new SourceControlStreamType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SourceControlSyncJobStream(
                id,
                sourceControlSyncJobStreamId,
                summary,
                time,
                streamType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SourceControlSyncJobStream>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlSyncJobStream>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SourceControlSyncJobStream)} does not support writing '{options.Format}' format.");
            }
        }

        SourceControlSyncJobStream IPersistableModel<SourceControlSyncJobStream>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlSyncJobStream>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSourceControlSyncJobStream(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SourceControlSyncJobStream)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SourceControlSyncJobStream>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
