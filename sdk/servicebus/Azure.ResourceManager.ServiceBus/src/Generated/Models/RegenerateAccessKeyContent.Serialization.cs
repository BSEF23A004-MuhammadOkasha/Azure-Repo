// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceBus.Models
{
    public partial class RegenerateAccessKeyContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyType");
            writer.WriteStringValue(KeyType.ToSerialString());
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key");
                writer.WriteStringValue(Key);
            }
            writer.WriteEndObject();
        }
    }
}
