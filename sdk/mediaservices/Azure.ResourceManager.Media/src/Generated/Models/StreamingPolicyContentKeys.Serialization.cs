// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class StreamingPolicyContentKeys : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultKey))
            {
                writer.WritePropertyName("defaultKey");
                writer.WriteObjectValue(DefaultKey);
            }
            if (Optional.IsCollectionDefined(KeyToTrackMappings))
            {
                writer.WritePropertyName("keyToTrackMappings");
                writer.WriteStartArray();
                foreach (var item in KeyToTrackMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static StreamingPolicyContentKeys DeserializeStreamingPolicyContentKeys(JsonElement element)
        {
            Optional<EncryptionSchemeDefaultKey> defaultKey = default;
            Optional<IList<StreamingPolicyContentKey>> keyToTrackMappings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    defaultKey = EncryptionSchemeDefaultKey.DeserializeEncryptionSchemeDefaultKey(property.Value);
                    continue;
                }
                if (property.NameEquals("keyToTrackMappings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<StreamingPolicyContentKey> array = new List<StreamingPolicyContentKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StreamingPolicyContentKey.DeserializeStreamingPolicyContentKey(item));
                    }
                    keyToTrackMappings = array;
                    continue;
                }
            }
            return new StreamingPolicyContentKeys(defaultKey.Value, Optional.ToList(keyToTrackMappings));
        }
    }
}
