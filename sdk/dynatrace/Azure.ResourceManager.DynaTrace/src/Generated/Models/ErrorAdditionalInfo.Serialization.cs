// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DynaTrace.Models
{
    internal partial class ErrorAdditionalInfo
    {
        internal static ErrorAdditionalInfo DeserializeErrorAdditionalInfo(JsonElement element)
        {
            Optional<string> type = default;
            Optional<BinaryData> info = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("info"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    info = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new ErrorAdditionalInfo(type.Value, info.Value);
        }
    }
}
