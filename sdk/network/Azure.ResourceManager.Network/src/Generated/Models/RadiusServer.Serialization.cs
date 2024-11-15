// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class RadiusServer : IUtf8JsonSerializable, IJsonModel<RadiusServer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RadiusServer>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RadiusServer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RadiusServer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RadiusServer)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("radiusServerAddress"u8);
            writer.WriteStringValue(RadiusServerAddress);
            if (Optional.IsDefined(RadiusServerScore))
            {
                writer.WritePropertyName("radiusServerScore"u8);
                writer.WriteNumberValue(RadiusServerScore.Value);
            }
            if (Optional.IsDefined(RadiusServerSecret))
            {
                writer.WritePropertyName("radiusServerSecret"u8);
                writer.WriteStringValue(RadiusServerSecret);
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

        RadiusServer IJsonModel<RadiusServer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RadiusServer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RadiusServer)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRadiusServer(document.RootElement, options);
        }

        internal static RadiusServer DeserializeRadiusServer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string radiusServerAddress = default;
            long? radiusServerScore = default;
            string radiusServerSecret = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("radiusServerAddress"u8))
                {
                    radiusServerAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("radiusServerScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    radiusServerScore = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("radiusServerSecret"u8))
                {
                    radiusServerSecret = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RadiusServer(radiusServerAddress, radiusServerScore, radiusServerSecret, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RadiusServer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RadiusServer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RadiusServer)} does not support writing '{options.Format}' format.");
            }
        }

        RadiusServer IPersistableModel<RadiusServer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RadiusServer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRadiusServer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RadiusServer)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RadiusServer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
