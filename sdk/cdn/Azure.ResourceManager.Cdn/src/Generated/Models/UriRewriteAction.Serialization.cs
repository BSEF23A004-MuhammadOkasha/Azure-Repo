// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class UriRewriteAction : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("parameters"u8);
            writer.WriteObjectValue(Properties);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToString());
            writer.WriteEndObject();
        }

        internal static UriRewriteAction DeserializeUriRewriteAction(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UriRewriteActionProperties parameters = default;
            DeliveryRuleActionType name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"u8))
                {
                    parameters = UriRewriteActionProperties.DeserializeUriRewriteActionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = new DeliveryRuleActionType(property.Value.GetString());
                    continue;
                }
            }
            return new UriRewriteAction(name, parameters);
        }
    }
}
