// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class UnknownRecoveryResourceGroupCustomDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("resourceType");
            writer.WriteStringValue(ResourceType);
            writer.WriteEndObject();
        }

        internal static UnknownRecoveryResourceGroupCustomDetails DeserializeUnknownRecoveryResourceGroupCustomDetails(JsonElement element)
        {
            string resourceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownRecoveryResourceGroupCustomDetails(resourceType);
        }
    }
}
