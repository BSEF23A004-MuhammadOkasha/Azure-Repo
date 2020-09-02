// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ApplicationGatewayAutoscaleConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("minCapacity");
            writer.WriteNumberValue(MinCapacity);
            if (Optional.IsDefined(MaxCapacity))
            {
                writer.WritePropertyName("maxCapacity");
                writer.WriteNumberValue(MaxCapacity.Value);
            }
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayAutoscaleConfiguration DeserializeApplicationGatewayAutoscaleConfiguration(JsonElement element)
        {
            int minCapacity = default;
            Optional<int> maxCapacity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minCapacity"))
                {
                    minCapacity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxCapacity"))
                {
                    maxCapacity = property.Value.GetInt32();
                    continue;
                }
            }
            return new ApplicationGatewayAutoscaleConfiguration(minCapacity, Optional.ToNullable(maxCapacity));
        }
    }
}
