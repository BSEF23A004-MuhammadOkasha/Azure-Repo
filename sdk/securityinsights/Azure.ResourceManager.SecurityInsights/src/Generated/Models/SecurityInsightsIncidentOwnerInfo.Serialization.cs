// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsIncidentOwnerInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email"u8);
                writer.WriteStringValue(Email);
            }
            if (Optional.IsDefined(AssignedTo))
            {
                writer.WritePropertyName("assignedTo"u8);
                writer.WriteStringValue(AssignedTo);
            }
            if (Optional.IsDefined(ObjectId))
            {
                writer.WritePropertyName("objectId"u8);
                writer.WriteStringValue(ObjectId.Value);
            }
            if (Optional.IsDefined(UserPrincipalName))
            {
                writer.WritePropertyName("userPrincipalName"u8);
                writer.WriteStringValue(UserPrincipalName);
            }
            if (Optional.IsDefined(OwnerType))
            {
                writer.WritePropertyName("ownerType"u8);
                writer.WriteStringValue(OwnerType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static SecurityInsightsIncidentOwnerInfo DeserializeSecurityInsightsIncidentOwnerInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> email = default;
            Optional<string> assignedTo = default;
            Optional<Guid> objectId = default;
            Optional<string> userPrincipalName = default;
            Optional<SecurityInsightsIncidentOwnerType> ownerType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("email"u8))
                {
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assignedTo"u8))
                {
                    assignedTo = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    objectId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("userPrincipalName"u8))
                {
                    userPrincipalName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ownerType = new SecurityInsightsIncidentOwnerType(property.Value.GetString());
                    continue;
                }
            }
            return new SecurityInsightsIncidentOwnerInfo(email.Value, assignedTo.Value, Optional.ToNullable(objectId), userPrincipalName.Value, Optional.ToNullable(ownerType));
        }
    }
}
