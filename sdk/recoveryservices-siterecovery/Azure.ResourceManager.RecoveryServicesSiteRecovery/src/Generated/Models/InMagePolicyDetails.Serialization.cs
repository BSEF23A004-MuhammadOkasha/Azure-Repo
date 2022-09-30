// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMagePolicyDetails
    {
        internal static InMagePolicyDetails DeserializeInMagePolicyDetails(JsonElement element)
        {
            Optional<int> recoveryPointThresholdInMinutes = default;
            Optional<int> recoveryPointHistory = default;
            Optional<int> appConsistentFrequencyInMinutes = default;
            Optional<string> multiVmSyncStatus = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointThresholdInMinutes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recoveryPointThresholdInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recoveryPointHistory"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recoveryPointHistory = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("appConsistentFrequencyInMinutes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    appConsistentFrequencyInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("multiVmSyncStatus"))
                {
                    multiVmSyncStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new InMagePolicyDetails(instanceType, Optional.ToNullable(recoveryPointThresholdInMinutes), Optional.ToNullable(recoveryPointHistory), Optional.ToNullable(appConsistentFrequencyInMinutes), multiVmSyncStatus.Value);
        }
    }
}
