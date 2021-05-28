﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Core
{
    internal partial class TagsListResult
    {
        internal static TagsListResult DeserializeTagsListResult(JsonElement element)
        {
            Optional<IReadOnlyList<TagDetails>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TagDetails> array = new List<TagDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TagDetails.DeserializeTagDetails(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new TagsListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
