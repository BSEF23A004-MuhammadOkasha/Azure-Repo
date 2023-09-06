// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    public partial class CertificateVerificationCodeProperties : IUtf8JsonSerializable, IModelJsonSerializable<CertificateVerificationCodeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CertificateVerificationCodeProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CertificateVerificationCodeProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CertificateVerificationCodeProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(VerificationCode))
            {
                writer.WritePropertyName("verificationCode"u8);
                writer.WriteStringValue(VerificationCode);
            }
            if (Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("subject"u8);
                writer.WriteStringValue(Subject);
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiry"u8);
                writer.WriteStringValue(ExpireOn.Value, "R");
            }
            if (Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Thumbprint);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Thumbprint.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(IsVerified))
            {
                writer.WritePropertyName("isVerified"u8);
                writer.WriteBooleanValue(IsVerified.Value);
            }
            if (Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Certificate);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Certificate.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("created"u8);
                writer.WriteStringValue(CreatedOn.Value, "R");
            }
            if (Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updated"u8);
                writer.WriteStringValue(UpdatedOn.Value, "R");
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static CertificateVerificationCodeProperties DeserializeCertificateVerificationCodeProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> verificationCode = default;
            Optional<string> subject = default;
            Optional<DateTimeOffset> expiry = default;
            Optional<BinaryData> thumbprint = default;
            Optional<bool> isVerified = default;
            Optional<BinaryData> certificate = default;
            Optional<DateTimeOffset> created = default;
            Optional<DateTimeOffset> updated = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("verificationCode"u8))
                {
                    verificationCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subject"u8))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiry = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    thumbprint = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("isVerified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("certificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificate = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("created"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    created = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (property.NameEquals("updated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updated = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CertificateVerificationCodeProperties(verificationCode.Value, subject.Value, Optional.ToNullable(expiry), thumbprint.Value, Optional.ToNullable(isVerified), certificate.Value, Optional.ToNullable(created), Optional.ToNullable(updated), rawData);
        }

        CertificateVerificationCodeProperties IModelJsonSerializable<CertificateVerificationCodeProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CertificateVerificationCodeProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCertificateVerificationCodeProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CertificateVerificationCodeProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CertificateVerificationCodeProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CertificateVerificationCodeProperties IModelSerializable<CertificateVerificationCodeProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CertificateVerificationCodeProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCertificateVerificationCodeProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CertificateVerificationCodeProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CertificateVerificationCodeProperties"/> to convert. </param>
        public static implicit operator RequestContent(CertificateVerificationCodeProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CertificateVerificationCodeProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CertificateVerificationCodeProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCertificateVerificationCodeProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
