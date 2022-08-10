// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchMountConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BlobFileSystemConfiguration))
            {
                writer.WritePropertyName("azureBlobFileSystemConfiguration");
                writer.WriteObjectValue(BlobFileSystemConfiguration);
            }
            if (Optional.IsDefined(NfsMountConfiguration))
            {
                writer.WritePropertyName("nfsMountConfiguration");
                writer.WriteObjectValue(NfsMountConfiguration);
            }
            if (Optional.IsDefined(CifsMountConfiguration))
            {
                writer.WritePropertyName("cifsMountConfiguration");
                writer.WriteObjectValue(CifsMountConfiguration);
            }
            if (Optional.IsDefined(FileShareConfiguration))
            {
                writer.WritePropertyName("azureFileShareConfiguration");
                writer.WriteObjectValue(FileShareConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static BatchMountConfiguration DeserializeBatchMountConfiguration(JsonElement element)
        {
            Optional<BatchBlobFileSystemConfiguration> azureBlobFileSystemConfiguration = default;
            Optional<BatchNfsMountConfiguration> nfsMountConfiguration = default;
            Optional<BatchCifsMountConfiguration> cifsMountConfiguration = default;
            Optional<BatchFileShareConfiguration> azureFileShareConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureBlobFileSystemConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureBlobFileSystemConfiguration = BatchBlobFileSystemConfiguration.DeserializeBatchBlobFileSystemConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("nfsMountConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nfsMountConfiguration = BatchNfsMountConfiguration.DeserializeBatchNfsMountConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("cifsMountConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cifsMountConfiguration = BatchCifsMountConfiguration.DeserializeBatchCifsMountConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("azureFileShareConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureFileShareConfiguration = BatchFileShareConfiguration.DeserializeBatchFileShareConfiguration(property.Value);
                    continue;
                }
            }
            return new BatchMountConfiguration(azureBlobFileSystemConfiguration.Value, nfsMountConfiguration.Value, cifsMountConfiguration.Value, azureFileShareConfiguration.Value);
        }
    }
}
