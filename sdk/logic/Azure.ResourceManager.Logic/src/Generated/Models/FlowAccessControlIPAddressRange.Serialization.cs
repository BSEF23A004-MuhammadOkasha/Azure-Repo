// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class FlowAccessControlIPAddressRange : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AddressRange))
            {
                writer.WritePropertyName("addressRange"u8);
                writer.WriteStringValue(AddressRange);
            }
            writer.WriteEndObject();
        }

        internal static FlowAccessControlIPAddressRange DeserializeFlowAccessControlIPAddressRange(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> addressRange = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addressRange"u8))
                {
                    addressRange = property.Value.GetString();
                    continue;
                }
            }
            return new FlowAccessControlIPAddressRange(addressRange.Value);
        }
    }
}
