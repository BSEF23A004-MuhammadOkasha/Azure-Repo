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

namespace Azure.AI.OpenAI.Assistants
{
    public partial class RequiredFunctionToolCall : IUtf8JsonSerializable, IJsonModel<RequiredFunctionToolCall>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RequiredFunctionToolCall>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RequiredFunctionToolCall>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequiredFunctionToolCall>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RequiredFunctionToolCall)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("function"u8);
            writer.WriteObjectValue(InternalDetails);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
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

        RequiredFunctionToolCall IJsonModel<RequiredFunctionToolCall>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequiredFunctionToolCall>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RequiredFunctionToolCall)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRequiredFunctionToolCall(document.RootElement, options);
        }

        internal static RequiredFunctionToolCall DeserializeRequiredFunctionToolCall(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalRequiredFunctionToolCallDetails function = default;
            string type = default;
            string id = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("function"u8))
                {
                    function = InternalRequiredFunctionToolCallDetails.DeserializeInternalRequiredFunctionToolCallDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RequiredFunctionToolCall(type, id, serializedAdditionalRawData, function);
        }

        BinaryData IPersistableModel<RequiredFunctionToolCall>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequiredFunctionToolCall>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RequiredFunctionToolCall)} does not support '{options.Format}' format.");
            }
        }

        RequiredFunctionToolCall IPersistableModel<RequiredFunctionToolCall>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequiredFunctionToolCall>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRequiredFunctionToolCall(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RequiredFunctionToolCall)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RequiredFunctionToolCall>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new RequiredFunctionToolCall FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRequiredFunctionToolCall(document.RootElement);
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
