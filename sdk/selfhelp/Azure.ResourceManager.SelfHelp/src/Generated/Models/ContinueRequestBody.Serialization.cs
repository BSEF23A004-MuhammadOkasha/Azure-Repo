// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class ContinueRequestBody : IUtf8JsonSerializable, IJsonModel<ContinueRequestBody>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContinueRequestBody>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContinueRequestBody>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinueRequestBody>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ContinueRequestBody)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StepId))
            {
                writer.WritePropertyName("stepId"u8);
                writer.WriteStringValue(StepId);
            }
            if (Optional.IsCollectionDefined(Responses))
            {
                writer.WritePropertyName("responses"u8);
                writer.WriteStartArray();
                foreach (var item in Responses)
                {
                    writer.WriteObjectValue(item);
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

        ContinueRequestBody IJsonModel<ContinueRequestBody>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinueRequestBody>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ContinueRequestBody)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContinueRequestBody(document.RootElement, options);
        }

        internal static ContinueRequestBody DeserializeContinueRequestBody(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> stepId = default;
            Optional<IList<TroubleshooterResult>> responses = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stepId"u8))
                {
                    stepId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("responses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TroubleshooterResult> array = new List<TroubleshooterResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TroubleshooterResult.DeserializeTroubleshooterResult(item));
                    }
                    responses = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContinueRequestBody(stepId.Value, Optional.ToList(responses), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContinueRequestBody>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinueRequestBody>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ContinueRequestBody)} does not support '{options.Format}' format.");
            }
        }

        ContinueRequestBody IPersistableModel<ContinueRequestBody>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContinueRequestBody>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContinueRequestBody(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ContinueRequestBody)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContinueRequestBody>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
