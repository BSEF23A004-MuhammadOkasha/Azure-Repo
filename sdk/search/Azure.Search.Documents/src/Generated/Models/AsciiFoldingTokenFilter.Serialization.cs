// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class AsciiFoldingTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (PreserveOriginal != null)
            {
                writer.WritePropertyName("preserveOriginal");
                writer.WriteBooleanValue(PreserveOriginal.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static AsciiFoldingTokenFilter DeserializeAsciiFoldingTokenFilter(JsonElement element)
        {
            bool? preserveOriginal = default;
            string odataType = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preserveOriginal"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preserveOriginal = property.Value.GetBoolean();
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
            return new AsciiFoldingTokenFilter(odataType, name, preserveOriginal);
        }
    }
}
