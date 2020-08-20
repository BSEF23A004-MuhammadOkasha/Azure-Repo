// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class SecurityGroupNetworkInterface
    {
        internal static SecurityGroupNetworkInterface DeserializeSecurityGroupNetworkInterface(JsonElement element)
        {
            Optional<string> id = default;
            Optional<SecurityRuleAssociations> securityRuleAssociations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("securityRuleAssociations"))
                {
                    securityRuleAssociations = SecurityRuleAssociations.DeserializeSecurityRuleAssociations(property.Value);
                    continue;
                }
            }
            return new SecurityGroupNetworkInterface(id.Value, securityRuleAssociations.Value);
        }
    }
}
