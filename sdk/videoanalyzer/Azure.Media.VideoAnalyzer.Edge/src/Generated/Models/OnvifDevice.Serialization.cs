// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class OnvifDevice : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Hostname))
            {
                writer.WritePropertyName("hostname"u8);
                writer.WriteObjectValue(Hostname);
            }
            if (Optional.IsDefined(SystemDateTime))
            {
                writer.WritePropertyName("systemDateTime"u8);
                writer.WriteObjectValue(SystemDateTime);
            }
            if (Optional.IsDefined(Dns))
            {
                writer.WritePropertyName("dns"u8);
                writer.WriteObjectValue(Dns);
            }
            if (Optional.IsCollectionDefined(MediaProfiles))
            {
                writer.WritePropertyName("mediaProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in MediaProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static OnvifDevice DeserializeOnvifDevice(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OnvifHostName> hostname = default;
            Optional<OnvifSystemDateTime> systemDateTime = default;
            Optional<OnvifDns> dns = default;
            Optional<IList<MediaProfile>> mediaProfiles = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostname"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostname = OnvifHostName.DeserializeOnvifHostName(property.Value);
                    continue;
                }
                if (property.NameEquals("systemDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemDateTime = OnvifSystemDateTime.DeserializeOnvifSystemDateTime(property.Value);
                    continue;
                }
                if (property.NameEquals("dns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dns = OnvifDns.DeserializeOnvifDns(property.Value);
                    continue;
                }
                if (property.NameEquals("mediaProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaProfile> array = new List<MediaProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaProfile.DeserializeMediaProfile(item));
                    }
                    mediaProfiles = array;
                    continue;
                }
            }
            return new OnvifDevice(hostname.Value, systemDateTime.Value, dns.Value, Optional.ToList(mediaProfiles));
        }
    }
}
