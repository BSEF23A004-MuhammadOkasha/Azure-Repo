// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    public partial class SapNetWeaverProviderInstanceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SapSid))
            {
                writer.WritePropertyName("sapSid");
                writer.WriteStringValue(SapSid);
            }
            if (Optional.IsDefined(SapHostname))
            {
                writer.WritePropertyName("sapHostname");
                writer.WriteStringValue(SapHostname);
            }
            if (Optional.IsDefined(SapInstanceNr))
            {
                writer.WritePropertyName("sapInstanceNr");
                writer.WriteStringValue(SapInstanceNr);
            }
            if (Optional.IsCollectionDefined(SapHostFileEntries))
            {
                writer.WritePropertyName("sapHostFileEntries");
                writer.WriteStartArray();
                foreach (var item in SapHostFileEntries)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SapUsername))
            {
                writer.WritePropertyName("sapUsername");
                writer.WriteStringValue(SapUsername);
            }
            if (Optional.IsDefined(SapPassword))
            {
                writer.WritePropertyName("sapPassword");
                writer.WriteStringValue(SapPassword);
            }
            if (Optional.IsDefined(SapPasswordUri))
            {
                writer.WritePropertyName("sapPasswordUri");
                writer.WriteStringValue(SapPasswordUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SapClientId))
            {
                writer.WritePropertyName("sapClientId");
                writer.WriteStringValue(SapClientId);
            }
            if (Optional.IsDefined(SapPortNumber))
            {
                writer.WritePropertyName("sapPortNumber");
                writer.WriteStringValue(SapPortNumber);
            }
            if (Optional.IsDefined(SapSslCertificateUri))
            {
                writer.WritePropertyName("sapSslCertificateUri");
                writer.WriteStringValue(SapSslCertificateUri.AbsoluteUri);
            }
            writer.WritePropertyName("providerType");
            writer.WriteStringValue(ProviderType);
            writer.WriteEndObject();
        }

        internal static SapNetWeaverProviderInstanceProperties DeserializeSapNetWeaverProviderInstanceProperties(JsonElement element)
        {
            Optional<string> sapSid = default;
            Optional<string> sapHostname = default;
            Optional<string> sapInstanceNr = default;
            Optional<IList<string>> sapHostFileEntries = default;
            Optional<string> sapUsername = default;
            Optional<string> sapPassword = default;
            Optional<Uri> sapPasswordUri = default;
            Optional<string> sapClientId = default;
            Optional<string> sapPortNumber = default;
            Optional<Uri> sapSslCertificateUri = default;
            string providerType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sapSid"))
                {
                    sapSid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sapHostname"))
                {
                    sapHostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sapInstanceNr"))
                {
                    sapInstanceNr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sapHostFileEntries"))
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
                    sapHostFileEntries = array;
                    continue;
                }
                if (property.NameEquals("sapUsername"))
                {
                    sapUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sapPassword"))
                {
                    sapPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sapPasswordUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sapPasswordUri = null;
                        continue;
                    }
                    sapPasswordUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sapClientId"))
                {
                    sapClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sapPortNumber"))
                {
                    sapPortNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sapSslCertificateUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sapSslCertificateUri = null;
                        continue;
                    }
                    sapSslCertificateUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerType"))
                {
                    providerType = property.Value.GetString();
                    continue;
                }
            }
            return new SapNetWeaverProviderInstanceProperties(providerType, sapSid.Value, sapHostname.Value, sapInstanceNr.Value, Optional.ToList(sapHostFileEntries), sapUsername.Value, sapPassword.Value, sapPasswordUri.Value, sapClientId.Value, sapPortNumber.Value, sapSslCertificateUri.Value);
        }
    }
}
