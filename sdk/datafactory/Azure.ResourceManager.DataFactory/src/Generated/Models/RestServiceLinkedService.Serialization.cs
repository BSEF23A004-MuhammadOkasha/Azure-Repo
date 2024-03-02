// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class RestServiceLinkedService : IUtf8JsonSerializable, IJsonModel<RestServiceLinkedService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestServiceLinkedService>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RestServiceLinkedService>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestServiceLinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestServiceLinkedService)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(LinkedServiceType);
            if (ConnectVia != null)
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (!(Parameters is ChangeTrackingDictionary<string, EntityParameterSpecification> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Annotations is ChangeTrackingList<BinaryData> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("url"u8);
            JsonSerializer.Serialize(writer, Uri);
            if (EnableServerCertificateValidation != null)
            {
                writer.WritePropertyName("enableServerCertificateValidation"u8);
                JsonSerializer.Serialize(writer, EnableServerCertificateValidation);
            }
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteStringValue(AuthenticationType.ToString());
            if (UserName != null)
            {
                writer.WritePropertyName("userName"u8);
                JsonSerializer.Serialize(writer, UserName);
            }
            if (Password != null)
            {
                writer.WritePropertyName("password"u8);
                JsonSerializer.Serialize(writer, Password);
            }
            if (AuthHeaders != null)
            {
                writer.WritePropertyName("authHeaders"u8);
                JsonSerializer.Serialize(writer, AuthHeaders);
            }
            if (ServicePrincipalId != null)
            {
                writer.WritePropertyName("servicePrincipalId"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalId);
            }
            if (ServicePrincipalKey != null)
            {
                writer.WritePropertyName("servicePrincipalKey"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalKey);
            }
            if (Tenant != null)
            {
                writer.WritePropertyName("tenant"u8);
                JsonSerializer.Serialize(writer, Tenant);
            }
            if (AzureCloudType != null)
            {
                writer.WritePropertyName("azureCloudType"u8);
                JsonSerializer.Serialize(writer, AzureCloudType);
            }
            if (AadResourceId != null)
            {
                writer.WritePropertyName("aadResourceId"u8);
                JsonSerializer.Serialize(writer, AadResourceId);
            }
            if (EncryptedCredential != null)
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteStringValue(EncryptedCredential);
            }
            if (Credential != null)
            {
                writer.WritePropertyName("credential"u8);
                writer.WriteObjectValue(Credential);
            }
            if (ClientId != null)
            {
                writer.WritePropertyName("clientId"u8);
                JsonSerializer.Serialize(writer, ClientId);
            }
            if (ClientSecret != null)
            {
                writer.WritePropertyName("clientSecret"u8);
                JsonSerializer.Serialize(writer, ClientSecret);
            }
            if (TokenEndpoint != null)
            {
                writer.WritePropertyName("tokenEndpoint"u8);
                JsonSerializer.Serialize(writer, TokenEndpoint);
            }
            if (Resource != null)
            {
                writer.WritePropertyName("resource"u8);
                JsonSerializer.Serialize(writer, Resource);
            }
            if (Scope != null)
            {
                writer.WritePropertyName("scope"u8);
                JsonSerializer.Serialize(writer, Scope);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        RestServiceLinkedService IJsonModel<RestServiceLinkedService>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestServiceLinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestServiceLinkedService)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestServiceLinkedService(document.RootElement, options);
        }

        internal static RestServiceLinkedService DeserializeRestServiceLinkedService(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            IntegrationRuntimeReference connectVia = default;
            string description = default;
            IDictionary<string, EntityParameterSpecification> parameters = default;
            IList<BinaryData> annotations = default;
            DataFactoryElement<string> url = default;
            DataFactoryElement<bool> enableServerCertificateValidation = default;
            RestServiceAuthenticationType authenticationType = default;
            DataFactoryElement<string> userName = default;
            DataFactorySecretBaseDefinition password = default;
            DataFactoryElement<BinaryData> authHeaders = default;
            DataFactoryElement<string> servicePrincipalId = default;
            DataFactorySecretBaseDefinition servicePrincipalKey = default;
            DataFactoryElement<string> tenant = default;
            DataFactoryElement<string> azureCloudType = default;
            DataFactoryElement<string> aadResourceId = default;
            string encryptedCredential = default;
            DataFactoryCredentialReference credential = default;
            DataFactoryElement<string> clientId = default;
            DataFactorySecretBaseDefinition clientSecret = default;
            DataFactoryElement<string> tokenEndpoint = default;
            DataFactoryElement<string> resource = default;
            DataFactoryElement<string> scope = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value, options));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("url"u8))
                        {
                            url = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("enableServerCertificateValidation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableServerCertificateValidation = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("authenticationType"u8))
                        {
                            authenticationType = new RestServiceAuthenticationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("userName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            userName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            password = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("authHeaders"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authHeaders = JsonSerializer.Deserialize<DataFactoryElement<BinaryData>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipalKey = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("tenant"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenant = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("azureCloudType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureCloudType = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("aadResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadResourceId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            encryptedCredential = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("credential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            credential = DataFactoryCredentialReference.DeserializeDataFactoryCredentialReference(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("clientId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("clientSecret"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientSecret = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("tokenEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tokenEndpoint = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("resource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resource = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("scope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scope = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new RestServiceLinkedService(
                type,
                connectVia,
                description,
                parameters ?? new ChangeTrackingDictionary<string, EntityParameterSpecification>(),
                annotations ?? new ChangeTrackingList<BinaryData>(),
                additionalProperties,
                url,
                enableServerCertificateValidation,
                authenticationType,
                userName,
                password,
                authHeaders,
                servicePrincipalId,
                servicePrincipalKey,
                tenant,
                azureCloudType,
                aadResourceId,
                encryptedCredential,
                credential,
                clientId,
                clientSecret,
                tokenEndpoint,
                resource,
                scope);
        }

        BinaryData IPersistableModel<RestServiceLinkedService>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestServiceLinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RestServiceLinkedService)} does not support '{options.Format}' format.");
            }
        }

        RestServiceLinkedService IPersistableModel<RestServiceLinkedService>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestServiceLinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRestServiceLinkedService(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RestServiceLinkedService)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestServiceLinkedService>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
