// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class PropertyUpdatesInProgress
    {
        internal static PropertyUpdatesInProgress DeserializePropertyUpdatesInProgress(JsonElement element)
        {
            Optional<string> targetTier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetTier"))
                {
                    targetTier = property.Value.GetString();
                    continue;
                }
            }
            return new PropertyUpdatesInProgress(targetTier.Value);
        }
    }
}
