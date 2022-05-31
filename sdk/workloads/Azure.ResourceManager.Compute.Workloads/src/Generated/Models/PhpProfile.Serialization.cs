// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    internal partial class PhpProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("version");
            writer.WriteStringValue(Version.ToString());
            writer.WriteEndObject();
        }

        internal static PhpProfile DeserializePhpProfile(JsonElement element)
        {
            PHPVersion version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("version"))
                {
                    version = new PHPVersion(property.Value.GetString());
                    continue;
                }
            }
            return new PhpProfile(version);
        }
    }
}
