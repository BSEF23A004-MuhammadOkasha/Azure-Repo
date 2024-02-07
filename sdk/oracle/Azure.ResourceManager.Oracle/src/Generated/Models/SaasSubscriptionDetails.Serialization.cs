// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Oracle.Models
{
    public partial class SaasSubscriptionDetails : IUtf8JsonSerializable, IJsonModel<SaasSubscriptionDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SaasSubscriptionDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SaasSubscriptionDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SaasSubscriptionDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SaasSubscriptionDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(SubscriptionName))
            {
                writer.WritePropertyName("subscriptionName"u8);
                writer.WriteStringValue(SubscriptionName);
            }
            if (options.Format != "W" && Optional.IsDefined(TimeCreated))
            {
                writer.WritePropertyName("timeCreated"u8);
                writer.WriteStringValue(TimeCreated.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(OfferId))
            {
                writer.WritePropertyName("offerId"u8);
                writer.WriteStringValue(OfferId);
            }
            if (options.Format != "W" && Optional.IsDefined(PlanId))
            {
                writer.WritePropertyName("planId"u8);
                writer.WriteStringValue(PlanId);
            }
            if (options.Format != "W" && Optional.IsDefined(SaasSubscriptionStatus))
            {
                writer.WritePropertyName("saasSubscriptionStatus"u8);
                writer.WriteStringValue(SaasSubscriptionStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(PublisherId))
            {
                writer.WritePropertyName("publisherId"u8);
                writer.WriteStringValue(PublisherId);
            }
            if (options.Format != "W" && Optional.IsDefined(PurchaserEmailId))
            {
                writer.WritePropertyName("purchaserEmailId"u8);
                writer.WriteStringValue(PurchaserEmailId);
            }
            if (options.Format != "W" && Optional.IsDefined(PurchaserTenantId))
            {
                writer.WritePropertyName("purchaserTenantId"u8);
                writer.WriteStringValue(PurchaserTenantId);
            }
            if (options.Format != "W" && Optional.IsDefined(TermUnit))
            {
                writer.WritePropertyName("termUnit"u8);
                writer.WriteStringValue(TermUnit);
            }
            if (options.Format != "W" && Optional.IsDefined(IsAutoRenew))
            {
                writer.WritePropertyName("isAutoRenew"u8);
                writer.WriteBooleanValue(IsAutoRenew.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsFreeTrial))
            {
                writer.WritePropertyName("isFreeTrial"u8);
                writer.WriteBooleanValue(IsFreeTrial.Value);
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

        SaasSubscriptionDetails IJsonModel<SaasSubscriptionDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SaasSubscriptionDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SaasSubscriptionDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSaasSubscriptionDetails(document.RootElement, options);
        }

        internal static SaasSubscriptionDetails DeserializeSaasSubscriptionDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> subscriptionName = default;
            Optional<DateTimeOffset> timeCreated = default;
            Optional<string> offerId = default;
            Optional<string> planId = default;
            Optional<string> saasSubscriptionStatus = default;
            Optional<string> publisherId = default;
            Optional<string> purchaserEmailId = default;
            Optional<string> purchaserTenantId = default;
            Optional<string> termUnit = default;
            Optional<bool> isAutoRenew = default;
            Optional<bool> isFreeTrial = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionName"u8))
                {
                    subscriptionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeCreated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeCreated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("offerId"u8))
                {
                    offerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planId"u8))
                {
                    planId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("saasSubscriptionStatus"u8))
                {
                    saasSubscriptionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherId"u8))
                {
                    publisherId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("purchaserEmailId"u8))
                {
                    purchaserEmailId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("purchaserTenantId"u8))
                {
                    purchaserTenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("termUnit"u8))
                {
                    termUnit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAutoRenew"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoRenew = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isFreeTrial"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isFreeTrial = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SaasSubscriptionDetails(id.Value, subscriptionName.Value, Optional.ToNullable(timeCreated), offerId.Value, planId.Value, saasSubscriptionStatus.Value, publisherId.Value, purchaserEmailId.Value, purchaserTenantId.Value, termUnit.Value, Optional.ToNullable(isAutoRenew), Optional.ToNullable(isFreeTrial), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SaasSubscriptionDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SaasSubscriptionDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SaasSubscriptionDetails)} does not support '{options.Format}' format.");
            }
        }

        SaasSubscriptionDetails IPersistableModel<SaasSubscriptionDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SaasSubscriptionDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSaasSubscriptionDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SaasSubscriptionDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SaasSubscriptionDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
