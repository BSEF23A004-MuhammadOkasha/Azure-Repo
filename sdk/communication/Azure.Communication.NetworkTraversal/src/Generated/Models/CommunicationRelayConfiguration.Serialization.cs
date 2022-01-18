// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Communication.NetworkTraversal
{
    [JsonConverter(typeof(CommunicationRelayConfigurationConverter))]
    public partial class CommunicationRelayConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ExpiresOn != null)
            {
                writer.WritePropertyName("expiresOn");
                writer.WriteStringValue(ExpiresOn.Value, "O");
            }
            else
            {
                writer.WriteNull("expiresOn");
            }
            writer.WritePropertyName("iceServers");
            writer.WriteStartArray();
            foreach (var item in IceServers)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static CommunicationRelayConfiguration DeserializeCommunicationRelayConfiguration(JsonElement element)
        {
            DateTimeOffset? expiresOn = default;
            IList<CommunicationIceServer> iceServers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expiresOn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        expiresOn = null;
                        continue;
                    }
                    expiresOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("iceServers"))
                {
                    List<CommunicationIceServer> array = new List<CommunicationIceServer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommunicationIceServer.DeserializeCommunicationIceServer(item));
                    }
                    iceServers = array;
                    continue;
                }
            }
            return new CommunicationRelayConfiguration(expiresOn, iceServers);
        }

        internal partial class CommunicationRelayConfigurationConverter : JsonConverter<CommunicationRelayConfiguration>
        {
            public override void Write(Utf8JsonWriter writer, CommunicationRelayConfiguration model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override CommunicationRelayConfiguration Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCommunicationRelayConfiguration(document.RootElement);
            }
        }
    }
}
