// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Security.Attestation
{
    [JsonConverter(typeof(PolicyCertificatesModificationResultConverter))]
    public partial class PolicyCertificatesModificationResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CertificateThumbprint))
            {
                writer.WritePropertyName("x-ms-certificate-thumbprint"u8);
                writer.WriteStringValue(CertificateThumbprint);
            }
            if (Optional.IsDefined(CertificateResolution))
            {
                writer.WritePropertyName("x-ms-policycertificates-result"u8);
                writer.WriteStringValue(CertificateResolution.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static PolicyCertificatesModificationResult DeserializePolicyCertificatesModificationResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> xMsCertificateThumbprint = default;
            Optional<PolicyCertificateResolution> xMsPolicycertificatesResult = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("x-ms-certificate-thumbprint"u8))
                {
                    xMsCertificateThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-policycertificates-result"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xMsPolicycertificatesResult = new PolicyCertificateResolution(property.Value.GetString());
                    continue;
                }
            }
            return new PolicyCertificatesModificationResult(xMsCertificateThumbprint.Value, Optional.ToNullable(xMsPolicycertificatesResult));
        }

        internal partial class PolicyCertificatesModificationResultConverter : JsonConverter<PolicyCertificatesModificationResult>
        {
            public override void Write(Utf8JsonWriter writer, PolicyCertificatesModificationResult model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override PolicyCertificatesModificationResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializePolicyCertificatesModificationResult(document.RootElement);
            }
        }
    }
}
