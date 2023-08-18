// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseGetSsisObjectMetadataContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(MetadataPath))
            {
                writer.WritePropertyName("metadataPath"u8);
                writer.WriteStringValue(MetadataPath);
            }
            writer.WriteEndObject();
        }
    }
}
