// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Media.VideoAnalyzer.Edge;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class LivePipelineCollection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ContinuationToken))
            {
                writer.WritePropertyName("@continuationToken"u8);
                writer.WriteStringValue(ContinuationToken);
            }
            writer.WriteEndObject();
        }

        internal static LivePipelineCollection DeserializeLivePipelineCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<LivePipeline> value = default;
            string continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LivePipeline> array = new List<LivePipeline>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LivePipeline.DeserializeLivePipeline(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@continuationToken"u8))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
            }
            return new LivePipelineCollection(value ?? new ChangeTrackingList<LivePipeline>(), continuationToken);
        }
    }
}
