// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ConfigurationSaveContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Branch))
            {
                writer.WritePropertyName("branch"u8);
                writer.WriteStringValue(Branch);
            }
            if (Core.Optional.IsDefined(ForceUpdate))
            {
                writer.WritePropertyName("force"u8);
                writer.WriteBooleanValue(ForceUpdate.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
