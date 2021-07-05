// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace KeyVaultManagementClient.Models
{
    public partial class LogSpecification
    {
        internal static LogSpecification DeserializeLogSpecification(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> displayName = default;
            Optional<string> blobDuration = default;
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
                if (property.NameEquals("blobDuration"))
                {
                    blobDuration = property.Value.GetString();
                    continue;
                }
            }
            return new LogSpecification(name.Value, displayName.Value, blobDuration.Value);
        }
    }
}
