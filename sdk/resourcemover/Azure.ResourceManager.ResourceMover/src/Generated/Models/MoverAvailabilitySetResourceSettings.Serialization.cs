// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverAvailabilitySetResourceSettings : IUtf8JsonSerializable
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
            if (Optional.IsDefined(FaultDomain))
            {
                if (FaultDomain != null)
                {
                    writer.WritePropertyName("faultDomain"u8);
                    writer.WriteNumberValue(FaultDomain.Value);
                }
                else
                {
                    writer.WriteNull("faultDomain");
                }
            }
            if (Optional.IsDefined(UpdateDomain))
            {
                if (UpdateDomain != null)
                {
                    writer.WritePropertyName("updateDomain"u8);
                    writer.WriteNumberValue(UpdateDomain.Value);
                }
                else
                {
                    writer.WriteNull("updateDomain");
                }
            }
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
            if (Optional.IsDefined(TargetResourceName))
            {
                writer.WritePropertyName("targetResourceName"u8);
                writer.WriteStringValue(TargetResourceName);
            }
            if (Optional.IsDefined(TargetResourceGroupName))
            {
                writer.WritePropertyName("targetResourceGroupName"u8);
                writer.WriteStringValue(TargetResourceGroupName);
            }
            writer.WriteEndObject();
        }

        internal static MoverAvailabilitySetResourceSettings DeserializeMoverAvailabilitySetResourceSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<int?> faultDomain = default;
            Optional<int?> updateDomain = default;
            string resourceType = default;
            Optional<string> targetResourceName = default;
            Optional<string> targetResourceGroupName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("faultDomain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        faultDomain = null;
                        continue;
                    }
                    faultDomain = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("updateDomain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        updateDomain = null;
                        continue;
                    }
                    updateDomain = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"u8))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroupName"u8))
                {
                    targetResourceGroupName = property.Value.GetString();
                    continue;
                }
            }
            return new MoverAvailabilitySetResourceSettings(resourceType, targetResourceName.Value, targetResourceGroupName.Value, Optional.ToDictionary(tags), Optional.ToNullable(faultDomain), Optional.ToNullable(updateDomain));
        }
    }
}
