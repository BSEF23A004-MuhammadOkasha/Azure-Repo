// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    public partial class RedisLinkedServerWithPropertyCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("linkedRedisCacheId");
            writer.WriteStringValue(LinkedRedisCacheId);
            writer.WritePropertyName("linkedRedisCacheLocation");
            writer.WriteStringValue(LinkedRedisCacheLocation);
            writer.WritePropertyName("serverRole");
            writer.WriteStringValue(ServerRole.ToSerialString());
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
