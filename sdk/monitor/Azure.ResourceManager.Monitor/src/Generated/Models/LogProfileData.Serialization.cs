// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    public partial class LogProfileData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountId))
            {
                if (StorageAccountId != null)
                {
                    writer.WritePropertyName("storageAccountId"u8);
                    writer.WriteStringValue(StorageAccountId);
                }
                else
                {
                    writer.WriteNull("storageAccountId");
                }
            }
            if (Optional.IsDefined(ServiceBusRuleId))
            {
                if (ServiceBusRuleId != null)
                {
                    writer.WritePropertyName("serviceBusRuleId"u8);
                    writer.WriteStringValue(ServiceBusRuleId);
                }
                else
                {
                    writer.WriteNull("serviceBusRuleId");
                }
            }
            writer.WritePropertyName("locations"u8);
            writer.WriteStartArray();
            foreach (var item in Locations)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("categories"u8);
            writer.WriteStartArray();
            foreach (var item in Categories)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("retentionPolicy"u8);
            writer.WriteObjectValue(RetentionPolicy);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
