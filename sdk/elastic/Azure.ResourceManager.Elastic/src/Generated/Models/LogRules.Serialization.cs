// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Elastic.Models
{
    public partial class LogRules : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SendAadLogs))
            {
                writer.WritePropertyName("sendAadLogs"u8);
                writer.WriteBooleanValue(SendAadLogs.Value);
            }
            if (Optional.IsDefined(SendSubscriptionLogs))
            {
                writer.WritePropertyName("sendSubscriptionLogs"u8);
                writer.WriteBooleanValue(SendSubscriptionLogs.Value);
            }
            if (Optional.IsDefined(SendActivityLogs))
            {
                writer.WritePropertyName("sendActivityLogs"u8);
                writer.WriteBooleanValue(SendActivityLogs.Value);
            }
            if (Optional.IsCollectionDefined(FilteringTags))
            {
                writer.WritePropertyName("filteringTags"u8);
                writer.WriteStartArray();
                foreach (var item in FilteringTags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static LogRules DeserializeLogRules(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> sendAadLogs = default;
            Optional<bool> sendSubscriptionLogs = default;
            Optional<bool> sendActivityLogs = default;
            Optional<IList<FilteringTag>> filteringTags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sendAadLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendAadLogs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sendSubscriptionLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendSubscriptionLogs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sendActivityLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendActivityLogs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("filteringTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FilteringTag> array = new List<FilteringTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FilteringTag.DeserializeFilteringTag(item));
                    }
                    filteringTags = array;
                    continue;
                }
            }
            return new LogRules(Optional.ToNullable(sendAadLogs), Optional.ToNullable(sendSubscriptionLogs), Optional.ToNullable(sendActivityLogs), Optional.ToList(filteringTags));
        }
    }
}
