// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class SwitchCase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteStringValue(Value);
            }
            if (Optional.IsCollectionDefined(Activities))
            {
                writer.WritePropertyName("activities");
                writer.WriteStartArray();
                foreach (var item in Activities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SwitchCase DeserializeSwitchCase(JsonElement element)
        {
            Optional<string> value = default;
            Optional<IList<Activity>> activities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Activity> array = new List<Activity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Activity.DeserializeActivity(item));
                    }
                    activities = array;
                    continue;
                }
            }
            return new SwitchCase(value.Value, Optional.ToList(activities));
        }
    }
}
