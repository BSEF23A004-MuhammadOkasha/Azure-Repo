// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AzureOrbital.Models
{
    public partial class EndPoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ipAddress");
            writer.WriteStringValue(IpAddress);
            writer.WritePropertyName("endPointName");
            writer.WriteStringValue(EndPointName);
            writer.WritePropertyName("port");
            writer.WriteStringValue(Port);
            writer.WritePropertyName("protocol");
            writer.WriteStringValue(Protocol.ToString());
            writer.WriteEndObject();
        }

        internal static EndPoint DeserializeEndPoint(JsonElement element)
        {
            string ipAddress = default;
            string endPointName = default;
            string port = default;
            EndPointProtocol protocol = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddress"))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endPointName"))
                {
                    endPointName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"))
                {
                    port = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"))
                {
                    protocol = new EndPointProtocol(property.Value.GetString());
                    continue;
                }
            }
            return new EndPoint(ipAddress, endPointName, port, protocol);
        }
    }
}
