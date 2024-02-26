// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Communication.Messages
{
    public partial class MediaNotificationContent : IUtf8JsonSerializable, IJsonModel<MediaNotificationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaNotificationContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MediaNotificationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaNotificationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaNotificationContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Content != null)
            {
                writer.WritePropertyName("content"u8);
                writer.WriteStringValue(Content);
            }
            writer.WritePropertyName("mediaUri"u8);
            writer.WriteStringValue(MediaUri.AbsoluteUri);
            writer.WritePropertyName("channelRegistrationId"u8);
            writer.WriteStringValue(ChannelRegistrationId);
            writer.WritePropertyName("to"u8);
            writer.WriteStartArray();
            foreach (var item in To)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        MediaNotificationContent IJsonModel<MediaNotificationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaNotificationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaNotificationContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaNotificationContent(document.RootElement, options);
        }

        internal static MediaNotificationContent DeserializeMediaNotificationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> content = default;
            Uri mediaUri = default;
            Guid channelRegistrationId = default;
            IList<string> to = default;
            CommunicationMessageKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"u8))
                {
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mediaUri"u8))
                {
                    mediaUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("channelRegistrationId"u8))
                {
                    channelRegistrationId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("to"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    to = array;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new CommunicationMessageKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MediaNotificationContent(channelRegistrationId, to, kind, serializedAdditionalRawData, content.Value, mediaUri);
        }

        BinaryData IPersistableModel<MediaNotificationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaNotificationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaNotificationContent)} does not support '{options.Format}' format.");
            }
        }

        MediaNotificationContent IPersistableModel<MediaNotificationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaNotificationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaNotificationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaNotificationContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaNotificationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new MediaNotificationContent FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMediaNotificationContent(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
