// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class KeyValuePair_internal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Label != null)
            {
                writer.WritePropertyName("label");
                writer.WriteStringValue(Label);
            }
            writer.WritePropertyName("key");
            writer.WriteObjectValue(Key);
            writer.WritePropertyName("value");
            writer.WriteObjectValue(Value);
            writer.WritePropertyName("confidence");
            writer.WriteNumberValue(Confidence);
            writer.WriteEndObject();
        }
        internal static KeyValuePair_internal DeserializeKeyValuePair_internal(JsonElement element)
        {
            KeyValuePair_internal result = new KeyValuePair_internal();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("label"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key"))
                {
                    result.Key = KeyValueElement_internal.DeserializeKeyValueElement_internal(property.Value);
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    result.Value = KeyValueElement_internal.DeserializeKeyValueElement_internal(property.Value);
                    continue;
                }
                if (property.NameEquals("confidence"))
                {
                    result.Confidence = property.Value.GetSingle();
                    continue;
                }
            }
            return result;
        }
    }
}
