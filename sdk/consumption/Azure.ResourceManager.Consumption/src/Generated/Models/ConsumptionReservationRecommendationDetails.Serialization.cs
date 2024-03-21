// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionReservationRecommendationDetails : IUtf8JsonSerializable, IJsonModel<ConsumptionReservationRecommendationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionReservationRecommendationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConsumptionReservationRecommendationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionReservationRecommendationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionReservationRecommendationDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Currency))
            {
                writer.WritePropertyName("currency"u8);
                writer.WriteStringValue(Currency);
            }
            if (options.Format != "W" && Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("resource"u8);
                writer.WriteObjectValue(Properties);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceGroup))
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            if (options.Format != "W" && Optional.IsDefined(Savings))
            {
                writer.WritePropertyName("savings"u8);
                writer.WriteObjectValue(Savings);
            }
            if (options.Format != "W" && Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (options.Format != "W" && Optional.IsDefined(Usage))
            {
                writer.WritePropertyName("usage"u8);
                writer.WriteObjectValue(Usage);
            }
            writer.WriteEndObject();
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

        ConsumptionReservationRecommendationDetails IJsonModel<ConsumptionReservationRecommendationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionReservationRecommendationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionReservationRecommendationDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionReservationRecommendationDetails(document.RootElement, options);
        }

        internal static ConsumptionReservationRecommendationDetails DeserializeConsumptionReservationRecommendationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            string sku = default;
            ETag? etag = default;
            IReadOnlyDictionary<string, string> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string currency = default;
            ConsumptionResourceProperties resource = default;
            string resourceGroup = default;
            ConsumptionSavingsProperties savings = default;
            string scope = default;
            ConsumptionUsageProperties usage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("currency"u8))
                        {
                            currency = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resource = ConsumptionResourceProperties.DeserializeConsumptionResourceProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"u8))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("savings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            savings = ConsumptionSavingsProperties.DeserializeConsumptionSavingsProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("scope"u8))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("usage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usage = ConsumptionUsageProperties.DeserializeConsumptionUsageProperties(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConsumptionReservationRecommendationDetails(
                id,
                name,
                type,
                systemData,
                location,
                sku,
                currency,
                resource,
                resourceGroup,
                savings,
                scope,
                usage,
                etag,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConsumptionReservationRecommendationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionReservationRecommendationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionReservationRecommendationDetails)} does not support writing '{options.Format}' format.");
            }
        }

        ConsumptionReservationRecommendationDetails IPersistableModel<ConsumptionReservationRecommendationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionReservationRecommendationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsumptionReservationRecommendationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConsumptionReservationRecommendationDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionReservationRecommendationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
