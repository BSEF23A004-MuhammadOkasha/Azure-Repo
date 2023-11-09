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

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitorEndpointScope : IUtf8JsonSerializable, IJsonModel<ConnectionMonitorEndpointScope>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectionMonitorEndpointScope>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ConnectionMonitorEndpointScope>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Include))
            {
                writer.WritePropertyName("include"u8);
                writer.WriteStartArray();
                foreach (var item in Include)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Exclude))
            {
                writer.WritePropertyName("exclude"u8);
                writer.WriteStartArray();
                foreach (var item in Exclude)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ConnectionMonitorEndpointScope IJsonModel<ConnectionMonitorEndpointScope>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConnectionMonitorEndpointScope)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectionMonitorEndpointScope(document.RootElement, options);
        }

        internal static ConnectionMonitorEndpointScope DeserializeConnectionMonitorEndpointScope(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ConnectionMonitorEndpointScopeItem>> include = default;
            Optional<IList<ConnectionMonitorEndpointScopeItem>> exclude = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("include"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectionMonitorEndpointScopeItem> array = new List<ConnectionMonitorEndpointScopeItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectionMonitorEndpointScopeItem.DeserializeConnectionMonitorEndpointScopeItem(item));
                    }
                    include = array;
                    continue;
                }
                if (property.NameEquals("exclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectionMonitorEndpointScopeItem> array = new List<ConnectionMonitorEndpointScopeItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectionMonitorEndpointScopeItem.DeserializeConnectionMonitorEndpointScopeItem(item));
                    }
                    exclude = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectionMonitorEndpointScope(Optional.ToList(include), Optional.ToList(exclude), serializedAdditionalRawData);
        }

        BinaryData IModel<ConnectionMonitorEndpointScope>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConnectionMonitorEndpointScope)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ConnectionMonitorEndpointScope IModel<ConnectionMonitorEndpointScope>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConnectionMonitorEndpointScope)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeConnectionMonitorEndpointScope(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ConnectionMonitorEndpointScope>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
