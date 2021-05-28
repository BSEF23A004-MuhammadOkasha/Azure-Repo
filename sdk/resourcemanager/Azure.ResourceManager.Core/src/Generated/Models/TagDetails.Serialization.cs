﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Core
{
    public partial class TagDetails
    {
        internal static TagDetails DeserializeTagDetails(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> tagName = default;
            Optional<TagCount> count = default;
            Optional<IReadOnlyList<TagValue>> values = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tagName"))
                {
                    tagName = property.Value.GetString();
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
                if (property.NameEquals("values"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TagValue> array = new List<TagValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TagValue.DeserializeTagValue(item));
                    }
                    values = array;
                    continue;
                }
            }
            return new TagDetails(id.Value, tagName.Value, count.Value, Optional.ToList(values));
        }
    }
}
