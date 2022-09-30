// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Elastic.Models
{
    public partial class FilteringTag : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action");
                writer.WriteStringValue(Action.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static FilteringTag DeserializeFilteringTag(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> value = default;
            Optional<TagAction> action = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("action"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    action = new TagAction(property.Value.GetString());
                    continue;
                }
            }
            return new FilteringTag(name.Value, value.Value, Optional.ToNullable(action));
        }
    }
}
