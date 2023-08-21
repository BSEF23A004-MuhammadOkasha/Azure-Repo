// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class FrontDoorCustomDomainHttpsContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("certificateType"u8);
            writer.WriteStringValue(CertificateType.ToString());
            if (Core.Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion"u8);
                writer.WriteStringValue(MinimumTlsVersion.Value.ToSerialString());
            }
            if (Core.Optional.IsDefined(Secret))
            {
                if (Secret != null)
                {
                    writer.WritePropertyName("secret"u8);
                    writer.WriteObjectValue(Secret);
                }
                else
                {
                    writer.WriteNull("secret");
                }
            }
            writer.WriteEndObject();
        }

        internal static FrontDoorCustomDomainHttpsContent DeserializeFrontDoorCustomDomainHttpsContent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FrontDoorCertificateType certificateType = default;
            Core.Optional<FrontDoorMinimumTlsVersion> minimumTlsVersion = default;
            Core.Optional<FrontDoorCustomDomainHttpsContentSecret> secret = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateType"u8))
                {
                    certificateType = new FrontDoorCertificateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("minimumTlsVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimumTlsVersion = property.Value.GetString().ToFrontDoorMinimumTlsVersion();
                    continue;
                }
                if (property.NameEquals("secret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        secret = null;
                        continue;
                    }
                    secret = FrontDoorCustomDomainHttpsContentSecret.DeserializeFrontDoorCustomDomainHttpsContentSecret(property.Value);
                    continue;
                }
            }
            return new FrontDoorCustomDomainHttpsContent(certificateType, Core.Optional.ToNullable(minimumTlsVersion), secret.Value);
        }
    }
}
