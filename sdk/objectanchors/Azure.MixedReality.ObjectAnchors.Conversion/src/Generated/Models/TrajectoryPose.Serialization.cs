// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.MixedReality.ObjectAnchors.Conversion.Models;

namespace Azure.MixedReality.ObjectAnchors.Conversion
{
    public partial struct TrajectoryPose : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("rotation"u8);
            writer.WriteObjectValue(RotationWrapper);
            writer.WritePropertyName("translation"u8);
            writer.WriteObjectValue(TranslationWrapper);
            writer.WriteEndObject();
        }

        internal static TrajectoryPose DeserializeTrajectoryPose(JsonElement element)
        {
            Quaternion rotation = default;
            Vector3 translation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rotation"u8))
                {
                    rotation = Quaternion.DeserializeQuaternion(property.Value);
                    continue;
                }
                if (property.NameEquals("translation"u8))
                {
                    translation = Vector3.DeserializeVector3(property.Value);
                    continue;
                }
            }
            return new TrajectoryPose(rotation, translation);
        }
    }
}
