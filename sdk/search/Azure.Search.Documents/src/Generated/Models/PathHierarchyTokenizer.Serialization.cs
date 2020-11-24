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
            if (Optional.IsDefined(Delimiter))
            {
                writer.WritePropertyName("delimiter");
                writer.WriteStringValue(Delimiter.Value);
            }
            if (Optional.IsDefined(Replacement))
            {
                writer.WritePropertyName("replacement");
                writer.WriteStringValue(Replacement.Value);
            }
            if (Optional.IsDefined(MaxTokenLength))
            {
                writer.WritePropertyName("maxTokenLength");
                writer.WriteNumberValue(MaxTokenLength.Value);
            }
            if (Optional.IsDefined(ReverseTokenOrder))
            {
                writer.WritePropertyName("reverse");
                writer.WriteBooleanValue(ReverseTokenOrder.Value);
            }
            if (Optional.IsDefined(NumberOfTokensToSkip))
            {
                writer.WritePropertyName("skip");
                writer.WriteNumberValue(NumberOfTokensToSkip.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static PathHierarchyTokenizer DeserializePathHierarchyTokenizer(JsonElement element)
        {
            Optional<char> delimiter = default;
            Optional<char> replacement = default;
            Optional<int> maxTokenLength = default;
            Optional<bool> reverse = default;
            Optional<int> skip = default;
            string odataType = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("delimiter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    delimiter = property.Value.GetChar();
                    continue;
                }
                if (property.NameEquals("replacement"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    replacement = property.Value.GetChar();
                    continue;
                }
                if (property.NameEquals("maxTokenLength"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxTokenLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("reverse"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reverse = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("skip"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    skip = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new PathHierarchyTokenizer(odataType, name, Optional.ToNullable(delimiter), Optional.ToNullable(replacement), Optional.ToNullable(maxTokenLength), Optional.ToNullable(reverse), Optional.ToNullable(skip));
        }
    }
}
