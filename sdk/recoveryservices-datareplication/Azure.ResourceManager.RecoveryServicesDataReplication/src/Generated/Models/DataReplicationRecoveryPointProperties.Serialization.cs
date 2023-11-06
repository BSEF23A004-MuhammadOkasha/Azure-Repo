// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class DataReplicationRecoveryPointProperties
    {
        internal static DataReplicationRecoveryPointProperties DeserializeDataReplicationRecoveryPointProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset recoveryPointTime = default;
            DataReplicationRecoveryPointType recoveryPointType = default;
            RecoveryPointModelCustomProperties customProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointTime"u8))
                {
                    recoveryPointTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveryPointType"u8))
                {
                    recoveryPointType = new DataReplicationRecoveryPointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customProperties"u8))
                {
                    customProperties = RecoveryPointModelCustomProperties.DeserializeRecoveryPointModelCustomProperties(property.Value);
                    continue;
                }
            }
            return new DataReplicationRecoveryPointProperties(recoveryPointTime, recoveryPointType, customProperties);
        }
    }
}
