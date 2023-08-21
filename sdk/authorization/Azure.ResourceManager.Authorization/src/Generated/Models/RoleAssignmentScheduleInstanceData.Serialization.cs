// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    public partial class RoleAssignmentScheduleInstanceData
    {
        internal static RoleAssignmentScheduleInstanceData DeserializeRoleAssignmentScheduleInstanceData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<string> scope = default;
            Core.Optional<ResourceIdentifier> roleDefinitionId = default;
            Core.Optional<Guid> principalId = default;
            Core.Optional<RoleManagementPrincipalType> principalType = default;
            Core.Optional<ResourceIdentifier> roleAssignmentScheduleId = default;
            Core.Optional<ResourceIdentifier> originRoleAssignmentId = default;
            Core.Optional<RoleManagementScheduleStatus> status = default;
            Core.Optional<DateTimeOffset> startDateTime = default;
            Core.Optional<DateTimeOffset> endDateTime = default;
            Core.Optional<ResourceIdentifier> linkedRoleEligibilityScheduleId = default;
            Core.Optional<ResourceIdentifier> linkedRoleEligibilityScheduleInstanceId = default;
            Core.Optional<RoleAssignmentScheduleAssignmentType> assignmentType = default;
            Core.Optional<RoleManagementScheduleMemberType> memberType = default;
            Core.Optional<string> condition = default;
            Core.Optional<string> conditionVersion = default;
            Core.Optional<DateTimeOffset> createdOn = default;
            Core.Optional<RoleManagementExpandedProperties> expandedProperties = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("scope"u8))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("roleDefinitionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            roleDefinitionId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("principalId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            principalId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("principalType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            principalType = new RoleManagementPrincipalType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("roleAssignmentScheduleId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            roleAssignmentScheduleId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("originRoleAssignmentId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            originRoleAssignmentId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new RoleManagementScheduleStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("linkedRoleEligibilityScheduleId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            linkedRoleEligibilityScheduleId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("linkedRoleEligibilityScheduleInstanceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            linkedRoleEligibilityScheduleInstanceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("assignmentType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            assignmentType = new RoleAssignmentScheduleAssignmentType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("memberType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            memberType = new RoleManagementScheduleMemberType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("condition"u8))
                        {
                            condition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("conditionVersion"u8))
                        {
                            conditionVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expandedProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expandedProperties = RoleManagementExpandedProperties.DeserializeRoleManagementExpandedProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RoleAssignmentScheduleInstanceData(id, name, type, systemData.Value, scope.Value, roleDefinitionId.Value, Core.Optional.ToNullable(principalId), Core.Optional.ToNullable(principalType), roleAssignmentScheduleId.Value, originRoleAssignmentId.Value, Core.Optional.ToNullable(status), Core.Optional.ToNullable(startDateTime), Core.Optional.ToNullable(endDateTime), linkedRoleEligibilityScheduleId.Value, linkedRoleEligibilityScheduleInstanceId.Value, Core.Optional.ToNullable(assignmentType), Core.Optional.ToNullable(memberType), condition.Value, conditionVersion.Value, Core.Optional.ToNullable(createdOn), expandedProperties.Value);
        }
    }
}
