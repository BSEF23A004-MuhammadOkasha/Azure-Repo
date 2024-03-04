// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    public partial class StreamingPath : IUtf8JsonSerializable, IJsonModel<StreamingPath>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingPath>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamingPath>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPath>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingPath)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("streamingProtocol"u8);
            writer.WriteStringValue(StreamingProtocol.ToString());
            writer.WritePropertyName("encryptionScheme"u8);
            writer.WriteStringValue(EncryptionScheme.ToString());
            if (Optional.IsCollectionDefined(Paths))
            {
                writer.WritePropertyName("paths"u8);
                writer.WriteStartArray();
                foreach (var item in Paths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        StreamingPath IJsonModel<StreamingPath>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPath>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingPath)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingPath(document.RootElement, options);
        }

        internal static StreamingPath DeserializeStreamingPath(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StreamingPolicyStreamingProtocol streamingProtocol = default;
            StreamingPathEncryptionScheme encryptionScheme = default;
            IReadOnlyList<string> paths = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streamingProtocol"u8))
                {
                    streamingProtocol = new StreamingPolicyStreamingProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("encryptionScheme"u8))
                {
                    encryptionScheme = new StreamingPathEncryptionScheme(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("paths"u8))
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
                    paths = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StreamingPath(streamingProtocol, encryptionScheme, paths ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamingPath>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPath>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingPath)} does not support '{options.Format}' format.");
            }
        }

        StreamingPath IPersistableModel<StreamingPath>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPath>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamingPath(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingPath)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingPath>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
