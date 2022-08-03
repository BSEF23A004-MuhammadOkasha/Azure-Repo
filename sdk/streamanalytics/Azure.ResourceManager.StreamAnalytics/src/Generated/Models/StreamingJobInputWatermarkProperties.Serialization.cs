// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    internal partial class StreamingJobInputWatermarkProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(WatermarkMode))
            {
                writer.WritePropertyName("watermarkMode");
                writer.WriteStringValue(WatermarkMode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static StreamingJobInputWatermarkProperties DeserializeStreamingJobInputWatermarkProperties(JsonElement element)
        {
            Optional<StreamingJobInputWatermarkMode> watermarkMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("watermarkMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    watermarkMode = new StreamingJobInputWatermarkMode(property.Value.GetString());
                    continue;
                }
            }
            return new StreamingJobInputWatermarkProperties(Optional.ToNullable(watermarkMode));
        }
    }
}
