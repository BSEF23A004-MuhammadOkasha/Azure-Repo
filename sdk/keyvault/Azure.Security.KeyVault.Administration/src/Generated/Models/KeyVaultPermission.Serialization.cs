// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration
{
    public partial class KeyVaultPermission : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Actions))
            {
                writer.WritePropertyName("actions");
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NotActions))
            {
                writer.WritePropertyName("notActions");
                writer.WriteStartArray();
                foreach (var item in NotActions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DataActions))
            {
                writer.WritePropertyName("dataActions");
                writer.WriteStartArray();
                foreach (var item in DataActions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NotDataActions))
            {
                writer.WritePropertyName("notDataActions");
                writer.WriteStartArray();
                foreach (var item in NotDataActions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static KeyVaultPermission DeserializeKeyVaultPermission(JsonElement element)
        {
            Optional<IList<string>> actions = default;
            Optional<IList<string>> notActions = default;
            Optional<IList<string>> dataActions = default;
            Optional<IList<string>> notDataActions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    actions = array;
                    continue;
                }
                if (property.NameEquals("notActions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    notActions = array;
                    continue;
                }
                if (property.NameEquals("dataActions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dataActions = array;
                    continue;
                }
                if (property.NameEquals("notDataActions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    notDataActions = array;
                    continue;
                }
            }
            return new KeyVaultPermission(Optional.ToList(actions), Optional.ToList(notActions), Optional.ToList(dataActions), Optional.ToList(notDataActions));
        }
    }
}
