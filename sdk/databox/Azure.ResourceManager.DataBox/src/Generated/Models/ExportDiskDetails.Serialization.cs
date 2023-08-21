// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class ExportDiskDetails
    {
        internal static ExportDiskDetails DeserializeExportDiskDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> manifestFile = default;
            Optional<string> manifestHash = default;
            Optional<string> backupManifestCloudPath = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("manifestFile"u8))
                {
                    manifestFile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manifestHash"u8))
                {
                    manifestHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManifestCloudPath"u8))
                {
                    backupManifestCloudPath = property.Value.GetString();
                    continue;
                }
            }
            return new ExportDiskDetails(manifestFile.Value, manifestHash.Value, backupManifestCloudPath.Value);
        }
    }
}
