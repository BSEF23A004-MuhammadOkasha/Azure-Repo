// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AzureOrbital.Models
{
    public partial class SpacecraftLink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("centerFrequencyMHz");
            writer.WriteNumberValue(CenterFrequencyMHz);
            writer.WritePropertyName("bandwidthMHz");
            writer.WriteNumberValue(BandwidthMHz);
            writer.WritePropertyName("direction");
            writer.WriteStringValue(Direction.ToString());
            writer.WritePropertyName("polarization");
            writer.WriteStringValue(Polarization.ToString());
            writer.WriteEndObject();
        }

        internal static SpacecraftLink DeserializeSpacecraftLink(JsonElement element)
        {
            float centerFrequencyMHz = default;
            float bandwidthMHz = default;
            SpacecraftLinkDirection direction = default;
            SpacecraftLinkPolarization polarization = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("centerFrequencyMHz"))
                {
                    centerFrequencyMHz = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("bandwidthMHz"))
                {
                    bandwidthMHz = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("direction"))
                {
                    direction = new SpacecraftLinkDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("polarization"))
                {
                    polarization = new SpacecraftLinkPolarization(property.Value.GetString());
                    continue;
                }
            }
            return new SpacecraftLink(centerFrequencyMHz, bandwidthMHz, direction, polarization);
        }
    }
}
