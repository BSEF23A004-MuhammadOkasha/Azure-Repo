// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class StorageSyncServerEndpointPatch : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(CloudTiering))
            {
                writer.WritePropertyName("cloudTiering"u8);
                writer.WriteStringValue(CloudTiering.Value.ToString());
            }
            if (Core.Optional.IsDefined(VolumeFreeSpacePercent))
            {
                writer.WritePropertyName("volumeFreeSpacePercent"u8);
                writer.WriteNumberValue(VolumeFreeSpacePercent.Value);
            }
            if (Core.Optional.IsDefined(TierFilesOlderThanDays))
            {
                writer.WritePropertyName("tierFilesOlderThanDays"u8);
                writer.WriteNumberValue(TierFilesOlderThanDays.Value);
            }
            if (Core.Optional.IsDefined(OfflineDataTransfer))
            {
                writer.WritePropertyName("offlineDataTransfer"u8);
                writer.WriteStringValue(OfflineDataTransfer.Value.ToString());
            }
            if (Core.Optional.IsDefined(OfflineDataTransferShareName))
            {
                writer.WritePropertyName("offlineDataTransferShareName"u8);
                writer.WriteStringValue(OfflineDataTransferShareName);
            }
            if (Core.Optional.IsDefined(LocalCacheMode))
            {
                writer.WritePropertyName("localCacheMode"u8);
                writer.WriteStringValue(LocalCacheMode.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
