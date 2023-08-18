// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class BlobNfsTarget : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Core.Optional.IsDefined(UsageModel))
            {
                writer.WritePropertyName("usageModel"u8);
                writer.WriteStringValue(UsageModel);
            }
            if (Core.Optional.IsDefined(VerificationDelayInSeconds))
            {
                writer.WritePropertyName("verificationTimer"u8);
                writer.WriteNumberValue(VerificationDelayInSeconds.Value);
            }
            if (Core.Optional.IsDefined(WriteBackDelayInSeconds))
            {
                writer.WritePropertyName("writeBackTimer"u8);
                writer.WriteNumberValue(WriteBackDelayInSeconds.Value);
            }
            writer.WriteEndObject();
        }

        internal static BlobNfsTarget DeserializeBlobNfsTarget(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ResourceIdentifier> target = default;
            Core.Optional<string> usageModel = default;
            Core.Optional<int> verificationTimer = default;
            Core.Optional<int> writeBackTimer = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("target"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    target = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("usageModel"u8))
                {
                    usageModel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("verificationTimer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    verificationTimer = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("writeBackTimer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBackTimer = property.Value.GetInt32();
                    continue;
                }
            }
            return new BlobNfsTarget(target.Value, usageModel.Value, Core.Optional.ToNullable(verificationTimer), Core.Optional.ToNullable(writeBackTimer));
        }
    }
}
