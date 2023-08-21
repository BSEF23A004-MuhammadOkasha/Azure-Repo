// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SpatialAnalysisPersonLineCrossingLineEvents : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("line"u8);
            writer.WriteObjectValue(Line);
            if (Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events"u8);
                writer.WriteStartArray();
                foreach (var item in Events)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SpatialAnalysisPersonLineCrossingLineEvents DeserializeSpatialAnalysisPersonLineCrossingLineEvents(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NamedLineBase line = default;
            Optional<IList<SpatialAnalysisPersonLineCrossingEvent>> events = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("line"u8))
                {
                    line = NamedLineBase.DeserializeNamedLineBase(property.Value);
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SpatialAnalysisPersonLineCrossingEvent> array = new List<SpatialAnalysisPersonLineCrossingEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpatialAnalysisPersonLineCrossingEvent.DeserializeSpatialAnalysisPersonLineCrossingEvent(item));
                    }
                    events = array;
                    continue;
                }
            }
            return new SpatialAnalysisPersonLineCrossingLineEvents(line, Optional.ToList(events));
        }
    }
}
