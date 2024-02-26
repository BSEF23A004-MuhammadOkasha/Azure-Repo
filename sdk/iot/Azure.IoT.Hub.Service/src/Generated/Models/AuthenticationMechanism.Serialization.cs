// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class AuthenticationMechanism : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (SymmetricKey != null)
            {
                writer.WritePropertyName("symmetricKey"u8);
                writer.WriteObjectValue(SymmetricKey);
            }
            if (X509Thumbprint != null)
            {
                writer.WritePropertyName("x509Thumbprint"u8);
                writer.WriteObjectValue(X509Thumbprint);
            }
            if (Type.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AuthenticationMechanism DeserializeAuthenticationMechanism(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SymmetricKey> symmetricKey = default;
            Optional<X509Thumbprint> x509Thumbprint = default;
            Optional<AuthenticationMechanismType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("symmetricKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    symmetricKey = SymmetricKey.DeserializeSymmetricKey(property.Value);
                    continue;
                }
                if (property.NameEquals("x509Thumbprint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    x509Thumbprint = X509Thumbprint.DeserializeX509Thumbprint(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new AuthenticationMechanismType(property.Value.GetString());
                    continue;
                }
            }
            return new AuthenticationMechanism(symmetricKey.Value, x509Thumbprint.Value, Optional.ToNullable(type));
        }
    }
}
