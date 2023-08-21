// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppCustomPersistentDiskProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(UnderlyingResourceType.ToString());
            writer.WritePropertyName("mountPath"u8);
            writer.WriteStringValue(MountPath);
            if (Core.Optional.IsDefined(IsReadOnly))
            {
                writer.WritePropertyName("readOnly"u8);
                writer.WriteBooleanValue(IsReadOnly.Value);
            }
            if (Core.Optional.IsCollectionDefined(MountOptions))
            {
                writer.WritePropertyName("mountOptions"u8);
                writer.WriteStartArray();
                foreach (var item in MountOptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AppCustomPersistentDiskProperties DeserializeAppCustomPersistentDiskProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureFileVolume": return AppPlatformAzureFileVolume.DeserializeAppPlatformAzureFileVolume(element);
                }
            }
            return UnknownCustomPersistentDiskProperties.DeserializeUnknownCustomPersistentDiskProperties(element);
        }
    }
}
