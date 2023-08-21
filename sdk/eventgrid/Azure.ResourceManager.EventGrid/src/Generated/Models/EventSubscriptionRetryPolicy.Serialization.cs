// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class EventSubscriptionRetryPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxDeliveryAttempts))
            {
                writer.WritePropertyName("maxDeliveryAttempts"u8);
                writer.WriteNumberValue(MaxDeliveryAttempts.Value);
            }
            if (Optional.IsDefined(EventTimeToLiveInMinutes))
            {
                writer.WritePropertyName("eventTimeToLiveInMinutes"u8);
                writer.WriteNumberValue(EventTimeToLiveInMinutes.Value);
            }
            writer.WriteEndObject();
        }

        internal static EventSubscriptionRetryPolicy DeserializeEventSubscriptionRetryPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> maxDeliveryAttempts = default;
            Optional<int> eventTimeToLiveInMinutes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxDeliveryAttempts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDeliveryAttempts = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("eventTimeToLiveInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventTimeToLiveInMinutes = property.Value.GetInt32();
                    continue;
                }
            }
            return new EventSubscriptionRetryPolicy(Optional.ToNullable(maxDeliveryAttempts), Optional.ToNullable(eventTimeToLiveInMinutes));
        }
    }
}
