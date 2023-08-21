// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionMeterDetails
    {
        internal static ConsumptionMeterDetails DeserializeConsumptionMeterDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> meterName = default;
            Optional<string> meterCategory = default;
            Optional<string> meterSubCategory = default;
            Optional<string> unit = default;
            Optional<string> meterLocation = default;
            Optional<decimal> totalIncludedQuantity = default;
            Optional<decimal> pretaxStandardRate = default;
            Optional<string> serviceName = default;
            Optional<string> serviceTier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("meterName"u8))
                {
                    meterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("meterCategory"u8))
                {
                    meterCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("meterSubCategory"u8))
                {
                    meterSubCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("meterLocation"u8))
                {
                    meterLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalIncludedQuantity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalIncludedQuantity = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("pretaxStandardRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pretaxStandardRate = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("serviceName"u8))
                {
                    serviceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceTier"u8))
                {
                    serviceTier = property.Value.GetString();
                    continue;
                }
            }
            return new ConsumptionMeterDetails(meterName.Value, meterCategory.Value, meterSubCategory.Value, unit.Value, meterLocation.Value, Optional.ToNullable(totalIncludedQuantity), Optional.ToNullable(pretaxStandardRate), serviceName.Value, serviceTier.Value);
        }
    }
}
