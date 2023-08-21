// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class PacketCoreControlPlaneCollectDiagnosticsPackage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("storageAccountBlobUrl"u8);
            writer.WriteStringValue(StorageAccountBlobUri.AbsoluteUri);
            writer.WriteEndObject();
        }
    }
}
