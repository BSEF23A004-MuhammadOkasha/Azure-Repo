// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class ServiceAlertEssentials : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(TargetResource))
            {
                writer.WritePropertyName("targetResource"u8);
                writer.WriteStringValue(TargetResource);
            }
            if (Core.Optional.IsDefined(TargetResourceName))
            {
                writer.WritePropertyName("targetResourceName"u8);
                writer.WriteStringValue(TargetResourceName);
            }
            if (Core.Optional.IsDefined(TargetResourceGroup))
            {
                writer.WritePropertyName("targetResourceGroup"u8);
                writer.WriteStringValue(TargetResourceGroup);
            }
            if (Core.Optional.IsDefined(TargetResourceType))
            {
                writer.WritePropertyName("targetResourceType"u8);
                writer.WriteStringValue(TargetResourceType);
            }
            if (Core.Optional.IsDefined(ActionStatus))
            {
                writer.WritePropertyName("actionStatus"u8);
                writer.WriteObjectValue(ActionStatus);
            }
            if (Core.Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static ServiceAlertEssentials DeserializeServiceAlertEssentials(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ServiceAlertSeverity> severity = default;
            Core.Optional<ServiceAlertSignalType> signalType = default;
            Core.Optional<ServiceAlertState> alertState = default;
            Core.Optional<MonitorCondition> monitorCondition = default;
            Core.Optional<string> targetResource = default;
            Core.Optional<string> targetResourceName = default;
            Core.Optional<string> targetResourceGroup = default;
            Core.Optional<string> targetResourceType = default;
            Core.Optional<MonitorServiceSourceForAlert> monitorService = default;
            Core.Optional<string> alertRule = default;
            Core.Optional<string> sourceCreatedId = default;
            Core.Optional<Guid> smartGroupId = default;
            Core.Optional<string> smartGroupingReason = default;
            Core.Optional<DateTimeOffset> startDateTime = default;
            Core.Optional<DateTimeOffset> lastModifiedDateTime = default;
            Core.Optional<DateTimeOffset> monitorConditionResolvedDateTime = default;
            Core.Optional<string> lastModifiedUserName = default;
            Core.Optional<ServiceAlertActionStatus> actionStatus = default;
            Core.Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = new ServiceAlertSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("signalType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    signalType = new ServiceAlertSignalType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("alertState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alertState = new ServiceAlertState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("monitorCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitorCondition = new MonitorCondition(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetResource"u8))
                {
                    targetResource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"u8))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroup"u8))
                {
                    targetResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceType"u8))
                {
                    targetResourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("monitorService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitorService = new MonitorServiceSourceForAlert(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("alertRule"u8))
                {
                    alertRule = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceCreatedId"u8))
                {
                    sourceCreatedId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("smartGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    smartGroupId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("smartGroupingReason"u8))
                {
                    smartGroupingReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("monitorConditionResolvedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitorConditionResolvedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedUserName"u8))
                {
                    lastModifiedUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionStatus = ServiceAlertActionStatus.DeserializeServiceAlertActionStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new ServiceAlertEssentials(Core.Optional.ToNullable(severity), Core.Optional.ToNullable(signalType), Core.Optional.ToNullable(alertState), Core.Optional.ToNullable(monitorCondition), targetResource.Value, targetResourceName.Value, targetResourceGroup.Value, targetResourceType.Value, Core.Optional.ToNullable(monitorService), alertRule.Value, sourceCreatedId.Value, Core.Optional.ToNullable(smartGroupId), smartGroupingReason.Value, Core.Optional.ToNullable(startDateTime), Core.Optional.ToNullable(lastModifiedDateTime), Core.Optional.ToNullable(monitorConditionResolvedDateTime), lastModifiedUserName.Value, actionStatus.Value, description.Value);
        }
    }
}
