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

namespace Azure.ResourceManager.Maps.Models
{
    public partial class MapsLinkedResource : IUtf8JsonSerializable, IJsonModel<MapsLinkedResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MapsLinkedResource>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MapsLinkedResource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MapsLinkedResource>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MapsLinkedResource>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("uniqueName"u8);
            writer.WriteStringValue(UniqueName);
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
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

        MapsLinkedResource IJsonModel<MapsLinkedResource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MapsLinkedResource)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMapsLinkedResource(document.RootElement, options);
        }

        internal static MapsLinkedResource DeserializeMapsLinkedResource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string uniqueName = default;
            string id = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uniqueName"u8))
                {
                    uniqueName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MapsLinkedResource(uniqueName, id, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MapsLinkedResource>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MapsLinkedResource)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MapsLinkedResource IPersistableModel<MapsLinkedResource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MapsLinkedResource)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMapsLinkedResource(document.RootElement, options);
        }

        string IPersistableModel<MapsLinkedResource>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
