// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class SoftwareUpdateConfigurationTargetProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(AzureQueries))
            {
                writer.WritePropertyName("azureQueries"u8);
                writer.WriteStartArray();
                foreach (var item in AzureQueries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(NonAzureQueries))
            {
                writer.WritePropertyName("nonAzureQueries"u8);
                writer.WriteStartArray();
                foreach (var item in NonAzureQueries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SoftwareUpdateConfigurationTargetProperties DeserializeSoftwareUpdateConfigurationTargetProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IList<AzureQueryProperties>> azureQueries = default;
            Core.Optional<IList<NonAzureQueryProperties>> nonAzureQueries = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureQueries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureQueryProperties> array = new List<AzureQueryProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureQueryProperties.DeserializeAzureQueryProperties(item));
                    }
                    azureQueries = array;
                    continue;
                }
                if (property.NameEquals("nonAzureQueries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NonAzureQueryProperties> array = new List<NonAzureQueryProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NonAzureQueryProperties.DeserializeNonAzureQueryProperties(item));
                    }
                    nonAzureQueries = array;
                    continue;
                }
            }
            return new SoftwareUpdateConfigurationTargetProperties(Core.Optional.ToList(azureQueries), Core.Optional.ToList(nonAzureQueries));
        }
    }
}
