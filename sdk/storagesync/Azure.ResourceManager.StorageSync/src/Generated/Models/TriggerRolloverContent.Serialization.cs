// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class TriggerRolloverContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ServerCertificate))
            {
                writer.WritePropertyName("serverCertificate");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ServerCertificate);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ServerCertificate.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }
    }
}
