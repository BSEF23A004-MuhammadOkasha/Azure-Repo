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

namespace Azure.ResourceManager.WebPubSub.Models
{
    public partial class WebPubSubHubProperties : IUtf8JsonSerializable, IJsonModel<WebPubSubHubProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebPubSubHubProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<WebPubSubHubProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<WebPubSubHubProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<WebPubSubHubProperties>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(EventHandlers))
            {
                writer.WritePropertyName("eventHandlers"u8);
                writer.WriteStartArray();
                foreach (var item in EventHandlers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AnonymousConnectPolicy))
            {
                writer.WritePropertyName("anonymousConnectPolicy"u8);
                writer.WriteStringValue(AnonymousConnectPolicy);
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

        WebPubSubHubProperties IJsonModel<WebPubSubHubProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WebPubSubHubProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebPubSubHubProperties(document.RootElement, options);
        }

        internal static WebPubSubHubProperties DeserializeWebPubSubHubProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<WebPubSubEventHandler>> eventHandlers = default;
            Optional<string> anonymousConnectPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventHandlers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebPubSubEventHandler> array = new List<WebPubSubEventHandler>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebPubSubEventHandler.DeserializeWebPubSubEventHandler(item));
                    }
                    eventHandlers = array;
                    continue;
                }
                if (property.NameEquals("anonymousConnectPolicy"u8))
                {
                    anonymousConnectPolicy = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebPubSubHubProperties(Optional.ToList(eventHandlers), anonymousConnectPolicy.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebPubSubHubProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WebPubSubHubProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        WebPubSubHubProperties IPersistableModel<WebPubSubHubProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WebPubSubHubProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeWebPubSubHubProperties(document.RootElement, options);
        }

        string IPersistableModel<WebPubSubHubProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
