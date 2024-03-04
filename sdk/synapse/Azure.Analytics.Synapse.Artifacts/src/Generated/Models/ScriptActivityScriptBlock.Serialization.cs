// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ScriptActivityScriptBlockConverter))]
    public partial class ScriptActivityScriptBlock : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("text"u8);
            writer.WriteObjectValue(Text);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            if (!(Parameters is ChangeTrackingList<ScriptActivityParameter> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ScriptActivityScriptBlock DeserializeScriptActivityScriptBlock(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object text = default;
            ScriptType type = default;
            IList<ScriptActivityParameter> parameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ScriptType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScriptActivityParameter> array = new List<ScriptActivityParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScriptActivityParameter.DeserializeScriptActivityParameter(item));
                    }
                    parameters = array;
                    continue;
                }
            }
            return new ScriptActivityScriptBlock(text, type, parameters ?? new ChangeTrackingList<ScriptActivityParameter>());
        }

        internal partial class ScriptActivityScriptBlockConverter : JsonConverter<ScriptActivityScriptBlock>
        {
            public override void Write(Utf8JsonWriter writer, ScriptActivityScriptBlock model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ScriptActivityScriptBlock Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeScriptActivityScriptBlock(document.RootElement);
            }
        }
    }
}
