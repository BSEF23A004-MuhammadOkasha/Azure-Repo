// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class UnknownDataTransferDataSourceSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("component"u8);
            writer.WriteStringValue(Component.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownDataTransferDataSourceSink DeserializeUnknownDataTransferDataSourceSink(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataTransferComponent component = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("component"u8))
                {
                    component = new DataTransferComponent(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownDataTransferDataSourceSink(component);
        }
    }
}
