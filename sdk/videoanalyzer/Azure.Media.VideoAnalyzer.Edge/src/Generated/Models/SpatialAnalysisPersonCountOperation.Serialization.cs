// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SpatialAnalysisPersonCountOperation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("zones");
            writer.WriteStartArray();
            foreach (var item in Zones)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Debug))
            {
                writer.WritePropertyName("debug");
                writer.WriteStringValue(Debug);
            }
            if (Optional.IsDefined(CameraConfiguration))
            {
                writer.WritePropertyName("cameraConfiguration");
                writer.WriteStringValue(CameraConfiguration);
            }
            if (Optional.IsDefined(DetectorNodeConfiguration))
            {
                writer.WritePropertyName("detectorNodeConfiguration");
                writer.WriteStringValue(DetectorNodeConfiguration);
            }
            if (Optional.IsDefined(EnableFaceMaskClassifier))
            {
                writer.WritePropertyName("enableFaceMaskClassifier");
                writer.WriteStringValue(EnableFaceMaskClassifier);
            }
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static SpatialAnalysisPersonCountOperation DeserializeSpatialAnalysisPersonCountOperation(JsonElement element)
        {
            IList<SpatialAnalysisPersonCountZoneEvents> zones = default;
            Optional<string> debug = default;
            Optional<string> cameraConfiguration = default;
            Optional<string> detectorNodeConfiguration = default;
            Optional<string> enableFaceMaskClassifier = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zones"))
                {
                    List<SpatialAnalysisPersonCountZoneEvents> array = new List<SpatialAnalysisPersonCountZoneEvents>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpatialAnalysisPersonCountZoneEvents.DeserializeSpatialAnalysisPersonCountZoneEvents(item));
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("debug"))
                {
                    debug = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cameraConfiguration"))
                {
                    cameraConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("detectorNodeConfiguration"))
                {
                    detectorNodeConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableFaceMaskClassifier"))
                {
                    enableFaceMaskClassifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new SpatialAnalysisPersonCountOperation(type, debug.Value, cameraConfiguration.Value, detectorNodeConfiguration.Value, enableFaceMaskClassifier.Value, zones);
        }
    }
}
