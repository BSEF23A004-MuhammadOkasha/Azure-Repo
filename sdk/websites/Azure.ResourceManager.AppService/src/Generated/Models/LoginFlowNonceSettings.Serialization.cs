// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class LoginFlowNonceSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ValidateNonce))
            {
                writer.WritePropertyName("validateNonce"u8);
                writer.WriteBooleanValue(ValidateNonce.Value);
            }
            if (Core.Optional.IsDefined(NonceExpirationInterval))
            {
                writer.WritePropertyName("nonceExpirationInterval"u8);
                writer.WriteStringValue(NonceExpirationInterval);
            }
            writer.WriteEndObject();
        }

        internal static LoginFlowNonceSettings DeserializeLoginFlowNonceSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool> validateNonce = default;
            Core.Optional<string> nonceExpirationInterval = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validateNonce"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validateNonce = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nonceExpirationInterval"u8))
                {
                    nonceExpirationInterval = property.Value.GetString();
                    continue;
                }
            }
            return new LoginFlowNonceSettings(Core.Optional.ToNullable(validateNonce), nonceExpirationInterval.Value);
        }
    }
}
