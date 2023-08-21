// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    public partial class VaultMonitoringSummary
    {
        internal static VaultMonitoringSummary DeserializeVaultMonitoringSummary(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> unHealthyVmCount = default;
            Optional<int> unHealthyProviderCount = default;
            Optional<int> eventsCount = default;
            Optional<int> deprecatedProviderCount = default;
            Optional<int> supportedProviderCount = default;
            Optional<int> unsupportedProviderCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("unHealthyVmCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unHealthyVmCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unHealthyProviderCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unHealthyProviderCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("eventsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deprecatedProviderCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deprecatedProviderCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("supportedProviderCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedProviderCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unsupportedProviderCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unsupportedProviderCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new VaultMonitoringSummary(Optional.ToNullable(unHealthyVmCount), Optional.ToNullable(unHealthyProviderCount), Optional.ToNullable(eventsCount), Optional.ToNullable(deprecatedProviderCount), Optional.ToNullable(supportedProviderCount), Optional.ToNullable(unsupportedProviderCount));
        }
    }
}
