// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class DocumentLinkedEntities
    {
        internal static DocumentLinkedEntities DeserializeDocumentLinkedEntities(JsonElement element)
        {
            string id = default;
            IReadOnlyList<LinkedEntity> entities = default;
            IReadOnlyList<TextAnalyticsWarning_internal> warnings = default;
            Optional<TextDocumentStatistics> statistics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entities"))
                {
                    List<LinkedEntity> array = new List<LinkedEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedEntity.DeserializeLinkedEntity(item));
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("warnings"))
                {
                    List<TextAnalyticsWarning_internal> array = new List<TextAnalyticsWarning_internal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAnalyticsWarning_internal.DeserializeTextAnalyticsWarning_internal(item));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("statistics"))
                {
                    statistics = TextDocumentStatistics.DeserializeTextDocumentStatistics(property.Value);
                    continue;
                }
            }
            return new DocumentLinkedEntities(id, entities, warnings, Optional.ToNullable(statistics));
        }
    }
}
