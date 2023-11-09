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

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class WindowsEventLogDataSource : IUtf8JsonSerializable, IJsonModel<WindowsEventLogDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WindowsEventLogDataSource>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<WindowsEventLogDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Streams))
            {
                writer.WritePropertyName("streams"u8);
                writer.WriteStartArray();
                foreach (var item in Streams)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(XPathQueries))
            {
                writer.WritePropertyName("xPathQueries"u8);
                writer.WriteStartArray();
                foreach (var item in XPathQueries)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        WindowsEventLogDataSource IJsonModel<WindowsEventLogDataSource>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WindowsEventLogDataSource)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWindowsEventLogDataSource(document.RootElement, options);
        }

        internal static WindowsEventLogDataSource DeserializeWindowsEventLogDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<WindowsEventLogDataSourceStream>> streams = default;
            Optional<IList<string>> xPathQueries = default;
            Optional<string> name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WindowsEventLogDataSourceStream> array = new List<WindowsEventLogDataSourceStream>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new WindowsEventLogDataSourceStream(item.GetString()));
                    }
                    streams = array;
                    continue;
                }
                if (property.NameEquals("xPathQueries"u8))
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
                    xPathQueries = array;
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WindowsEventLogDataSource(Optional.ToList(streams), Optional.ToList(xPathQueries), name.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<WindowsEventLogDataSource>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WindowsEventLogDataSource)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        WindowsEventLogDataSource IModel<WindowsEventLogDataSource>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WindowsEventLogDataSource)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeWindowsEventLogDataSource(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<WindowsEventLogDataSource>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
