// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    internal partial class UpdateKeyVaultMetaInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EncryptionKeyVersion))
            {
                writer.WritePropertyName("encryptionKeyVersion"u8);
                writer.WriteStringValue(EncryptionKeyVersion);
            }
            writer.WriteEndObject();
        }
    }
}
