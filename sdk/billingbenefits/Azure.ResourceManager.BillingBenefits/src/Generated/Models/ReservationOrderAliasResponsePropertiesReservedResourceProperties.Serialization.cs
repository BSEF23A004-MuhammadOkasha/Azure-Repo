// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.BillingBenefits;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    internal partial class ReservationOrderAliasResponsePropertiesReservedResourceProperties : IUtf8JsonSerializable, IJsonModel<ReservationOrderAliasResponsePropertiesReservedResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationOrderAliasResponsePropertiesReservedResourceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReservationOrderAliasResponsePropertiesReservedResourceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationOrderAliasResponsePropertiesReservedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationOrderAliasResponsePropertiesReservedResourceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InstanceFlexibility))
            {
                writer.WritePropertyName("instanceFlexibility"u8);
                writer.WriteStringValue(InstanceFlexibility.Value.ToString());
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

        ReservationOrderAliasResponsePropertiesReservedResourceProperties IJsonModel<ReservationOrderAliasResponsePropertiesReservedResourceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationOrderAliasResponsePropertiesReservedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationOrderAliasResponsePropertiesReservedResourceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationOrderAliasResponsePropertiesReservedResourceProperties(document.RootElement, options);
        }

        internal static ReservationOrderAliasResponsePropertiesReservedResourceProperties DeserializeReservationOrderAliasResponsePropertiesReservedResourceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BillingBenefitsInstanceFlexibility? instanceFlexibility = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceFlexibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceFlexibility = new BillingBenefitsInstanceFlexibility(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReservationOrderAliasResponsePropertiesReservedResourceProperties(instanceFlexibility, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReservationOrderAliasResponsePropertiesReservedResourceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationOrderAliasResponsePropertiesReservedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReservationOrderAliasResponsePropertiesReservedResourceProperties)} does not support '{options.Format}' format.");
            }
        }

        ReservationOrderAliasResponsePropertiesReservedResourceProperties IPersistableModel<ReservationOrderAliasResponsePropertiesReservedResourceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationOrderAliasResponsePropertiesReservedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReservationOrderAliasResponsePropertiesReservedResourceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReservationOrderAliasResponsePropertiesReservedResourceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReservationOrderAliasResponsePropertiesReservedResourceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
