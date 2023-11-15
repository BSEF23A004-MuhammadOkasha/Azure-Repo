// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    public partial class CloudEndpointData : IUtf8JsonSerializable, IJsonModel<CloudEndpointData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudEndpointData>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<CloudEndpointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<CloudEndpointData>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<CloudEndpointData>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountResourceId))
            {
                writer.WritePropertyName("storageAccountResourceId"u8);
                writer.WriteStringValue(StorageAccountResourceId);
            }
            if (Optional.IsDefined(AzureFileShareName))
            {
                writer.WritePropertyName("azureFileShareName"u8);
                writer.WriteStringValue(AzureFileShareName);
            }
            if (Optional.IsDefined(StorageAccountTenantId))
            {
                writer.WritePropertyName("storageAccountTenantId"u8);
                writer.WriteStringValue(StorageAccountTenantId.Value);
            }
            if (Optional.IsDefined(PartnershipId))
            {
                writer.WritePropertyName("partnershipId"u8);
                writer.WriteStringValue(PartnershipId);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsBackupEnabled))
                {
                    writer.WritePropertyName("backupEnabled"u8);
                    writer.WriteStringValue(IsBackupEnabled);
                }
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(LastWorkflowId))
            {
                writer.WritePropertyName("lastWorkflowId"u8);
                writer.WriteStringValue(LastWorkflowId);
            }
            if (Optional.IsDefined(LastOperationName))
            {
                writer.WritePropertyName("lastOperationName"u8);
                writer.WriteStringValue(LastOperationName);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ChangeEnumerationStatus))
                {
                    writer.WritePropertyName("changeEnumerationStatus"u8);
                    writer.WriteObjectValue(ChangeEnumerationStatus);
                }
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        CloudEndpointData IJsonModel<CloudEndpointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CloudEndpointData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudEndpointData(document.RootElement, options);
        }

        internal static CloudEndpointData DeserializeCloudEndpointData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceIdentifier> storageAccountResourceId = default;
            Optional<string> azureFileShareName = default;
            Optional<Guid> storageAccountTenantId = default;
            Optional<string> partnershipId = default;
            Optional<string> friendlyName = default;
            Optional<string> backupEnabled = default;
            Optional<string> provisioningState = default;
            Optional<string> lastWorkflowId = default;
            Optional<string> lastOperationName = default;
            Optional<CloudEndpointChangeEnumerationStatus> changeEnumerationStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("storageAccountResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("azureFileShareName"u8))
                        {
                            azureFileShareName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountTenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountTenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("partnershipId"u8))
                        {
                            partnershipId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("backupEnabled"u8))
                        {
                            backupEnabled = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastWorkflowId"u8))
                        {
                            lastWorkflowId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastOperationName"u8))
                        {
                            lastOperationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("changeEnumerationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            changeEnumerationStatus = CloudEndpointChangeEnumerationStatus.DeserializeCloudEndpointChangeEnumerationStatus(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CloudEndpointData(id, name, type, systemData.Value, storageAccountResourceId.Value, azureFileShareName.Value, Optional.ToNullable(storageAccountTenantId), partnershipId.Value, friendlyName.Value, backupEnabled.Value, provisioningState.Value, lastWorkflowId.Value, lastOperationName.Value, changeEnumerationStatus.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CloudEndpointData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CloudEndpointData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        CloudEndpointData IPersistableModel<CloudEndpointData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CloudEndpointData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeCloudEndpointData(document.RootElement, options);
        }

        string IPersistableModel<CloudEndpointData>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
