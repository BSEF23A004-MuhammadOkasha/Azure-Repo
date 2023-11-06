// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class DetectedLanguage
    {
        internal static DetectedLanguage DeserializeDetectedLanguage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string iso6391Name = default;
            double confidenceScore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        name = null;
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iso6391Name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        iso6391Name = null;
                        continue;
                    }
                    iso6391Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidenceScore"u8))
                {
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
            }
            return new DetectedLanguage(name, iso6391Name, confidenceScore);
        }
    }
}
