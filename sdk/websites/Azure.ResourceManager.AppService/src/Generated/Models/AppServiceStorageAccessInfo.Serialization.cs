// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceStorageAccessInfo : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(StorageType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(StorageType.Value.ToSerialString());
            }
            if (Core.Optional.IsDefined(AccountName))
            {
                writer.WritePropertyName("accountName"u8);
                writer.WriteStringValue(AccountName);
            }
            if (Core.Optional.IsDefined(ShareName))
            {
                writer.WritePropertyName("shareName"u8);
                writer.WriteStringValue(ShareName);
            }
            if (Core.Optional.IsDefined(AccessKey))
            {
                writer.WritePropertyName("accessKey"u8);
                writer.WriteStringValue(AccessKey);
            }
            if (Core.Optional.IsDefined(MountPath))
            {
                writer.WritePropertyName("mountPath"u8);
                writer.WriteStringValue(MountPath);
            }
            writer.WriteEndObject();
        }

        internal static AppServiceStorageAccessInfo DeserializeAppServiceStorageAccessInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<AppServiceStorageType> type = default;
            Core.Optional<string> accountName = default;
            Core.Optional<string> shareName = default;
            Core.Optional<string> accessKey = default;
            Core.Optional<string> mountPath = default;
            Core.Optional<AppServiceStorageAccountState> state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToAppServiceStorageType();
                    continue;
                }
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shareName"u8))
                {
                    shareName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessKey"u8))
                {
                    accessKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountPath"u8))
                {
                    mountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = property.Value.GetString().ToAppServiceStorageAccountState();
                    continue;
                }
            }
            return new AppServiceStorageAccessInfo(Core.Optional.ToNullable(type), accountName.Value, shareName.Value, accessKey.Value, mountPath.Value, Core.Optional.ToNullable(state));
        }
    }
}
