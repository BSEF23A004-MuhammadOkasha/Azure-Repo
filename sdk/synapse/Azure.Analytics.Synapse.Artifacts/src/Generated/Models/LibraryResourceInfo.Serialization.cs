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
    [JsonConverter(typeof(LibraryResourceInfoConverter))]
    public partial class LibraryResourceInfo
    {
        internal static LibraryResourceInfo DeserializeLibraryResourceInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> id = default;
            Core.Optional<int> recordId = default;
            Core.Optional<string> state = default;
            Core.Optional<string> created = default;
            Core.Optional<string> changed = default;
            Core.Optional<string> type = default;
            Core.Optional<string> name = default;
            Core.Optional<string> operationId = default;
            Core.Optional<string> artifactId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recordId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recordId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("created"u8))
                {
                    created = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("changed"u8))
                {
                    changed = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactId"u8))
                {
                    artifactId = property.Value.GetString();
                    continue;
                }
            }
            return new LibraryResourceInfo(id.Value, Core.Optional.ToNullable(recordId), state.Value, created.Value, changed.Value, type.Value, name.Value, operationId.Value, artifactId.Value);
        }

        internal partial class LibraryResourceInfoConverter : JsonConverter<LibraryResourceInfo>
        {
            public override void Write(Utf8JsonWriter writer, LibraryResourceInfo model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override LibraryResourceInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLibraryResourceInfo(document.RootElement);
            }
        }
    }
}
