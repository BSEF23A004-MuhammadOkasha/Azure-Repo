// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class RollingUpgradeMonitoringPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("failureAction"u8);
            writer.WriteStringValue(FailureAction.ToString());
            writer.WritePropertyName("healthCheckWaitDuration"u8);
            writer.WriteStringValue(HealthCheckWaitDuration, "c");
            writer.WritePropertyName("healthCheckStableDuration"u8);
            writer.WriteStringValue(HealthCheckStableDuration, "c");
            writer.WritePropertyName("healthCheckRetryTimeout"u8);
            writer.WriteStringValue(HealthCheckRetryTimeout, "c");
            writer.WritePropertyName("upgradeTimeout"u8);
            writer.WriteStringValue(UpgradeTimeout, "c");
            writer.WritePropertyName("upgradeDomainTimeout"u8);
            writer.WriteStringValue(UpgradeDomainTimeout, "c");
            writer.WriteEndObject();
        }

        internal static RollingUpgradeMonitoringPolicy DeserializeRollingUpgradeMonitoringPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PolicyViolationCompensationAction failureAction = default;
            TimeSpan healthCheckWaitDuration = default;
            TimeSpan healthCheckStableDuration = default;
            TimeSpan healthCheckRetryTimeout = default;
            TimeSpan upgradeTimeout = default;
            TimeSpan upgradeDomainTimeout = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failureAction"u8))
                {
                    failureAction = new PolicyViolationCompensationAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthCheckWaitDuration"u8))
                {
                    healthCheckWaitDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthCheckStableDuration"u8))
                {
                    healthCheckStableDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthCheckRetryTimeout"u8))
                {
                    healthCheckRetryTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("upgradeTimeout"u8))
                {
                    upgradeTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("upgradeDomainTimeout"u8))
                {
                    upgradeDomainTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
            }
            return new RollingUpgradeMonitoringPolicy(failureAction, healthCheckWaitDuration, healthCheckStableDuration, healthCheckRetryTimeout, upgradeTimeout, upgradeDomainTimeout);
        }
    }
}
