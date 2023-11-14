// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class FirewallBillingPlanInfo : IUtf8JsonSerializable, IJsonModel<FirewallBillingPlanInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallBillingPlanInfo>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<FirewallBillingPlanInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<FirewallBillingPlanInfo>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<FirewallBillingPlanInfo>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(UsageType))
            {
                writer.WritePropertyName("usageType"u8);
                writer.WriteStringValue(UsageType.Value.ToString());
            }
            writer.WritePropertyName("billingCycle"u8);
            writer.WriteStringValue(BillingCycle.ToString());
            writer.WritePropertyName("planId"u8);
            writer.WriteStringValue(PlanId);
            if (options.Format == "J")
            {
                if (Optional.IsDefined(EffectiveOn))
                {
                    writer.WritePropertyName("effectiveDate"u8);
                    writer.WriteStringValue(EffectiveOn.Value, "O");
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        FirewallBillingPlanInfo IJsonModel<FirewallBillingPlanInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirewallBillingPlanInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallBillingPlanInfo(document.RootElement, options);
        }

        internal static FirewallBillingPlanInfo DeserializeFirewallBillingPlanInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<FirewallBillingPlanUsageType> usageType = default;
            FirewallBillingCycle billingCycle = default;
            string planId = default;
            Optional<DateTimeOffset> effectiveDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("usageType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usageType = new FirewallBillingPlanUsageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingCycle"u8))
                {
                    billingCycle = new FirewallBillingCycle(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("planId"u8))
                {
                    planId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("effectiveDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    effectiveDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirewallBillingPlanInfo(Optional.ToNullable(usageType), billingCycle, planId, Optional.ToNullable(effectiveDate), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallBillingPlanInfo>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirewallBillingPlanInfo)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        FirewallBillingPlanInfo IPersistableModel<FirewallBillingPlanInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FirewallBillingPlanInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFirewallBillingPlanInfo(document.RootElement, options);
        }

        string IPersistableModel<FirewallBillingPlanInfo>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
