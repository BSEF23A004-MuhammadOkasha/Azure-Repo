// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Messages.Models.Channels
{
    public partial class WhatsAppMessageTemplateBindings : IUtf8JsonSerializable, IJsonModel<WhatsAppMessageTemplateBindings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WhatsAppMessageTemplateBindings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WhatsAppMessageTemplateBindings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WhatsAppMessageTemplateBindings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WhatsAppMessageTemplateBindings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Header))
            {
                writer.WritePropertyName("header"u8);
                writer.WriteStartArray();
                foreach (var item in Header)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Body))
            {
                writer.WritePropertyName("body"u8);
                writer.WriteStartArray();
                foreach (var item in Body)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Footer))
            {
                writer.WritePropertyName("footer"u8);
                writer.WriteStartArray();
                foreach (var item in Footer)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Buttons))
            {
                writer.WritePropertyName("buttons"u8);
                writer.WriteStartArray();
                foreach (var item in Buttons)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
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

        WhatsAppMessageTemplateBindings IJsonModel<WhatsAppMessageTemplateBindings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WhatsAppMessageTemplateBindings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WhatsAppMessageTemplateBindings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWhatsAppMessageTemplateBindings(document.RootElement, options);
        }

        internal static WhatsAppMessageTemplateBindings DeserializeWhatsAppMessageTemplateBindings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<WhatsAppMessageTemplateBindingsComponent> header = default;
            IList<WhatsAppMessageTemplateBindingsComponent> body = default;
            IList<WhatsAppMessageTemplateBindingsComponent> footer = default;
            IList<WhatsAppMessageTemplateBindingsButton> buttons = default;
            string kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("header"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WhatsAppMessageTemplateBindingsComponent> array = new List<WhatsAppMessageTemplateBindingsComponent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WhatsAppMessageTemplateBindingsComponent.DeserializeWhatsAppMessageTemplateBindingsComponent(item, options));
                    }
                    header = array;
                    continue;
                }
                if (property.NameEquals("body"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WhatsAppMessageTemplateBindingsComponent> array = new List<WhatsAppMessageTemplateBindingsComponent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WhatsAppMessageTemplateBindingsComponent.DeserializeWhatsAppMessageTemplateBindingsComponent(item, options));
                    }
                    body = array;
                    continue;
                }
                if (property.NameEquals("footer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WhatsAppMessageTemplateBindingsComponent> array = new List<WhatsAppMessageTemplateBindingsComponent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WhatsAppMessageTemplateBindingsComponent.DeserializeWhatsAppMessageTemplateBindingsComponent(item, options));
                    }
                    footer = array;
                    continue;
                }
                if (property.NameEquals("buttons"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WhatsAppMessageTemplateBindingsButton> array = new List<WhatsAppMessageTemplateBindingsButton>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WhatsAppMessageTemplateBindingsButton.DeserializeWhatsAppMessageTemplateBindingsButton(item, options));
                    }
                    buttons = array;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WhatsAppMessageTemplateBindings(
                kind,
                serializedAdditionalRawData,
                header ?? new ChangeTrackingList<WhatsAppMessageTemplateBindingsComponent>(),
                body ?? new ChangeTrackingList<WhatsAppMessageTemplateBindingsComponent>(),
                footer ?? new ChangeTrackingList<WhatsAppMessageTemplateBindingsComponent>(),
                buttons ?? new ChangeTrackingList<WhatsAppMessageTemplateBindingsButton>());
        }

        BinaryData IPersistableModel<WhatsAppMessageTemplateBindings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WhatsAppMessageTemplateBindings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WhatsAppMessageTemplateBindings)} does not support writing '{options.Format}' format.");
            }
        }

        WhatsAppMessageTemplateBindings IPersistableModel<WhatsAppMessageTemplateBindings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WhatsAppMessageTemplateBindings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWhatsAppMessageTemplateBindings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WhatsAppMessageTemplateBindings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WhatsAppMessageTemplateBindings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new WhatsAppMessageTemplateBindings FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeWhatsAppMessageTemplateBindings(document.RootElement);
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
