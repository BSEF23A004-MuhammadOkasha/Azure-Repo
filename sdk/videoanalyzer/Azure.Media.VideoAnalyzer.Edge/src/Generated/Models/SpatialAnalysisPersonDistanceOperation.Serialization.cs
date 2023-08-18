// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SpatialAnalysisPersonDistanceOperation : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("zones"u8);
            writer.WriteStartArray();
            foreach (var item in Zones)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Core.Optional.IsDefined(Debug))
            {
                writer.WritePropertyName("debug"u8);
                writer.WriteStringValue(Debug);
            }
            if (Core.Optional.IsDefined(CalibrationConfiguration))
            {
                writer.WritePropertyName("calibrationConfiguration"u8);
                writer.WriteStringValue(CalibrationConfiguration);
            }
            if (Core.Optional.IsDefined(CameraConfiguration))
            {
                writer.WritePropertyName("cameraConfiguration"u8);
                writer.WriteStringValue(CameraConfiguration);
            }
            if (Core.Optional.IsDefined(CameraCalibratorNodeConfiguration))
            {
                writer.WritePropertyName("cameraCalibratorNodeConfiguration"u8);
                writer.WriteStringValue(CameraCalibratorNodeConfiguration);
            }
            if (Core.Optional.IsDefined(DetectorNodeConfiguration))
            {
                writer.WritePropertyName("detectorNodeConfiguration"u8);
                writer.WriteStringValue(DetectorNodeConfiguration);
            }
            if (Core.Optional.IsDefined(TrackerNodeConfiguration))
            {
                writer.WritePropertyName("trackerNodeConfiguration"u8);
                writer.WriteStringValue(TrackerNodeConfiguration);
            }
            if (Core.Optional.IsDefined(EnableFaceMaskClassifier))
            {
                writer.WritePropertyName("enableFaceMaskClassifier"u8);
                writer.WriteStringValue(EnableFaceMaskClassifier);
            }
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static SpatialAnalysisPersonDistanceOperation DeserializeSpatialAnalysisPersonDistanceOperation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<SpatialAnalysisPersonDistanceZoneEvents> zones = default;
            Core.Optional<string> debug = default;
            Core.Optional<string> calibrationConfiguration = default;
            Core.Optional<string> cameraConfiguration = default;
            Core.Optional<string> cameraCalibratorNodeConfiguration = default;
            Core.Optional<string> detectorNodeConfiguration = default;
            Core.Optional<string> trackerNodeConfiguration = default;
            Core.Optional<string> enableFaceMaskClassifier = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zones"u8))
                {
                    List<SpatialAnalysisPersonDistanceZoneEvents> array = new List<SpatialAnalysisPersonDistanceZoneEvents>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpatialAnalysisPersonDistanceZoneEvents.DeserializeSpatialAnalysisPersonDistanceZoneEvents(item));
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("debug"u8))
                {
                    debug = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("calibrationConfiguration"u8))
                {
                    calibrationConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cameraConfiguration"u8))
                {
                    cameraConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cameraCalibratorNodeConfiguration"u8))
                {
                    cameraCalibratorNodeConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("detectorNodeConfiguration"u8))
                {
                    detectorNodeConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackerNodeConfiguration"u8))
                {
                    trackerNodeConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableFaceMaskClassifier"u8))
                {
                    enableFaceMaskClassifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new SpatialAnalysisPersonDistanceOperation(type, debug.Value, calibrationConfiguration.Value, cameraConfiguration.Value, cameraCalibratorNodeConfiguration.Value, detectorNodeConfiguration.Value, trackerNodeConfiguration.Value, enableFaceMaskClassifier.Value, zones);
        }
    }
}
