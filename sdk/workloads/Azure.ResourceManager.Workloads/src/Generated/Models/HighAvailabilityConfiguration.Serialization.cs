// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    internal partial class HighAvailabilityConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("highAvailabilityType"u8);
            writer.WriteStringValue(HighAvailabilityType.ToString());
            writer.WriteEndObject();
        }

        internal static HighAvailabilityConfiguration DeserializeHighAvailabilityConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SapHighAvailabilityType highAvailabilityType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("highAvailabilityType"u8))
                {
                    highAvailabilityType = new SapHighAvailabilityType(property.Value.GetString());
                    continue;
                }
            }
            return new HighAvailabilityConfiguration(highAvailabilityType);
        }
    }
}
