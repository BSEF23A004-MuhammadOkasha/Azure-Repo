// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRouteServiceProviderBandwidthsOffered : IUtf8JsonSerializable, IJsonModel<ExpressRouteServiceProviderBandwidthsOffered>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRouteServiceProviderBandwidthsOffered>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExpressRouteServiceProviderBandwidthsOffered>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteServiceProviderBandwidthsOffered>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteServiceProviderBandwidthsOffered)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OfferName))
            {
                writer.WritePropertyName("offerName"u8);
                writer.WriteStringValue(OfferName);
            }
            if (Optional.IsDefined(ValueInMbps))
            {
                writer.WritePropertyName("valueInMbps"u8);
                writer.WriteNumberValue(ValueInMbps.Value);
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

        ExpressRouteServiceProviderBandwidthsOffered IJsonModel<ExpressRouteServiceProviderBandwidthsOffered>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteServiceProviderBandwidthsOffered>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteServiceProviderBandwidthsOffered)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteServiceProviderBandwidthsOffered(document.RootElement, options);
        }

        internal static ExpressRouteServiceProviderBandwidthsOffered DeserializeExpressRouteServiceProviderBandwidthsOffered(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string offerName = default;
            int? valueInMbps = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offerName"u8))
                {
                    offerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueInMbps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueInMbps = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExpressRouteServiceProviderBandwidthsOffered(offerName, valueInMbps, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExpressRouteServiceProviderBandwidthsOffered>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteServiceProviderBandwidthsOffered>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteServiceProviderBandwidthsOffered)} does not support '{options.Format}' format.");
            }
        }

        ExpressRouteServiceProviderBandwidthsOffered IPersistableModel<ExpressRouteServiceProviderBandwidthsOffered>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteServiceProviderBandwidthsOffered>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExpressRouteServiceProviderBandwidthsOffered(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteServiceProviderBandwidthsOffered)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpressRouteServiceProviderBandwidthsOffered>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
