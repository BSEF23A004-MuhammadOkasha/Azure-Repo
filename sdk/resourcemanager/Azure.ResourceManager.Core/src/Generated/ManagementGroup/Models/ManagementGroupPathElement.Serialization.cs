// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Core
{
    public partial class ManagementGroupPathElement
    {
        internal static ManagementGroupPathElement DeserializeManagementGroupPathElement(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> displayName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
            }
            return new ManagementGroupPathElement(name.Value, displayName.Value);
        }
    }
}
