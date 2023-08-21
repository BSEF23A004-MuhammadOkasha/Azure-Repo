// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ConfidentialLedger;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    internal partial class ConfidentialLedgerList
    {
        internal static ConfidentialLedgerList DeserializeConfidentialLedgerList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ConfidentialLedgerData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConfidentialLedgerData> array = new List<ConfidentialLedgerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConfidentialLedgerData.DeserializeConfidentialLedgerData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ConfidentialLedgerList(Optional.ToList(value), nextLink.Value);
        }
    }
}
