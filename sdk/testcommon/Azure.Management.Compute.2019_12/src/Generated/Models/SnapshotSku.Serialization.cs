// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class SnapshotSku : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static SnapshotSku DeserializeSnapshotSku(JsonElement element)
        {
            Optional<SnapshotStorageAccountTypes> name = default;
            Optional<string> tier = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = new SnapshotStorageAccountTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    tier = property.Value.GetString();
                    continue;
                }
            }
            return new SnapshotSku(Optional.ToNullable(name), tier.Value);
        }
    }
}
