// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class VideoCreationProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Core.Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Core.Optional.IsDefined(SegmentLength))
            {
                writer.WritePropertyName("segmentLength"u8);
                writer.WriteStringValue(SegmentLength);
            }
            if (Core.Optional.IsDefined(RetentionPeriod))
            {
                writer.WritePropertyName("retentionPeriod"u8);
                writer.WriteStringValue(RetentionPeriod);
            }
            writer.WriteEndObject();
        }

        internal static VideoCreationProperties DeserializeVideoCreationProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> title = default;
            Core.Optional<string> description = default;
            Core.Optional<string> segmentLength = default;
            Core.Optional<string> retentionPeriod = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("segmentLength"u8))
                {
                    segmentLength = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retentionPeriod"u8))
                {
                    retentionPeriod = property.Value.GetString();
                    continue;
                }
            }
            return new VideoCreationProperties(title.Value, description.Value, segmentLength.Value, retentionPeriod.Value);
        }
    }
}
