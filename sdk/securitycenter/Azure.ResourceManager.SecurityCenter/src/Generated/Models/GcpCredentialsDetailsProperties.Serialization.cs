// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class GcpCredentialsDetailsProperties : IUtf8JsonSerializable, IJsonModel<GcpCredentialsDetailsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GcpCredentialsDetailsProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GcpCredentialsDetailsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GcpCredentialsDetailsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GcpCredentialsDetailsProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("organizationId"u8);
            writer.WriteStringValue(OrganizationId);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(GcpCredentialType);
            writer.WritePropertyName("projectId"u8);
            writer.WriteStringValue(ProjectId);
            writer.WritePropertyName("privateKeyId"u8);
            writer.WriteStringValue(PrivateKeyId);
            writer.WritePropertyName("privateKey"u8);
            writer.WriteStringValue(PrivateKey);
            writer.WritePropertyName("clientEmail"u8);
            writer.WriteStringValue(ClientEmail);
            writer.WritePropertyName("clientId"u8);
            writer.WriteStringValue(ClientId);
            writer.WritePropertyName("authUri"u8);
            writer.WriteStringValue(AuthUri.AbsoluteUri);
            writer.WritePropertyName("tokenUri"u8);
            writer.WriteStringValue(TokenUri.AbsoluteUri);
            writer.WritePropertyName("authProviderX509CertUrl"u8);
            writer.WriteStringValue(AuthProviderX509CertUri.AbsoluteUri);
            writer.WritePropertyName("clientX509CertUrl"u8);
            writer.WriteStringValue(ClientX509CertUri.AbsoluteUri);
        }

        GcpCredentialsDetailsProperties IJsonModel<GcpCredentialsDetailsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GcpCredentialsDetailsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GcpCredentialsDetailsProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGcpCredentialsDetailsProperties(document.RootElement, options);
        }

        internal static GcpCredentialsDetailsProperties DeserializeGcpCredentialsDetailsProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string organizationId = default;
            string type = default;
            string projectId = default;
            string privateKeyId = default;
            string privateKey = default;
            string clientEmail = default;
            string clientId = default;
            Uri authUri = default;
            Uri tokenUri = default;
            Uri authProviderX509CertUrl = default;
            Uri clientX509CertUrl = default;
            AuthenticationProvisioningState? authenticationProvisioningState = default;
            IReadOnlyList<SecurityCenterCloudPermission> grantedPermissions = default;
            AuthenticationType authenticationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("organizationId"u8))
                {
                    organizationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("projectId"u8))
                {
                    projectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateKeyId"u8))
                {
                    privateKeyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateKey"u8))
                {
                    privateKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientEmail"u8))
                {
                    clientEmail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authUri"u8))
                {
                    authUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tokenUri"u8))
                {
                    tokenUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authProviderX509CertUrl"u8))
                {
                    authProviderX509CertUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clientX509CertUrl"u8))
                {
                    clientX509CertUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authenticationProvisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationProvisioningState = new AuthenticationProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("grantedPermissions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityCenterCloudPermission> array = new List<SecurityCenterCloudPermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SecurityCenterCloudPermission(item.GetString()));
                    }
                    grantedPermissions = array;
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    authenticationType = new AuthenticationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new GcpCredentialsDetailsProperties(
                authenticationProvisioningState,
                grantedPermissions ?? new ChangeTrackingList<SecurityCenterCloudPermission>(),
                authenticationType,
                serializedAdditionalRawData,
                organizationId,
                type,
                projectId,
                privateKeyId,
                privateKey,
                clientEmail,
                clientId,
                authUri,
                tokenUri,
                authProviderX509CertUrl,
                clientX509CertUrl);
        }

        BinaryData IPersistableModel<GcpCredentialsDetailsProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GcpCredentialsDetailsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GcpCredentialsDetailsProperties)} does not support writing '{options.Format}' format.");
            }
        }

        GcpCredentialsDetailsProperties IPersistableModel<GcpCredentialsDetailsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GcpCredentialsDetailsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGcpCredentialsDetailsProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GcpCredentialsDetailsProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GcpCredentialsDetailsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
