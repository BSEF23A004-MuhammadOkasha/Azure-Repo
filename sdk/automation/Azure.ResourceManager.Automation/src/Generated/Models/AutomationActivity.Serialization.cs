// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationActivity
    {
        internal static AutomationActivity DeserializeAutomationActivity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ResourceIdentifier> id = default;
            Core.Optional<string> name = default;
            Core.Optional<string> definition = default;
            Core.Optional<IReadOnlyList<AutomationActivityParameterSet>> parameterSets = default;
            Core.Optional<IReadOnlyList<AutomationActivityOutputType>> outputTypes = default;
            Core.Optional<DateTimeOffset> creationTime = default;
            Core.Optional<DateTimeOffset> lastModifiedTime = default;
            Core.Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("definition"u8))
                        {
                            definition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parameterSets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AutomationActivityParameterSet> array = new List<AutomationActivityParameterSet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AutomationActivityParameterSet.DeserializeAutomationActivityParameterSet(item));
                            }
                            parameterSets = array;
                            continue;
                        }
                        if (property0.NameEquals("outputTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AutomationActivityOutputType> array = new List<AutomationActivityOutputType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AutomationActivityOutputType.DeserializeAutomationActivityOutputType(item));
                            }
                            outputTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AutomationActivity(id.Value, name.Value, definition.Value, Core.Optional.ToList(parameterSets), Core.Optional.ToList(outputTypes), Core.Optional.ToNullable(creationTime), Core.Optional.ToNullable(lastModifiedTime), description.Value);
        }
    }
}
