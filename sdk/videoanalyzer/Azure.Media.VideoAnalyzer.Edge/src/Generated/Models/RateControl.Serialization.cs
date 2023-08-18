// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class RateControl : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(BitRateLimit))
            {
                writer.WritePropertyName("bitRateLimit"u8);
                writer.WriteNumberValue(BitRateLimit.Value);
            }
            if (Core.Optional.IsDefined(EncodingInterval))
            {
                writer.WritePropertyName("encodingInterval"u8);
                writer.WriteNumberValue(EncodingInterval.Value);
            }
            if (Core.Optional.IsDefined(FrameRateLimit))
            {
                writer.WritePropertyName("frameRateLimit"u8);
                writer.WriteNumberValue(FrameRateLimit.Value);
            }
            if (Core.Optional.IsDefined(GuaranteedFrameRate))
            {
                writer.WritePropertyName("guaranteedFrameRate"u8);
                writer.WriteBooleanValue(GuaranteedFrameRate.Value);
            }
            writer.WriteEndObject();
        }

        internal static RateControl DeserializeRateControl(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<float> bitRateLimit = default;
            Core.Optional<float> encodingInterval = default;
            Core.Optional<float> frameRateLimit = default;
            Core.Optional<bool> guaranteedFrameRate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bitRateLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bitRateLimit = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("encodingInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encodingInterval = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("frameRateLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frameRateLimit = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("guaranteedFrameRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    guaranteedFrameRate = property.Value.GetBoolean();
                    continue;
                }
            }
            return new RateControl(Core.Optional.ToNullable(bitRateLimit), Core.Optional.ToNullable(encodingInterval), Core.Optional.ToNullable(frameRateLimit), Core.Optional.ToNullable(guaranteedFrameRate));
        }
    }
}
