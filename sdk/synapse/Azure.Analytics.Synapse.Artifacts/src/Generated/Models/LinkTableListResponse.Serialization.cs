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
    [JsonConverter(typeof(LinkTableListResponseConverter))]
    public partial class LinkTableListResponse
    {
        internal static LinkTableListResponse DeserializeLinkTableListResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<LinkTableResource>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LinkTableResource> array = new List<LinkTableResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LinkTableResource.DeserializeLinkTableResource(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new LinkTableListResponse(Core.Optional.ToList(value));
        }

        internal partial class LinkTableListResponseConverter : JsonConverter<LinkTableListResponse>
        {
            public override void Write(Utf8JsonWriter writer, LinkTableListResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override LinkTableListResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkTableListResponse(document.RootElement);
            }
        }
    }
}
