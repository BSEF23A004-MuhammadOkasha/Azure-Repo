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
    public partial class AutomationJobStream
    {
        internal static AutomationJobStream DeserializeAutomationJobStream(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ResourceIdentifier> id = default;
            Core.Optional<string> jobStreamId = default;
            Core.Optional<DateTimeOffset> time = default;
            Core.Optional<AutomationJobStreamType> streamType = default;
            Core.Optional<string> streamText = default;
            Core.Optional<string> summary = default;
            Core.Optional<IReadOnlyDictionary<string, BinaryData>> value = default;
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("jobStreamId"u8))
                        {
                            jobStreamId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("time"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            time = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("streamType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            streamType = new AutomationJobStreamType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("streamText"u8))
                        {
                            streamText = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("summary"u8))
                        {
                            summary = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("value"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            value = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AutomationJobStream(id.Value, jobStreamId.Value, Core.Optional.ToNullable(time), Core.Optional.ToNullable(streamType), streamText.Value, summary.Value, Core.Optional.ToDictionary(value));
        }
    }
}
