﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Core
{
    public partial class TagValue
    {
        internal static TagValue DeserializeTagValue(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> tagValue = default;
            Optional<TagCount> count = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tagValue"))
                {
                    tagValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = TagCount.DeserializeTagCount(property.Value);
                    continue;
                }
            }
            return new TagValue(id.Value, tagValue.Value, count.Value);
        }
    }
}
