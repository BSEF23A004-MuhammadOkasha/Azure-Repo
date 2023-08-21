// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAccountKeys
    {
        internal static BatchAccountKeys DeserializeBatchAccountKeys(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> accountName = default;
            Core.Optional<string> primary = default;
            Core.Optional<string> secondary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primary"u8))
                {
                    primary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondary"u8))
                {
                    secondary = property.Value.GetString();
                    continue;
                }
            }
            return new BatchAccountKeys(accountName.Value, primary.Value, secondary.Value);
        }
    }
}
