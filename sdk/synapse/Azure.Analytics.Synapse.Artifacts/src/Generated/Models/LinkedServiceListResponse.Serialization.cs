// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkedServiceListResponseConverter))]
    internal partial class LinkedServiceListResponse
    {
        internal static LinkedServiceListResponse DeserializeLinkedServiceListResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<LinkedServiceResource> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<LinkedServiceResource> array = new List<LinkedServiceResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkedServiceResource.DeserializeLinkedServiceResource(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new LinkedServiceListResponse(value, nextLink.Value);
        }

        internal partial class LinkedServiceListResponseConverter : JsonConverter<LinkedServiceListResponse>
        {
            public override void Write(Utf8JsonWriter writer, LinkedServiceListResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override LinkedServiceListResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkedServiceListResponse(document.RootElement);
            }
        }
    }
}
