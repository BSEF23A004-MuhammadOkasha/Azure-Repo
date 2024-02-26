// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubCertificatePropertiesWithNonce : IUtf8JsonSerializable, IJsonModel<IotHubCertificatePropertiesWithNonce>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubCertificatePropertiesWithNonce>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IotHubCertificatePropertiesWithNonce>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubCertificatePropertiesWithNonce>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubCertificatePropertiesWithNonce)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Subject != null)
            {
                writer.WritePropertyName("subject"u8);
                writer.WriteStringValue(Subject);
            }
            if (options.Format != "W" && ExpireOn.HasValue)
            {
                writer.WritePropertyName("expiry"u8);
                writer.WriteStringValue(ExpireOn.Value, "R");
            }
            if (options.Format != "W" && ThumbprintString != null)
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(ThumbprintString);
            }
            if (options.Format != "W" && IsVerified.HasValue)
            {
                writer.WritePropertyName("isVerified"u8);
                writer.WriteBooleanValue(IsVerified.Value);
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("created"u8);
                writer.WriteStringValue(CreatedOn.Value, "R");
            }
            if (options.Format != "W" && UpdatedOn.HasValue)
            {
                writer.WritePropertyName("updated"u8);
                writer.WriteStringValue(UpdatedOn.Value, "R");
            }
            if (options.Format != "W" && VerificationCode != null)
            {
                writer.WritePropertyName("verificationCode"u8);
                writer.WriteStringValue(VerificationCode);
            }
            if (options.Format != "W" && Certificate != null)
            {
                writer.WritePropertyName("certificate"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Certificate);
#else
                using (JsonDocument document = JsonDocument.Parse(Certificate))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        IotHubCertificatePropertiesWithNonce IJsonModel<IotHubCertificatePropertiesWithNonce>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubCertificatePropertiesWithNonce>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubCertificatePropertiesWithNonce)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubCertificatePropertiesWithNonce(document.RootElement, options);
        }

        internal static IotHubCertificatePropertiesWithNonce DeserializeIotHubCertificatePropertiesWithNonce(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> subject = default;
            Optional<DateTimeOffset> expiry = default;
            Optional<string> thumbprint = default;
            Optional<bool> isVerified = default;
            Optional<DateTimeOffset> created = default;
            Optional<DateTimeOffset> updated = default;
            Optional<string> verificationCode = default;
            Optional<BinaryData> certificate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                    thumbprint = property.Value.GetString();
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
                if (property.NameEquals("verificationCode"u8))
                {
                    verificationCode = property.Value.GetString();
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotHubCertificatePropertiesWithNonce(subject.Value, Optional.ToNullable(expiry), thumbprint.Value, Optional.ToNullable(isVerified), Optional.ToNullable(created), Optional.ToNullable(updated), verificationCode.Value, certificate.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubCertificatePropertiesWithNonce>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubCertificatePropertiesWithNonce>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotHubCertificatePropertiesWithNonce)} does not support '{options.Format}' format.");
            }
        }

        IotHubCertificatePropertiesWithNonce IPersistableModel<IotHubCertificatePropertiesWithNonce>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubCertificatePropertiesWithNonce>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotHubCertificatePropertiesWithNonce(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotHubCertificatePropertiesWithNonce)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotHubCertificatePropertiesWithNonce>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
