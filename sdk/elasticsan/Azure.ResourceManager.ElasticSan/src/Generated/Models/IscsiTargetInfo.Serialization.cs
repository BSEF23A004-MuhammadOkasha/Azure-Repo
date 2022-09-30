// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    public partial class IscsiTargetInfo
    {
        internal static IscsiTargetInfo DeserializeIscsiTargetInfo(JsonElement element)
        {
            Optional<string> targetIqn = default;
            Optional<string> targetPortalHostname = default;
            Optional<int> targetPortalPort = default;
            Optional<ElasticSanProvisioningState> provisioningState = default;
            Optional<ResourceOperationalStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetIqn"))
                {
                    targetIqn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetPortalHostname"))
                {
                    targetPortalHostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetPortalPort"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetPortalPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ElasticSanProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new ResourceOperationalStatus(property.Value.GetString());
                    continue;
                }
            }
            return new IscsiTargetInfo(targetIqn.Value, targetPortalHostname.Value, Optional.ToNullable(targetPortalPort), Optional.ToNullable(provisioningState), Optional.ToNullable(status));
        }
    }
}
