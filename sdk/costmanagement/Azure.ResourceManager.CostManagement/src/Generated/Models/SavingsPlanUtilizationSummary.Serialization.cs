// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CostManagement;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class SavingsPlanUtilizationSummary : IUtf8JsonSerializable, IJsonModel<SavingsPlanUtilizationSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SavingsPlanUtilizationSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SavingsPlanUtilizationSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanUtilizationSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SavingsPlanUtilizationSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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
            if (options.Format != "W" && Optional.IsDefined(ArmSkuName))
            {
                writer.WritePropertyName("armSkuName"u8);
                writer.WriteStringValue(ArmSkuName);
            }
            if (options.Format != "W" && Optional.IsDefined(BenefitId))
            {
                writer.WritePropertyName("benefitId"u8);
                writer.WriteStringValue(BenefitId);
            }
            if (options.Format != "W" && Optional.IsDefined(BenefitOrderId))
            {
                writer.WritePropertyName("benefitOrderId"u8);
                writer.WriteStringValue(BenefitOrderId);
            }
            if (Optional.IsDefined(BenefitType))
            {
                writer.WritePropertyName("benefitType"u8);
                writer.WriteStringValue(BenefitType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(UsageOn))
            {
                writer.WritePropertyName("usageDate"u8);
                writer.WriteStringValue(UsageOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(AvgUtilizationPercentage))
            {
                writer.WritePropertyName("avgUtilizationPercentage"u8);
                writer.WriteNumberValue(AvgUtilizationPercentage.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MinUtilizationPercentage))
            {
                writer.WritePropertyName("minUtilizationPercentage"u8);
                writer.WriteNumberValue(MinUtilizationPercentage.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxUtilizationPercentage))
            {
                writer.WritePropertyName("maxUtilizationPercentage"u8);
                writer.WriteNumberValue(MaxUtilizationPercentage.Value);
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

        SavingsPlanUtilizationSummary IJsonModel<SavingsPlanUtilizationSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanUtilizationSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SavingsPlanUtilizationSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSavingsPlanUtilizationSummary(document.RootElement, options);
        }

        internal static SavingsPlanUtilizationSummary DeserializeSavingsPlanUtilizationSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BillingAccountBenefitKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string armSkuName = default;
            string benefitId = default;
            string benefitOrderId = default;
            BillingAccountBenefitKind? benefitType = default;
            DateTimeOffset? usageDate = default;
            decimal? avgUtilizationPercentage = default;
            decimal? minUtilizationPercentage = default;
            decimal? maxUtilizationPercentage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new BillingAccountBenefitKind(property.Value.GetString());
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
                        if (property0.NameEquals("armSkuName"u8))
                        {
                            armSkuName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("benefitId"u8))
                        {
                            benefitId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("benefitOrderId"u8))
                        {
                            benefitOrderId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("benefitType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            benefitType = new BillingAccountBenefitKind(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("usageDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usageDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("avgUtilizationPercentage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            avgUtilizationPercentage = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("minUtilizationPercentage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minUtilizationPercentage = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("maxUtilizationPercentage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxUtilizationPercentage = property0.Value.GetDecimal();
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
            return new SavingsPlanUtilizationSummary(
                id,
                name,
                type,
                systemData,
                kind,
                serializedAdditionalRawData,
                armSkuName,
                benefitId,
                benefitOrderId,
                benefitType,
                usageDate,
                avgUtilizationPercentage,
                minUtilizationPercentage,
                maxUtilizationPercentage);
        }

        BinaryData IPersistableModel<SavingsPlanUtilizationSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanUtilizationSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SavingsPlanUtilizationSummary)} does not support '{options.Format}' format.");
            }
        }

        SavingsPlanUtilizationSummary IPersistableModel<SavingsPlanUtilizationSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanUtilizationSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSavingsPlanUtilizationSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SavingsPlanUtilizationSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SavingsPlanUtilizationSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
