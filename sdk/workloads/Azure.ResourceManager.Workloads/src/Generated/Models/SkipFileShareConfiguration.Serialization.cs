// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SkipFileShareConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("configurationType"u8);
            writer.WriteStringValue(ConfigurationType.ToString());
            writer.WriteEndObject();
        }

        internal static SkipFileShareConfiguration DeserializeSkipFileShareConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ConfigurationType configurationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configurationType"u8))
                {
                    configurationType = new ConfigurationType(property.Value.GetString());
                    continue;
                }
            }
            return new SkipFileShareConfiguration(configurationType);
        }
    }
}
