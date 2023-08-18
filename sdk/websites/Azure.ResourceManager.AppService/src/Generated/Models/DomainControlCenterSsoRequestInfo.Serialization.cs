// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DomainControlCenterSsoRequestInfo
    {
        internal static DomainControlCenterSsoRequestInfo DeserializeDomainControlCenterSsoRequestInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<Uri> url = default;
            Core.Optional<string> postParameterKey = default;
            Core.Optional<string> postParameterValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("postParameterKey"u8))
                {
                    postParameterKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("postParameterValue"u8))
                {
                    postParameterValue = property.Value.GetString();
                    continue;
                }
            }
            return new DomainControlCenterSsoRequestInfo(url.Value, postParameterKey.Value, postParameterValue.Value);
        }
    }
}
