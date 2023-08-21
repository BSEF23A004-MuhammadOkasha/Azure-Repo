// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class SelectAudioTrackById : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("trackId"u8);
            writer.WriteNumberValue(TrackId);
            if (Optional.IsDefined(ChannelMapping))
            {
                writer.WritePropertyName("channelMapping"u8);
                writer.WriteStringValue(ChannelMapping.Value.ToString());
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            writer.WriteEndObject();
        }

        internal static SelectAudioTrackById DeserializeSelectAudioTrackById(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long trackId = default;
            Optional<ChannelMapping> channelMapping = default;
            string odataType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trackId"u8))
                {
                    trackId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("channelMapping"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    channelMapping = new ChannelMapping(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
            }
            return new SelectAudioTrackById(odataType, Optional.ToNullable(channelMapping), trackId);
        }
    }
}
