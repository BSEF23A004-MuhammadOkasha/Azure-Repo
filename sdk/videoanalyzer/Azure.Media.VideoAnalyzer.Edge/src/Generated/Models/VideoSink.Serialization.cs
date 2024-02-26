// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class VideoSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("videoName"u8);
            writer.WriteStringValue(VideoName);
            if (VideoCreationProperties != null)
            {
                writer.WritePropertyName("videoCreationProperties"u8);
                writer.WriteObjectValue(VideoCreationProperties);
            }
            if (VideoPublishingOptions != null)
            {
                writer.WritePropertyName("videoPublishingOptions"u8);
                writer.WriteObjectValue(VideoPublishingOptions);
            }
            writer.WritePropertyName("localMediaCachePath"u8);
            writer.WriteStringValue(LocalMediaCachePath);
            writer.WritePropertyName("localMediaCacheMaximumSizeMiB"u8);
            writer.WriteStringValue(LocalMediaCacheMaximumSizeMiB);
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static VideoSink DeserializeVideoSink(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string videoName = default;
            Optional<VideoCreationProperties> videoCreationProperties = default;
            Optional<VideoPublishingOptions> videoPublishingOptions = default;
            string localMediaCachePath = default;
            string localMediaCacheMaximumSizeMiB = default;
            string type = default;
            string name = default;
            IList<NodeInput> inputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("videoName"u8))
                {
                    videoName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("videoCreationProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    videoCreationProperties = VideoCreationProperties.DeserializeVideoCreationProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("videoPublishingOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    videoPublishingOptions = VideoPublishingOptions.DeserializeVideoPublishingOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("localMediaCachePath"u8))
                {
                    localMediaCachePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localMediaCacheMaximumSizeMiB"u8))
                {
                    localMediaCacheMaximumSizeMiB = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    List<NodeInput> array = new List<NodeInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NodeInput.DeserializeNodeInput(item));
                    }
                    inputs = array;
                    continue;
                }
            }
            return new VideoSink(type, name, inputs, videoName, videoCreationProperties.Value, videoPublishingOptions.Value, localMediaCachePath, localMediaCacheMaximumSizeMiB);
        }
    }
}
