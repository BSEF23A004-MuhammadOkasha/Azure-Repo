// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AgentRegistrationKeys
    {
        internal static AgentRegistrationKeys DeserializeAgentRegistrationKeys(JsonElement element)
        {
            Optional<string> primary = default;
            Optional<string> secondary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primary"))
                {
                    primary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondary"))
                {
                    secondary = property.Value.GetString();
                    continue;
                }
            }
            return new AgentRegistrationKeys(primary.Value, secondary.Value);
        }
    }
}
