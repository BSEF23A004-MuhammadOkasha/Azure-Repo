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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AzureMLLinkedService : IUtf8JsonSerializable, IJsonModel<AzureMLLinkedService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureMLLinkedService>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureMLLinkedService>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMLLinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureMLLinkedService)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("mlEndpoint"u8);
            JsonSerializer.Serialize(writer, MLEndpoint);
            writer.WritePropertyName("apiKey"u8);
            JsonSerializer.Serialize(writer, ApiKey);
            if (Optional.IsDefined(UpdateResourceEndpoint))
            {
                writer.WritePropertyName("updateResourceEndpoint"u8);
                JsonSerializer.Serialize(writer, UpdateResourceEndpoint);
            }
            if (Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalId);
            }
            if (Optional.IsDefined(ServicePrincipalKey))
            {
                writer.WritePropertyName("servicePrincipalKey"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalKey);
            }
            if (Optional.IsDefined(Tenant))
            {
                writer.WritePropertyName("tenant"u8);
                JsonSerializer.Serialize(writer, Tenant);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteStringValue(EncryptedCredential);
            }
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication"u8);
                JsonSerializer.Serialize(writer, Authentication);
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
        }

        AzureMLLinkedService IJsonModel<AzureMLLinkedService>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMLLinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureMLLinkedService)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureMLLinkedService(document.RootElement, options);
        }

        internal static AzureMLLinkedService DeserializeAzureMLLinkedService(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string version = default;
            IntegrationRuntimeReference connectVia = default;
            string description = default;
            IDictionary<string, EntityParameterSpecification> parameters = default;
            IList<BinaryData> annotations = default;
            DataFactoryElement<string> mlEndpoint = default;
            DataFactorySecret apiKey = default;
            DataFactoryElement<string> updateResourceEndpoint = default;
            DataFactoryElement<string> servicePrincipalId = default;
            DataFactorySecret servicePrincipalKey = default;
            DataFactoryElement<string> tenant = default;
            string encryptedCredential = default;
            DataFactoryElement<string> authentication = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
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
                        if (property0.NameEquals("mlEndpoint"u8))
                        {
                            mlEndpoint = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("apiKey"u8))
                        {
                            apiKey = JsonSerializer.Deserialize<DataFactorySecret>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("updateResourceEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updateResourceEndpoint = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
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
                            servicePrincipalKey = JsonSerializer.Deserialize<DataFactorySecret>(property0.Value.GetRawText());
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
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            encryptedCredential = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authentication = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureMLLinkedService(
                type,
                version,
                connectVia,
                description,
                parameters ?? new ChangeTrackingDictionary<string, EntityParameterSpecification>(),
                annotations ?? new ChangeTrackingList<BinaryData>(),
                additionalProperties,
                mlEndpoint,
                apiKey,
                updateResourceEndpoint,
                servicePrincipalId,
                servicePrincipalKey,
                tenant,
                encryptedCredential,
                authentication);
        }

        BinaryData IPersistableModel<AzureMLLinkedService>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMLLinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureMLLinkedService)} does not support writing '{options.Format}' format.");
            }
        }

        AzureMLLinkedService IPersistableModel<AzureMLLinkedService>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMLLinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureMLLinkedService(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureMLLinkedService)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureMLLinkedService>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
