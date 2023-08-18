// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(UserPropertyConverter))]
    public partial class UserProperty : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("value"u8);
            writer.WriteObjectValue(Value);
            writer.WriteEndObject();
        }

        internal static UserProperty DeserializeUserProperty(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            object value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetObject();
                    continue;
                }
            }
            return new UserProperty(name, value);
        }

        internal partial class UserPropertyConverter : JsonConverter<UserProperty>
        {
            public override void Write(Utf8JsonWriter writer, UserProperty model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override UserProperty Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeUserProperty(document.RootElement);
            }
        }
    }
}
