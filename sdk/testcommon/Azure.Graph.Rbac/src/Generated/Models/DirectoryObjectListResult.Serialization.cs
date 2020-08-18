// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class DirectoryObjectListResult
    {
        internal static DirectoryObjectListResult DeserializeDirectoryObjectListResult(JsonElement element)
        {
            Optional<IReadOnlyList<DirectoryObject>> value = default;
            Optional<string> odataNextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<DirectoryObject> array = new List<DirectoryObject>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DirectoryObject.DeserializeDirectoryObject(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("odata.nextLink"))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DirectoryObjectListResult(Optional.ToList(value), odataNextLink.Value);
        }
    }
}
