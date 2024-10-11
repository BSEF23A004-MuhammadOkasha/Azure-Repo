// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabEvaluatePolicy : IUtf8JsonSerializable, IJsonModel<DevTestLabEvaluatePolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabEvaluatePolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevTestLabEvaluatePolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabEvaluatePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabEvaluatePolicy)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(FactName))
            {
                writer.WritePropertyName("factName"u8);
                writer.WriteStringValue(FactName);
            }
            if (Optional.IsDefined(FactData))
            {
                writer.WritePropertyName("factData"u8);
                writer.WriteStringValue(FactData);
            }
            if (Optional.IsDefined(ValueOffset))
            {
                writer.WritePropertyName("valueOffset"u8);
                writer.WriteStringValue(ValueOffset);
            }
            if (Optional.IsDefined(UserObjectId))
            {
                writer.WritePropertyName("userObjectId"u8);
                writer.WriteStringValue(UserObjectId);
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
        }

        DevTestLabEvaluatePolicy IJsonModel<DevTestLabEvaluatePolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabEvaluatePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabEvaluatePolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabEvaluatePolicy(document.RootElement, options);
        }

        internal static DevTestLabEvaluatePolicy DeserializeDevTestLabEvaluatePolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string factName = default;
            string factData = default;
            string valueOffset = default;
            string userObjectId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("factName"u8))
                {
                    factName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("factData"u8))
                {
                    factData = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueOffset"u8))
                {
                    valueOffset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userObjectId"u8))
                {
                    userObjectId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevTestLabEvaluatePolicy(factName, factData, valueOffset, userObjectId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabEvaluatePolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabEvaluatePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabEvaluatePolicy)} does not support writing '{options.Format}' format.");
            }
        }

        DevTestLabEvaluatePolicy IPersistableModel<DevTestLabEvaluatePolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabEvaluatePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabEvaluatePolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabEvaluatePolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabEvaluatePolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
