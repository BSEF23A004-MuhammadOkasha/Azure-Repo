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
    public partial class SummaryResult : IUtf8JsonSerializable, IJsonModel<SummaryResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SummaryResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SummaryResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SummaryResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SummaryResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("conversations"u8);
            writer.WriteStartArray();
            foreach (var item in Conversations)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("errors"u8);
            writer.WriteStartArray();
            foreach (var item in Errors)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Statistics))
            {
                writer.WritePropertyName("statistics"u8);
                writer.WriteObjectValue(Statistics, options);
            }
            writer.WritePropertyName("modelVersion"u8);
            writer.WriteStringValue(ModelVersion);
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

        SummaryResult IJsonModel<SummaryResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SummaryResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SummaryResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSummaryResult(document.RootElement, options);
        }

        internal static SummaryResult DeserializeSummaryResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ConversationsSummaryResult> conversations = default;
            IReadOnlyList<DocumentError> errors = default;
            RequestStatistics statistics = default;
            string modelVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("conversations"u8))
                {
                    List<ConversationsSummaryResult> array = new List<ConversationsSummaryResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConversationsSummaryResult.DeserializeConversationsSummaryResult(item, options));
                    }
                    conversations = array;
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    List<DocumentError> array = new List<DocumentError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentError.DeserializeDocumentError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("statistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statistics = RequestStatistics.DeserializeRequestStatistics(property.Value, options);
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SummaryResult(conversations, errors, statistics, modelVersion, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SummaryResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SummaryResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SummaryResult)} does not support writing '{options.Format}' format.");
            }
        }

        SummaryResult IPersistableModel<SummaryResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SummaryResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSummaryResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SummaryResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SummaryResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SummaryResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSummaryResult(document.RootElement);
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
