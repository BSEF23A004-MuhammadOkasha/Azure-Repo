// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class PredictionSystemGeneratedEntities
    {
        internal static PredictionSystemGeneratedEntities DeserializePredictionSystemGeneratedEntities(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<string>> generatedInteractionTypes = default;
            Optional<IReadOnlyList<string>> generatedLinks = default;
            Optional<IReadOnlyDictionary<string, string>> generatedKpis = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("generatedInteractionTypes"u8))
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
                    generatedInteractionTypes = array;
                    continue;
                }
                if (property.NameEquals("generatedLinks"u8))
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
                    generatedLinks = array;
                    continue;
                }
                if (property.NameEquals("generatedKpis"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    generatedKpis = dictionary;
                    continue;
                }
            }
            return new PredictionSystemGeneratedEntities(Optional.ToList(generatedInteractionTypes), Optional.ToList(generatedLinks), Optional.ToDictionary(generatedKpis));
        }
    }
}
