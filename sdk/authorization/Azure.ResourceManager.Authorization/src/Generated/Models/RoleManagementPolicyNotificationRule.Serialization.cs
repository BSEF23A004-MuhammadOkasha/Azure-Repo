// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleManagementPolicyNotificationRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NotificationDeliveryType))
            {
                writer.WritePropertyName("notificationType"u8);
                writer.WriteStringValue(NotificationDeliveryType.Value.ToString());
            }
            if (Optional.IsDefined(NotificationLevel))
            {
                writer.WritePropertyName("notificationLevel"u8);
                writer.WriteStringValue(NotificationLevel.Value.ToString());
            }
            if (Optional.IsDefined(RecipientType))
            {
                writer.WritePropertyName("recipientType"u8);
                writer.WriteStringValue(RecipientType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(NotificationRecipients))
            {
                writer.WritePropertyName("notificationRecipients"u8);
                writer.WriteStartArray();
                foreach (var item in NotificationRecipients)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AreDefaultRecipientsEnabled))
            {
                writer.WritePropertyName("isDefaultRecipientsEnabled"u8);
                writer.WriteBooleanValue(AreDefaultRecipientsEnabled.Value);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("ruleType"u8);
            writer.WriteStringValue(RuleType.ToString());
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteObjectValue(Target);
            }
            writer.WriteEndObject();
        }

        internal static RoleManagementPolicyNotificationRule DeserializeRoleManagementPolicyNotificationRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NotificationDeliveryType> notificationType = default;
            Optional<RoleManagementPolicyNotificationLevel> notificationLevel = default;
            Optional<RoleManagementPolicyRecipientType> recipientType = default;
            Optional<IList<string>> notificationRecipients = default;
            Optional<bool> isDefaultRecipientsEnabled = default;
            Optional<string> id = default;
            RoleManagementPolicyRuleType ruleType = default;
            Optional<RoleManagementPolicyRuleTarget> target = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notificationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notificationType = new NotificationDeliveryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("notificationLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notificationLevel = new RoleManagementPolicyNotificationLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recipientType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recipientType = new RoleManagementPolicyRecipientType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("notificationRecipients"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    notificationRecipients = array;
                    continue;
                }
                if (property.NameEquals("isDefaultRecipientsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefaultRecipientsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleType"u8))
                {
                    ruleType = new RoleManagementPolicyRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    target = RoleManagementPolicyRuleTarget.DeserializeRoleManagementPolicyRuleTarget(property.Value);
                    continue;
                }
            }
            return new RoleManagementPolicyNotificationRule(id.Value, ruleType, target.Value, Optional.ToNullable(notificationType), Optional.ToNullable(notificationLevel), Optional.ToNullable(recipientType), Optional.ToList(notificationRecipients), Optional.ToNullable(isDefaultRecipientsEnabled));
        }
    }
}
