// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class LegalHoldProperties
    {
        internal static LegalHoldProperties DeserializeLegalHoldProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool> hasLegalHold = default;
            Core.Optional<IReadOnlyList<LegalHoldTag>> tags = default;
            Core.Optional<ProtectedAppendWritesHistory> protectedAppendWritesHistory = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hasLegalHold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasLegalHold = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LegalHoldTag> array = new List<LegalHoldTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LegalHoldTag.DeserializeLegalHoldTag(item));
                    }
                    tags = array;
                    continue;
                }
                if (property.NameEquals("protectedAppendWritesHistory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedAppendWritesHistory = ProtectedAppendWritesHistory.DeserializeProtectedAppendWritesHistory(property.Value);
                    continue;
                }
            }
            return new LegalHoldProperties(Core.Optional.ToNullable(hasLegalHold), Core.Optional.ToList(tags), protectedAppendWritesHistory.Value);
        }
    }
}
