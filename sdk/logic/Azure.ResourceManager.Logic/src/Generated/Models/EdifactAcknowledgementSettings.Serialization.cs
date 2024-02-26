// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class EdifactAcknowledgementSettings : IUtf8JsonSerializable, IJsonModel<EdifactAcknowledgementSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdifactAcknowledgementSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdifactAcknowledgementSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactAcknowledgementSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdifactAcknowledgementSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("needTechnicalAcknowledgement"u8);
            writer.WriteBooleanValue(NeedTechnicalAcknowledgement);
            writer.WritePropertyName("batchTechnicalAcknowledgements"u8);
            writer.WriteBooleanValue(BatchTechnicalAcknowledgement);
            writer.WritePropertyName("needFunctionalAcknowledgement"u8);
            writer.WriteBooleanValue(NeedFunctionalAcknowledgement);
            writer.WritePropertyName("batchFunctionalAcknowledgements"u8);
            writer.WriteBooleanValue(BatchFunctionalAcknowledgement);
            writer.WritePropertyName("needLoopForValidMessages"u8);
            writer.WriteBooleanValue(NeedLoopForValidMessages);
            writer.WritePropertyName("sendSynchronousAcknowledgement"u8);
            writer.WriteBooleanValue(SendSynchronousAcknowledgement);
            if (AcknowledgementControlNumberPrefix != null)
            {
                writer.WritePropertyName("acknowledgementControlNumberPrefix"u8);
                writer.WriteStringValue(AcknowledgementControlNumberPrefix);
            }
            if (AcknowledgementControlNumberSuffix != null)
            {
                writer.WritePropertyName("acknowledgementControlNumberSuffix"u8);
                writer.WriteStringValue(AcknowledgementControlNumberSuffix);
            }
            writer.WritePropertyName("acknowledgementControlNumberLowerBound"u8);
            writer.WriteNumberValue(AcknowledgementControlNumberLowerBound);
            writer.WritePropertyName("acknowledgementControlNumberUpperBound"u8);
            writer.WriteNumberValue(AcknowledgementControlNumberUpperBound);
            writer.WritePropertyName("rolloverAcknowledgementControlNumber"u8);
            writer.WriteBooleanValue(RolloverAcknowledgementControlNumber);
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

        EdifactAcknowledgementSettings IJsonModel<EdifactAcknowledgementSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactAcknowledgementSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdifactAcknowledgementSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdifactAcknowledgementSettings(document.RootElement, options);
        }

        internal static EdifactAcknowledgementSettings DeserializeEdifactAcknowledgementSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool needTechnicalAcknowledgement = default;
            bool batchTechnicalAcknowledgements = default;
            bool needFunctionalAcknowledgement = default;
            bool batchFunctionalAcknowledgements = default;
            bool needLoopForValidMessages = default;
            bool sendSynchronousAcknowledgement = default;
            Optional<string> acknowledgementControlNumberPrefix = default;
            Optional<string> acknowledgementControlNumberSuffix = default;
            int acknowledgementControlNumberLowerBound = default;
            int acknowledgementControlNumberUpperBound = default;
            bool rolloverAcknowledgementControlNumber = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("needTechnicalAcknowledgement"u8))
                {
                    needTechnicalAcknowledgement = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("batchTechnicalAcknowledgements"u8))
                {
                    batchTechnicalAcknowledgements = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("needFunctionalAcknowledgement"u8))
                {
                    needFunctionalAcknowledgement = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("batchFunctionalAcknowledgements"u8))
                {
                    batchFunctionalAcknowledgements = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("needLoopForValidMessages"u8))
                {
                    needLoopForValidMessages = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sendSynchronousAcknowledgement"u8))
                {
                    sendSynchronousAcknowledgement = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("acknowledgementControlNumberPrefix"u8))
                {
                    acknowledgementControlNumberPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acknowledgementControlNumberSuffix"u8))
                {
                    acknowledgementControlNumberSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acknowledgementControlNumberLowerBound"u8))
                {
                    acknowledgementControlNumberLowerBound = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("acknowledgementControlNumberUpperBound"u8))
                {
                    acknowledgementControlNumberUpperBound = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rolloverAcknowledgementControlNumber"u8))
                {
                    rolloverAcknowledgementControlNumber = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdifactAcknowledgementSettings(needTechnicalAcknowledgement, batchTechnicalAcknowledgements, needFunctionalAcknowledgement, batchFunctionalAcknowledgements, needLoopForValidMessages, sendSynchronousAcknowledgement, acknowledgementControlNumberPrefix.Value, acknowledgementControlNumberSuffix.Value, acknowledgementControlNumberLowerBound, acknowledgementControlNumberUpperBound, rolloverAcknowledgementControlNumber, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdifactAcknowledgementSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactAcknowledgementSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdifactAcknowledgementSettings)} does not support '{options.Format}' format.");
            }
        }

        EdifactAcknowledgementSettings IPersistableModel<EdifactAcknowledgementSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactAcknowledgementSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdifactAcknowledgementSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdifactAcknowledgementSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdifactAcknowledgementSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
