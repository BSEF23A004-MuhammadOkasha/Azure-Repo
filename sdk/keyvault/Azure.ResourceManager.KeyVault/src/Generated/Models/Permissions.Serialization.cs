// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace KeyVaultManagementClient.Models
{
    public partial class Permissions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Keys))
            {
                writer.WritePropertyName("keys");
                writer.WriteStartArray();
                foreach (var item in Keys)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Secrets))
            {
                writer.WritePropertyName("secrets");
                writer.WriteStartArray();
                foreach (var item in Secrets)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Certificates))
            {
                writer.WritePropertyName("certificates");
                writer.WriteStartArray();
                foreach (var item in Certificates)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Storage))
            {
                writer.WritePropertyName("storage");
                writer.WriteStartArray();
                foreach (var item in Storage)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static Permissions DeserializePermissions(JsonElement element)
        {
            Optional<IList<KeyPermissions>> keys = default;
            Optional<IList<SecretPermissions>> secrets = default;
            Optional<IList<CertificatePermissions>> certificates = default;
            Optional<IList<StoragePermissions>> storage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keys"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<KeyPermissions> array = new List<KeyPermissions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new KeyPermissions(item.GetString()));
                    }
                    keys = array;
                    continue;
                }
                if (property.NameEquals("secrets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SecretPermissions> array = new List<SecretPermissions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SecretPermissions(item.GetString()));
                    }
                    secrets = array;
                    continue;
                }
                if (property.NameEquals("certificates"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CertificatePermissions> array = new List<CertificatePermissions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new CertificatePermissions(item.GetString()));
                    }
                    certificates = array;
                    continue;
                }
                if (property.NameEquals("storage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<StoragePermissions> array = new List<StoragePermissions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new StoragePermissions(item.GetString()));
                    }
                    storage = array;
                    continue;
                }
            }
            return new Permissions(Optional.ToList(keys), Optional.ToList(secrets), Optional.ToList(certificates), Optional.ToList(storage));
        }
    }
}
