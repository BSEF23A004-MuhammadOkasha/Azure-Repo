// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiVersionSetPatch : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Core.Optional.IsDefined(VersionQueryName))
            {
                writer.WritePropertyName("versionQueryName"u8);
                writer.WriteStringValue(VersionQueryName);
            }
            if (Core.Optional.IsDefined(VersionHeaderName))
            {
                writer.WritePropertyName("versionHeaderName"u8);
                writer.WriteStringValue(VersionHeaderName);
            }
            if (Core.Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Core.Optional.IsDefined(VersioningScheme))
            {
                writer.WritePropertyName("versioningScheme"u8);
                writer.WriteStringValue(VersioningScheme.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
