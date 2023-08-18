// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseIPFirewallRuleProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(EndIPAddress))
            {
                writer.WritePropertyName("endIpAddress"u8);
                writer.WriteStringValue(EndIPAddress.ToString());
            }
            if (Core.Optional.IsDefined(StartIPAddress))
            {
                writer.WritePropertyName("startIpAddress"u8);
                writer.WriteStringValue(StartIPAddress.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
