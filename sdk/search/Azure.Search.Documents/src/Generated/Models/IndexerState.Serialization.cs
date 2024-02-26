// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class IndexerState
    {
        internal static IndexerState DeserializeIndexerState(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IndexingMode> mode = default;
            Optional<string> allDocsInitialChangeTrackingState = default;
            Optional<string> allDocsFinalChangeTrackingState = default;
            Optional<string> resetDocsInitialChangeTrackingState = default;
            Optional<string> resetDocsFinalChangeTrackingState = default;
            IReadOnlyList<string> resetDocumentKeys = default;
            IReadOnlyList<string> resetDatasourceDocumentIds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new IndexingMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allDocsInitialChangeTrackingState"u8))
                {
                    allDocsInitialChangeTrackingState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allDocsFinalChangeTrackingState"u8))
                {
                    allDocsFinalChangeTrackingState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resetDocsInitialChangeTrackingState"u8))
                {
                    resetDocsInitialChangeTrackingState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resetDocsFinalChangeTrackingState"u8))
                {
                    resetDocsFinalChangeTrackingState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resetDocumentKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resetDocumentKeys = array;
                    continue;
                }
                if (property.NameEquals("resetDatasourceDocumentIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resetDatasourceDocumentIds = array;
                    continue;
                }
            }
            return new IndexerState(Optional.ToNullable(mode), allDocsInitialChangeTrackingState.Value, allDocsFinalChangeTrackingState.Value, resetDocsInitialChangeTrackingState.Value, resetDocsFinalChangeTrackingState.Value, resetDocumentKeys ?? new ChangeTrackingList<string>(), resetDatasourceDocumentIds ?? new ChangeTrackingList<string>());
        }
    }
}
