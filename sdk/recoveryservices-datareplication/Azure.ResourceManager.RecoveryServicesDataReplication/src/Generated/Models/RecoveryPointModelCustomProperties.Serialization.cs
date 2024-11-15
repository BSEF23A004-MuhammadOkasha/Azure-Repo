// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    [PersistableModelProxy(typeof(UnknownRecoveryPointModelCustomProperties))]
    public partial class RecoveryPointModelCustomProperties : IUtf8JsonSerializable, IJsonModel<RecoveryPointModelCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPointModelCustomProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RecoveryPointModelCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPointModelCustomProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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
        }

        RecoveryPointModelCustomProperties IJsonModel<RecoveryPointModelCustomProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPointModelCustomProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPointModelCustomProperties(document.RootElement, options);
        }

        internal static RecoveryPointModelCustomProperties DeserializeRecoveryPointModelCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "HyperVToAzStackHCI": return HyperVToAzStackHciRecoveryPointModelCustomProperties.DeserializeHyperVToAzStackHciRecoveryPointModelCustomProperties(element, options);
                }
            }
            return UnknownRecoveryPointModelCustomProperties.DeserializeUnknownRecoveryPointModelCustomProperties(element, options);
        }

        BinaryData IPersistableModel<RecoveryPointModelCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryPointModelCustomProperties)} does not support writing '{options.Format}' format.");
            }
        }

        RecoveryPointModelCustomProperties IPersistableModel<RecoveryPointModelCustomProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryPointModelCustomProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryPointModelCustomProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryPointModelCustomProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
