// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class PathHierarchyTokenizer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Delimiter.HasValue)
            {
                writer.WritePropertyName("delimiter"u8);
                writer.WriteStringValue(Delimiter.Value);
            }
            if (Replacement.HasValue)
            {
                writer.WritePropertyName("replacement"u8);
                writer.WriteStringValue(Replacement.Value);
            }
            if (MaxTokenLength.HasValue)
            {
                writer.WritePropertyName("maxTokenLength"u8);
                writer.WriteNumberValue(MaxTokenLength.Value);
            }
            if (ReverseTokenOrder.HasValue)
            {
                writer.WritePropertyName("reverse"u8);
                writer.WriteBooleanValue(ReverseTokenOrder.Value);
            }
            if (NumberOfTokensToSkip.HasValue)
            {
                writer.WritePropertyName("skip"u8);
                writer.WriteNumberValue(NumberOfTokensToSkip.Value);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static PathHierarchyTokenizer DeserializePathHierarchyTokenizer(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<char> delimiter = default;
            Optional<char> replacement = default;
            Optional<int> maxTokenLength = default;
            Optional<bool> reverse = default;
            Optional<int> skip = default;
            string odataType = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("delimiter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delimiter = property.Value.GetChar();
                    continue;
                }
                if (property.NameEquals("replacement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replacement = property.Value.GetChar();
                    continue;
                }
                if (property.NameEquals("maxTokenLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxTokenLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("reverse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reverse = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("skip"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skip = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new PathHierarchyTokenizer(odataType, name, Optional.ToNullable(delimiter), Optional.ToNullable(replacement), Optional.ToNullable(maxTokenLength), Optional.ToNullable(reverse), Optional.ToNullable(skip));
        }
    }
}
