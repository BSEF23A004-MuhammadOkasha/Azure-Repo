// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Storage.Common;

namespace Azure.Storage.Files.DataLake.Models
{
    internal partial class Path
    {
        internal static Path DeserializePath(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            DateTimeOffset? lastModified = default;
            string owner = default;
            string group = default;
            string permissions = default;
            string encryptionScope = default;
            string creationTime = default;
            string expiryTime = default;
            string encryptionContext = default;
            string contentLength = default;
            string isDirectory = default;
            string etag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastModified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModified = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (property.NameEquals("owner"u8))
                {
                    owner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("group"u8))
                {
                    group = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("permissions"u8))
                {
                    permissions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("EncryptionScope"u8))
                {
                    encryptionScope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    creationTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiryTime"u8))
                {
                    expiryTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("EncryptionContext"u8))
                {
                    encryptionContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentLength"u8))
                {
                    contentLength = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDirectory"u8))
                {
                    isDirectory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
            }
            return new Path(
                name,
                lastModified,
                owner,
                group,
                permissions,
                encryptionScope,
                creationTime,
                expiryTime,
                encryptionContext,
                contentLength,
                isDirectory,
                etag);
        }
    }
}
