// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations.Models
{
    public partial class AnalyzeConversationOperationInput : IUtf8JsonSerializable, IJsonModel<AnalyzeConversationOperationInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalyzeConversationOperationInput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AnalyzeConversationOperationInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeConversationOperationInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyzeConversationOperationInput)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            writer.WritePropertyName("analysisInput"u8);
            writer.WriteObjectValue(ConversationInput, options);
            writer.WritePropertyName("tasks"u8);
            writer.WriteStartArray();
            foreach (var item in Actions)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
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

        AnalyzeConversationOperationInput IJsonModel<AnalyzeConversationOperationInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeConversationOperationInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyzeConversationOperationInput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyzeConversationOperationInput(document.RootElement, options);
        }

        internal static AnalyzeConversationOperationInput DeserializeAnalyzeConversationOperationInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string displayName = default;
            MultiLanguageConversationInput analysisInput = default;
            IList<AnalyzeConversationOperationAction> tasks = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("analysisInput"u8))
                {
                    analysisInput = MultiLanguageConversationInput.DeserializeMultiLanguageConversationInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tasks"u8))
                {
                    List<AnalyzeConversationOperationAction> array = new List<AnalyzeConversationOperationAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnalyzeConversationOperationAction.DeserializeAnalyzeConversationOperationAction(item, options));
                    }
                    tasks = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AnalyzeConversationOperationInput(displayName, analysisInput, tasks, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AnalyzeConversationOperationInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeConversationOperationInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AnalyzeConversationOperationInput)} does not support writing '{options.Format}' format.");
            }
        }

        AnalyzeConversationOperationInput IPersistableModel<AnalyzeConversationOperationInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeConversationOperationInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAnalyzeConversationOperationInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnalyzeConversationOperationInput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnalyzeConversationOperationInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AnalyzeConversationOperationInput FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAnalyzeConversationOperationInput(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
