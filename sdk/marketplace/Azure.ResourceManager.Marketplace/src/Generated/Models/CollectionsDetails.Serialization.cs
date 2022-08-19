// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class CollectionsDetails
    {
        internal static CollectionsDetails DeserializeCollectionsDetails(JsonElement element)
        {
            Optional<string> collectionName = default;
            Optional<string> collectionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("collectionName"))
                {
                    collectionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collectionId"))
                {
                    collectionId = property.Value.GetString();
                    continue;
                }
            }
            return new CollectionsDetails(collectionName.Value, collectionId.Value);
        }
    }
}
