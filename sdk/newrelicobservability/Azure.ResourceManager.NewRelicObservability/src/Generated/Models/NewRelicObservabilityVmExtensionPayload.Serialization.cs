// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicObservabilityVmExtensionPayload
    {
        internal static NewRelicObservabilityVmExtensionPayload DeserializeNewRelicObservabilityVmExtensionPayload(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ingestionKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ingestionKey"u8))
                {
                    ingestionKey = property.Value.GetString();
                    continue;
                }
            }
            return new NewRelicObservabilityVmExtensionPayload(ingestionKey.Value);
        }
    }
}
