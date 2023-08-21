// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    internal partial class ScriptExecutionsList
    {
        internal static ScriptExecutionsList DeserializeScriptExecutionsList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<ScriptExecutionData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScriptExecutionData> array = new List<ScriptExecutionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScriptExecutionData.DeserializeScriptExecutionData(item));
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
            return new ScriptExecutionsList(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
